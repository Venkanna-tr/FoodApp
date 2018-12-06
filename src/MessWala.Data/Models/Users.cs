using System;
using System.Collections.Generic;

namespace MessWala.Data.Models
{
    public partial class Users
    {
        public Users()
        {
            FoodItems = new HashSet<FoodItems>();
            InverseCreatedByNavigation = new HashSet<Users>();
            PlanItems = new HashSet<PlanItems>();
            Plans = new HashSet<Plans>();
            RestaurantUsersCreatedByNavigation = new HashSet<RestaurantUsers>();
            RestaurantUsersUser = new HashSet<RestaurantUsers>();
            Restaurants = new HashSet<Restaurants>();
            SubCategories = new HashSet<SubCategories>();
            SubscriptionUser = new HashSet<SubscriptionUser>();
            UserLogs = new HashSet<UserLogs>();
            UserOrdersCreatedByNavigation = new HashSet<UserOrders>();
            UserOrdersUser = new HashSet<UserOrders>();
            UserProofs = new HashSet<UserProofs>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int? RoleId { get; set; }
        public int? StatusTypeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Roles Role { get; set; }
        public virtual StatusTypes StatusType { get; set; }
        public virtual UserCredentials UserCredentials { get; set; }
        public virtual ICollection<FoodItems> FoodItems { get; set; }
        public virtual ICollection<Users> InverseCreatedByNavigation { get; set; }
        public virtual ICollection<PlanItems> PlanItems { get; set; }
        public virtual ICollection<Plans> Plans { get; set; }
        public virtual ICollection<RestaurantUsers> RestaurantUsersCreatedByNavigation { get; set; }
        public virtual ICollection<RestaurantUsers> RestaurantUsersUser { get; set; }
        public virtual ICollection<Restaurants> Restaurants { get; set; }
        public virtual ICollection<SubCategories> SubCategories { get; set; }
        public virtual ICollection<SubscriptionUser> SubscriptionUser { get; set; }
        public virtual ICollection<UserLogs> UserLogs { get; set; }
        public virtual ICollection<UserOrders> UserOrdersCreatedByNavigation { get; set; }
        public virtual ICollection<UserOrders> UserOrdersUser { get; set; }
        public virtual ICollection<UserProofs> UserProofs { get; set; }
    }
}
