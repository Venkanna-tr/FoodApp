using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class PlanItems
    {
        public int PlanItemId { get; set; }
        public int? PlanId { get; set; }
        public DateTime? DateOfPlan { get; set; }
        public int? PlanMasterId { get; set; }
        public int[] SelectedItemIds { get; set; }
        public int? MaxNoofItems { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? StatusTypeId { get; set; }
        public int[] DefaultItemIds { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Plans Plan { get; set; }
        public virtual StatusTypes StatusType { get; set; }
    }
}
