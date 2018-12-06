using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class AppRoleMenus
    {
        public int AppRoleId { get; set; }
        public int? RoleId { get; set; }
        public int? AppsubMenuId { get; set; }
        public bool? CanView { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanDelete { get; set; }
        public bool? CanAdd { get; set; }

        public virtual AppSubMenus AppsubMenu { get; set; }
        public virtual Roles Role { get; set; }
    }
}
