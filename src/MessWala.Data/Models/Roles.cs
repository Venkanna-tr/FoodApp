using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class Roles
    {
        public Roles()
        {
            AppRoleMenus = new HashSet<AppRoleMenus>();
            Users = new HashSet<Users>();
        }

        public int RoleId { get; set; }
        public string RoleType { get; set; }

        public virtual ICollection<AppRoleMenus> AppRoleMenus { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
