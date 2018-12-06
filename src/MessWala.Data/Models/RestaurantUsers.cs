using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class RestaurantUsers
    {
        public int RestaurantUserId { get; set; }
        public int? UserId { get; set; }
        public int? RestaurantId { get; set; }
        public int? StatusTypeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Restaurants Restaurant { get; set; }
        public virtual Users User { get; set; }
    }
}
