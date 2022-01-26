using SmayDbEditor.DataAccessLayer.Models;
using System.Collections.Generic;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface IUserRepository
    {
        UserModel GetUserByUsername(string username);
        UserModel AddUser(UserModel userModel);
        IEnumerable<UserGroupModel> GetUserGroups();
        IEnumerable<UserGroupModel> GetUserGroupsForUser(int userId);
    }
}
