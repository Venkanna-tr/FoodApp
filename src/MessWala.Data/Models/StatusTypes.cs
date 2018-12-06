using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class StatusTypes
    {
        public StatusTypes()
        {
            AppMainMenus = new HashSet<AppMainMenus>();
            AppSubMenus = new HashSet<AppSubMenus>();
            Categories = new HashSet<Categories>();
            PlanItems = new HashSet<PlanItems>();
            PlanMaster = new HashSet<PlanMaster>();
            Plans = new HashSet<Plans>();
            Restaurants = new HashSet<Restaurants>();
            SubCategories = new HashSet<SubCategories>();
            SubscriptionUser = new HashSet<SubscriptionUser>();
            UserOrders = new HashSet<UserOrders>();
            Users = new HashSet<Users>();
        }

        public int StatusTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AppMainMenus> AppMainMenus { get; set; }
        public virtual ICollection<AppSubMenus> AppSubMenus { get; set; }
        public virtual ICollection<Categories> Categories { get; set; }
        public virtual ICollection<PlanItems> PlanItems { get; set; }
        public virtual ICollection<PlanMaster> PlanMaster { get; set; }
        public virtual ICollection<Plans> Plans { get; set; }
        public virtual ICollection<Restaurants> Restaurants { get; set; }
        public virtual ICollection<SubCategories> SubCategories { get; set; }
        public virtual ICollection<SubscriptionUser> SubscriptionUser { get; set; }
        public virtual ICollection<UserOrders> UserOrders { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
