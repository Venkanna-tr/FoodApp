using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class UserLogs
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string SessionId { get; set; }
        public bool? LoginStatus { get; set; }
        public string ClientIp { get; set; }
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string DeviceModel { get; set; }

        public virtual Users User { get; set; }
    }
}
