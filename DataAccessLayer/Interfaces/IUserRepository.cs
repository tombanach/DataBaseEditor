using SmayDbEditor.DataAccessLayer.Models;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface IUserRepository
    {
        UserModel GetUserByUsername(string username);
        UserModel AddUser(UserModel userModel);
    }
}
