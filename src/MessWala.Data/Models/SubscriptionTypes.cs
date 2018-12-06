using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class SubscriptionTypes
    {
        public SubscriptionTypes()
        {
            SubscriptionUser = new HashSet<SubscriptionUser>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SubscriptionUser> SubscriptionUser { get; set; }
    }
}
