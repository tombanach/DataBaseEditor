using SmayDbEditor.DataAccessLayer.Models;
using SmayDbEditor.DataAccessLayer.Utils;
using System.Collections.Generic;
using System.Linq;

namespace SmayDbEditor.DataAccessLayer.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public IEnumerable<UserGroupModel> UserGroups { get; set; }
        public bool IsInAdministrators => UserGroups.Any(x => x.GroupName == Naming.UserGroups.Administartors);
    }
}
