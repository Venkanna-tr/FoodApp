using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class UserOrders
    {
        public int UserOrderId { get; set; }
        public int? UserId { get; set; }
        public int? PlanId { get; set; }
        public DateTime? DateOfPlan { get; set; }
        public int? PlanMasterId { get; set; }
        public int[] ItemIds { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? StatusTypeId { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Plans Plan { get; set; }
        public virtual StatusTypes StatusType { get; set; }
        public virtual Users User { get; set; }
    }
}
