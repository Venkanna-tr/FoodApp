using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class Categories
    {
        public Categories()
        {
            FoodItems = new HashSet<FoodItems>();
            SubCategories = new HashSet<SubCategories>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int? StatusTypeId { get; set; }

        public virtual StatusTypes StatusType { get; set; }
        public virtual ICollection<FoodItems> FoodItems { get; set; }
        public virtual ICollection<SubCategories> SubCategories { get; set; }
    }
}
