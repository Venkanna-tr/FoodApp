using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class Restaurants
    {
        public Restaurants()
        {
            FoodItems = new HashSet<FoodItems>();
            Plans = new HashSet<Plans>();
            RestaurantUsers = new HashSet<RestaurantUsers>();
            SubCategories = new HashSet<SubCategories>();
            SubscriptionUser = new HashSet<SubscriptionUser>();
        }

        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string MobileNo { get; set; }
        public int? MailId { get; set; }
        public int? StatusTypeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual StatusTypes StatusType { get; set; }
        public virtual ICollection<FoodItems> FoodItems { get; set; }
        public virtual ICollection<Plans> Plans { get; set; }
        public virtual ICollection<RestaurantUsers> RestaurantUsers { get; set; }
        public virtual ICollection<SubCategories> SubCategories { get; set; }
        public virtual ICollection<SubscriptionUser> SubscriptionUser { get; set; }
    }
}
