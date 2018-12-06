using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class UserCredentials
    {
        public int Id { get; set; }
        public string PasswordEncryption { get; set; }
        public string PasswordHash { get; set; }

        public virtual Users IdNavigation { get; set; }
    }
}
