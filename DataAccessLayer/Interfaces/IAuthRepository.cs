using SmayDbEditor.DataAccessLayer.Models;

namespace SmayDbEditor.DataAccessLayer.Interfaces
{
    public interface IAuthRepository
    {
        UserModel Login(string username, string password);
        UserModel Register(string username, string password, UserGroupModel group);
    }
}
