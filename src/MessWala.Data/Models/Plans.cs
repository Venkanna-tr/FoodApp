using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class Plans
    {
        public Plans()
        {
            PlanItems = new HashSet<PlanItems>();
            SubscriptionUser = new HashSet<SubscriptionUser>();
            UserOrders = new HashSet<UserOrders>();
        }

        public int PlanId { get; set; }
        public string Name { get; set; }
        public int? RestaurantId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? StatusTypeId { get; set; }
        public int? PlanMasterId { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual PlanMaster PlanMaster { get; set; }
        public virtual Restaurants Restaurant { get; set; }
        public virtual StatusTypes StatusType { get; set; }
        public virtual ICollection<PlanItems> PlanItems { get; set; }
        public virtual ICollection<SubscriptionUser> SubscriptionUser { get; set; }
        public virtual ICollection<UserOrders> UserOrders { get; set; }
    }
}
