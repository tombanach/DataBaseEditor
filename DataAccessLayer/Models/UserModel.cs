using SmayDbEditor.DataAccessLayer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmayDbEditor.DataAccessLayer.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PwdHash { get; set; }
        public string PwdSalt { get; set; }
        public DateTime DateCreated { get; set; }
        public IEnumerable<UserGroupModel> UserGroups { get; set; }
    }
}
