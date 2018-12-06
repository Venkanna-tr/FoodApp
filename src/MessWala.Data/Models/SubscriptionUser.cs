using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class SubscriptionUser
    {
        public int SubscriptionUserId { get; set; }
        public int? UserId { get; set; }
        public int? RestaurantId { get; set; }
        public int? SubcriptionTypeId { get; set; }
        public int? PlanId { get; set; }
        public int? StatusTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Plans Plan { get; set; }
        public virtual Restaurants Restaurant { get; set; }
        public virtual StatusTypes StatusType { get; set; }
        public virtual SubscriptionTypes SubcriptionType { get; set; }
        public virtual Users User { get; set; }
    }
}
