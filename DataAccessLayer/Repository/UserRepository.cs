using Dapper;
using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace SmayDbEditor.DataAccessLayer.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IDbConnection connection) : base(connection)
        {
        }

        public UserModel AddUser(UserModel userModel)
        {
            var sqlInsertUser = $"insert into dbo.Users(Username, PwdHash, PwdSalt, DateCreated) " +
                $"output inserted.* " +
                $"values(@username, @pwdHash, @pwdSalt, getdate())";

            var createdUser = _wmsConnection.QuerySingle<UserModel>(sqlInsertUser, new
            {
                @username = userModel.Username,
                @pwdHash = userModel.PwdHash,
                @pwdSalt = userModel.PwdSalt,
            });

            foreach (var userGroup in userModel.UserGroups)
            {
                var sqlInsertUserUserGroup = $"insert into dbo.User_UserGroups(UserId, GroupId) " +
                    $"values(@userId, @groupId)";

                _wmsConnection.Execute(sqlInsertUserUserGroup, new 
                {
                    @userId = createdUser.Id, @groupId = userGroup.Id 
                });
            }

            return createdUser;
        }

        public UserModel GetUserByUsername(string username)
        {
            try
            {
                var sql = $"select Id, Username, PwdHash, PwdSalt, DateCreated from dbo.Users where Username = @username";

                var user = _wmsConnection.QueryFirst<UserModel>(sql, new { @username = username });
                user.UserGroups = GetUserGroupsForUser(user.Id);

                return user;
            }
            catch (InvalidOperationException)
            {
                // user does not exist
                return null;
            }
        }

        public IEnumerable<UserGroupModel> GetUserGroups()
        {
            var sql = $"select [Id], [GroupName] from dbo.UserGroups order by [Order]";

            return _wmsConnection.Query<UserGroupModel>(sql, null);
        }

        public IEnumerable<UserGroupModel> GetUserGroupsForUser(int userId)
        {
            var sql = $"select ug.Id, ug.GroupName " +
                $"from dbo.Users u " +
                $"join dbo.User_UserGroups uug on u.Id = uug.UserId " +
                $"join dbo.UserGroups ug on uug.GroupId = ug.Id " +
                $"where u.Id = @userId";

            return _wmsConnection.Query<UserGroupModel>(sql, new { @userId = userId });
        }
    }
}
