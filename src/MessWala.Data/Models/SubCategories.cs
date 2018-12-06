using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            FoodItems = new HashSet<FoodItems>();
        }

        public int SubCategoryId { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public int? RestaurantId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDated { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? StatusTypeId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Restaurants Restaurant { get; set; }
        public virtual StatusTypes StatusType { get; set; }
        public virtual ICollection<FoodItems> FoodItems { get; set; }
    }
}
