using Dapper;
using SmayDbEditor.DataAccessLayer.Interfaces;
using SmayDbEditor.DataAccessLayer.Models;
using System;
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
            var sql = $"insert into dbo.Users(Username, PwdHash, PwdSalt, DateCreated) " +
                $"output inserted.* " +
                $"values(@username, @pwdHash, @pwdSalt, getdate())";

            return _wmsConnection.QuerySingle<UserModel>(
                sql,
                new 
                {
                    @username = userModel.Username,
                    @pwdHash = userModel.PwdHash,
                    @pwdSalt = userModel.PwdSalt,
                });
        }

        public UserModel GetUserByUsername(string username)
        {
            try
            {
                var sql = $"select Id, Username, PwdHash, PwdSalt, DateCreated from dbo.Users where Username = @username";

                return _wmsConnection.QueryFirst<UserModel>(sql, new { @username = username });
            }
            catch (InvalidOperationException)
            {
                // user does not exist
                return null;
            }
        }
    }
}
