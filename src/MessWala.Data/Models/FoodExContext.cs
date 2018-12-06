using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MessWala.Data.Models {
    public partial class FoodExContext : DbContext {
        public FoodExContext () { }

        public FoodExContext (DbContextOptions<FoodExContext> options) : base (options) { }

        public virtual DbSet<AppMainMenus> AppMainMenus { get; set; }
        public virtual DbSet<AppRoleMenus> AppRoleMenus { get; set; }
        public virtual DbSet<AppSubMenus> AppSubMenus { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<FoodItems> FoodItems { get; set; }
        public virtual DbSet<PlanItems> PlanItems { get; set; }
        public virtual DbSet<PlanMaster> PlanMaster { get; set; }
        public virtual DbSet<Plans> Plans { get; set; }
        public virtual DbSet<ProofTypes> ProofTypes { get; set; }
        public virtual DbSet<RestaurantUsers> RestaurantUsers { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<StatusTypes> StatusTypes { get; set; }
        public virtual DbSet<SubCategories> SubCategories { get; set; }
        public virtual DbSet<SubscriptionTypes> SubscriptionTypes { get; set; }
        public virtual DbSet<SubscriptionUser> SubscriptionUser { get; set; }
        public virtual DbSet<UserCredentials> UserCredentials { get; set; }
        public virtual DbSet<UserLogs> UserLogs { get; set; }
        public virtual DbSet<UserOrders> UserOrders { get; set; }
        public virtual DbSet<UserProofs> UserProofs { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        // Unable to generate entity type for table 'public.Temp'. Please see the warning messages.

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql ("Host=192.168.1.6;Database=FoodEx;Username=foodexuser;Password=foodexuser6");
            }
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.HasAnnotation ("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<AppMainMenus> (entity => {
                entity.HasKey (e => e.AppMainMenuId)
                    .HasName ("AppMainMenus_pkey");

                entity.ToTable ("AppMainMenus", "FoodExSch");

                entity.Property (e => e.AppMainMenuId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"AppMainMenus_AppMainMenuId_seq\"'::regclass)");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.AppMainMenus)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("AppMainMenus_StatusTypeId_fkey");
            });

            modelBuilder.Entity<AppRoleMenus> (entity => {
                entity.HasKey (e => e.AppRoleId)
                    .HasName ("AppRoleMenus_pkey");

                entity.ToTable ("AppRoleMenus", "FoodExSch");

                entity.Property (e => e.AppRoleId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"AppRoleMenus_AppRoleId_seq\"'::regclass)");

                entity.HasOne (d => d.AppsubMenu)
                    .WithMany (p => p.AppRoleMenus)
                    .HasForeignKey (d => d.AppsubMenuId)
                    .HasConstraintName ("AppRoleMenus_SubMenuId_fkey");

                entity.HasOne (d => d.Role)
                    .WithMany (p => p.AppRoleMenus)
                    .HasForeignKey (d => d.RoleId)
                    .HasConstraintName ("AppRoleMenus_RoleId_fkey");
            });

            modelBuilder.Entity<AppSubMenus> (entity => {
                entity.HasKey (e => e.AppsubMenuId)
                    .HasName ("AppSubMenus_pkey");

                entity.ToTable ("AppSubMenus", "FoodExSch");

                entity.Property (e => e.AppsubMenuId)
                    .HasColumnName ("AppsubMenuId ")
                    .HasDefaultValueSql ("nextval('\"FoodExSch\".\"AppSubMenus_AppsubMenuId _seq\"'::regclass)");

                entity.HasOne (d => d.AppMainMenu)
                    .WithMany (p => p.AppSubMenus)
                    .HasForeignKey (d => d.AppMainMenuId)
                    .HasConstraintName ("AppSubMenus_AppMainMenuId_fkey");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.AppSubMenus)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("AppSubMenus_StatusTypeId_fkey");
            });

            modelBuilder.Entity<Categories> (entity => {
                entity.HasKey (e => e.CategoryId)
                    .HasName ("Categories_pkey");

                entity.ToTable ("Categories", "FoodExSch");

                entity.Property (e => e.CategoryId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"Categories_CategoryId_seq\"'::regclass)");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.Categories)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("Categories_StatusTypeId_fkey");
            });

            modelBuilder.Entity<FoodItems> (entity => {
                entity.HasKey (e => e.ItemId)
                    .HasName ("FoodItems_pkey");

                entity.ToTable ("FoodItems", "FoodExSch");

                entity.Property (e => e.ItemId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"FoodItems_ItemId_seq\"'::regclass)");

                entity.Property (e => e.CreatedDate).HasColumnType ("date");

                entity.Property (e => e.UpdatedDate).HasColumnType ("date");

                entity.HasOne (d => d.Category)
                    .WithMany (p => p.FoodItems)
                    .HasForeignKey (d => d.CategoryId)
                    .HasConstraintName ("FoodItems_CategoryId_fkey");

                entity.HasOne (d => d.CreatedByNavigation)
                    .WithMany (p => p.FoodItems)
                    .HasForeignKey (d => d.CreatedBy)
                    .HasConstraintName ("FoodItems_CreatedBy_fkey");

                entity.HasOne (d => d.Restaurant)
                    .WithMany (p => p.FoodItems)
                    .HasForeignKey (d => d.RestaurantId)
                    .HasConstraintName ("FoodItems_RestaurantId_fkey");

                entity.HasOne (d => d.SubCategory)
                    .WithMany (p => p.FoodItems)
                    .HasForeignKey (d => d.SubCategoryId)
                    .HasConstraintName ("FoodItems_SubCategoryId_fkey");
            });

            modelBuilder.Entity<PlanItems> (entity => {
                entity.HasKey (e => e.PlanItemId)
                    .HasName ("PlanItems_pkey");

                entity.ToTable ("PlanItems", "FoodExSch");

                entity.Property (e => e.PlanItemId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"PlanItems_PlanItemId_seq\"'::regclass)");

                entity.Property (e => e.CreatedDate).HasColumnType ("date");

                entity.Property (e => e.DateOfPlan).HasColumnType ("date");

                entity.Property (e => e.MaxNoofItems).HasColumnName ("Max.NoofItems");

                entity.Property (e => e.UpdatedDate).HasColumnType ("date");

                entity.HasOne (d => d.CreatedByNavigation)
                    .WithMany (p => p.PlanItems)
                    .HasForeignKey (d => d.CreatedBy)
                    .HasConstraintName ("PlanItems_CreatedBy_fkey");

                entity.HasOne (d => d.Plan)
                    .WithMany (p => p.PlanItems)
                    .HasForeignKey (d => d.PlanId)
                    .HasConstraintName ("PlanItems_PlanId_fkey");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.PlanItems)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("PlanItems_StatusTypeId_fkey");
            });

            modelBuilder.Entity<PlanMaster> (entity => {
                entity.ToTable ("PlanMaster", "FoodExSch");

                entity.Property (e => e.PlanMasterId).ValueGeneratedNever ();

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.PlanMaster)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("PlanMaster_StatusTypeId_fkey");
            });

            modelBuilder.Entity<Plans> (entity => {
                entity.HasKey (e => e.PlanId)
                    .HasName ("Plans_pkey");

                entity.ToTable ("Plans", "FoodExSch");

                entity.Property (e => e.PlanId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"Plans_PlanId_seq\"'::regclass)");

                entity.Property (e => e.CreatedDate).HasColumnType ("date");

                entity.Property (e => e.UpdatedDate).HasColumnType ("date");

                entity.HasOne (d => d.CreatedByNavigation)
                    .WithMany (p => p.Plans)
                    .HasForeignKey (d => d.CreatedBy)
                    .HasConstraintName ("Plans_CreatedBy_fkey");

                entity.HasOne (d => d.PlanMaster)
                    .WithMany (p => p.Plans)
                    .HasForeignKey (d => d.PlanMasterId)
                    .HasConstraintName ("Plans_PlanMasterId_fkey");

                entity.HasOne (d => d.Restaurant)
                    .WithMany (p => p.Plans)
                    .HasForeignKey (d => d.RestaurantId)
                    .HasConstraintName ("Plans_RestaurantId_fkey");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.Plans)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("Plans_StatusTypeId_fkey");
            });

            modelBuilder.Entity<ProofTypes> (entity => {
                entity.HasKey (e => e.ProofTypeId)
                    .HasName ("ProofTypes_pkey");

                entity.ToTable ("ProofTypes", "FoodExSch");

                entity.Property (e => e.ProofTypeId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"ProofTypes_ProofTypeId_seq\"'::regclass)");
            });

            modelBuilder.Entity<RestaurantUsers> (entity => {
                entity.HasKey (e => e.RestaurantUserId)
                    .HasName ("RestaurantUsers_pkey");

                entity.ToTable ("RestaurantUsers", "FoodExSch");

                entity.Property (e => e.RestaurantUserId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"RestaurantUsers_RestaurantUserId_seq\"'::regclass)");

                entity.Property (e => e.CreatedDate).HasColumnType ("date");

                entity.Property (e => e.UpdatedDate).HasColumnType ("date");

                entity.HasOne (d => d.CreatedByNavigation)
                    .WithMany (p => p.RestaurantUsersCreatedByNavigation)
                    .HasForeignKey (d => d.CreatedBy)
                    .HasConstraintName ("RestaurantUsers_CreatedBy_fkey");

                entity.HasOne (d => d.Restaurant)
                    .WithMany (p => p.RestaurantUsers)
                    .HasForeignKey (d => d.RestaurantId)
                    .HasConstraintName ("RestaurantUsers_RestaurantId_fkey");

                entity.HasOne (d => d.User)
                    .WithMany (p => p.RestaurantUsersUser)
                    .HasForeignKey (d => d.UserId)
                    .HasConstraintName ("RestaurantUsers_UserId_fkey");
            });

            modelBuilder.Entity<Restaurants> (entity => {
                entity.HasKey (e => e.RestaurantId)
                    .HasName ("Restaurants_pkey");

                entity.ToTable ("Restaurants", "FoodExSch");

                entity.Property (e => e.RestaurantId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"Restaurants_RestaurantId_seq\"'::regclass)");

                entity.Property (e => e.CreatedDate).HasColumnType ("date");

                entity.Property (e => e.UpdatedDate).HasColumnType ("date");

                entity.HasOne (d => d.CreatedByNavigation)
                    .WithMany (p => p.Restaurants)
                    .HasForeignKey (d => d.CreatedBy)
                    .HasConstraintName ("Restaurants_CreatedBy_fkey");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.Restaurants)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("Restaurants_StatusTypeId_fkey");
            });

            modelBuilder.Entity<Roles> (entity => {
                entity.HasKey (e => e.RoleId)
                    .HasName (" Roles_pkey");

                entity.ToTable (" Roles", "FoodExSch");

                entity.Property (e => e.RoleId).HasDefaultValueSql ("nextval('\"FoodExSch\".\" Roles_RoleId_seq\"'::regclass)");
            });

            modelBuilder.Entity<StatusTypes> (entity => {
                entity.HasKey (e => e.StatusTypeId)
                    .HasName ("StatusTypes_pkey");

                entity.ToTable ("StatusTypes", "FoodExSch");

                entity.Property (e => e.StatusTypeId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"StatusTypes_StatusTypeId_seq\"'::regclass)");
            });

            modelBuilder.Entity<SubCategories> (entity => {
                entity.HasKey (e => e.SubCategoryId)
                    .HasName ("SubCategories_pkey");

                entity.ToTable ("SubCategories", "FoodExSch");

                entity.Property (e => e.SubCategoryId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"SubCategories_SubCategoryId_seq\"'::regclass)");

                entity.Property (e => e.CreatedDated).HasColumnType ("date");

                entity.Property (e => e.UpdatedDate).HasColumnType ("date");

                entity.HasOne (d => d.Category)
                    .WithMany (p => p.SubCategories)
                    .HasForeignKey (d => d.CategoryId)
                    .HasConstraintName ("SubCategories_CategoryId_fkey");

                entity.HasOne (d => d.CreatedByNavigation)
                    .WithMany (p => p.SubCategories)
                    .HasForeignKey (d => d.CreatedBy)
                    .HasConstraintName ("SubCategories_CreatedBy_fkey");

                entity.HasOne (d => d.Restaurant)
                    .WithMany (p => p.SubCategories)
                    .HasForeignKey (d => d.RestaurantId)
                    .HasConstraintName ("SubCategories_RestaurantId_fkey");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.SubCategories)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("SubCategories_StatusTypeId_fkey");
            });

            modelBuilder.Entity<SubscriptionTypes> (entity => {
                entity.ToTable ("SubscriptionTypes", "FoodExSch");

                entity.Property (e => e.Id).HasDefaultValueSql ("nextval('\"FoodExSch\".\"SubscriptionTypes_Id_seq\"'::regclass)");
            });

            modelBuilder.Entity<SubscriptionUser> (entity => {
                entity.ToTable ("SubscriptionUser", "FoodExSch");

                entity.Property (e => e.SubscriptionUserId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"SubscriptionUser_SubscriptionUserId_seq\"'::regclass)");

                entity.Property (e => e.EndDate).HasColumnType ("date");

                entity.Property (e => e.StartDate).HasColumnType ("date");

                entity.HasOne (d => d.Plan)
                    .WithMany (p => p.SubscriptionUser)
                    .HasForeignKey (d => d.PlanId)
                    .HasConstraintName ("SubscriptionUser_PlanId_fkey");

                entity.HasOne (d => d.Restaurant)
                    .WithMany (p => p.SubscriptionUser)
                    .HasForeignKey (d => d.RestaurantId)
                    .HasConstraintName ("SubscriptionUser_RestaurantId_fkey");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.SubscriptionUser)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("SubscriptionUser_StatusTypeId_fkey");

                entity.HasOne (d => d.SubcriptionType)
                    .WithMany (p => p.SubscriptionUser)
                    .HasForeignKey (d => d.SubcriptionTypeId)
                    .HasConstraintName ("SubscriptionUser_SubcriptionTypeId_fkey");

                entity.HasOne (d => d.User)
                    .WithMany (p => p.SubscriptionUser)
                    .HasForeignKey (d => d.UserId)
                    .HasConstraintName ("SubscriptionUser_UserId_fkey");
            });

            modelBuilder.Entity<UserCredentials> (entity => {
                entity.ToTable ("UserCredentials", "FoodExSch");

                entity.Property (e => e.Id).HasDefaultValueSql ("nextval('\"FoodExSch\".\"UserCredentials_Id_seq\"'::regclass)");

                entity.HasOne (d => d.IdNavigation)
                    .WithOne (p => p.UserCredentials)
                    .HasForeignKey<UserCredentials> (d => d.Id)
                    .OnDelete (DeleteBehavior.ClientSetNull)
                    .HasConstraintName ("UserCredentials_Id_fkey");
            });

            modelBuilder.Entity<UserLogs> (entity => {
                entity.ToTable ("UserLogs", "FoodExSch");

                entity.Property (e => e.Id).HasDefaultValueSql ("nextval('\"FoodExSch\".\"UserLogs_Id_seq\"'::regclass)");

                entity.Property (e => e.ClientIp).HasColumnName ("ClientIP");

                entity.Property (e => e.LoginTime).HasColumnType ("date");

                entity.Property (e => e.LogoutTime).HasColumnType ("date");

                entity.HasOne (d => d.User)
                    .WithMany (p => p.UserLogs)
                    .HasForeignKey (d => d.UserId)
                    .HasConstraintName ("UserLogs_UserId_fkey");
            });

            modelBuilder.Entity<UserOrders> (entity => {
                entity.HasKey (e => e.UserOrderId)
                    .HasName ("UserOrders_pkey");

                entity.ToTable ("UserOrders", "FoodExSch");

                entity.Property (e => e.UserOrderId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"UserOrders_UserOrderId_seq\"'::regclass)");

                entity.Property (e => e.CreatedDate).HasColumnType ("date");

                entity.Property (e => e.DateOfPlan).HasColumnType ("date");

                entity.Property (e => e.UpdatedDate).HasColumnType ("date");

                entity.HasOne (d => d.CreatedByNavigation)
                    .WithMany (p => p.UserOrdersCreatedByNavigation)
                    .HasForeignKey (d => d.CreatedBy)
                    .HasConstraintName ("UserOrders_CreatedBy_fkey");

                entity.HasOne (d => d.Plan)
                    .WithMany (p => p.UserOrders)
                    .HasForeignKey (d => d.PlanId)
                    .HasConstraintName ("UserOrders_PlanId_fkey");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.UserOrders)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("UserOrders_StatusTypeId_fkey");

                entity.HasOne (d => d.User)
                    .WithMany (p => p.UserOrdersUser)
                    .HasForeignKey (d => d.UserId)
                    .HasConstraintName ("UserOrders_UserId_fkey");
            });

            modelBuilder.Entity<UserProofs> (entity => {
                entity.HasKey (e => e.UserProofId)
                    .HasName ("UserProofs_pkey");

                entity.ToTable ("UserProofs", "FoodExSch");

                entity.Property (e => e.UserProofId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"UserProofs_UserProofId_seq\"'::regclass)");

                entity.HasOne (d => d.ProofType)
                    .WithMany (p => p.UserProofs)
                    .HasForeignKey (d => d.ProofTypeId)
                    .HasConstraintName ("UserProofs_ProofTypeId_fkey");

                entity.HasOne (d => d.User)
                    .WithMany (p => p.UserProofs)
                    .HasForeignKey (d => d.UserId)
                    .HasConstraintName ("UserProofs_UserId_fkey");
            });

            modelBuilder.Entity<Users> (entity => {
                entity.HasKey (e => e.UserId)
                    .HasName ("Users_pkey");

                entity.ToTable ("Users", "FoodExSch");

                entity.Property (e => e.UserId).HasDefaultValueSql ("nextval('\"FoodExSch\".\"Users_UserId_seq\"'::regclass)");

                entity.Property (e => e.CreatedDate).HasColumnType ("date");

                entity.Property (e => e.UpdatedDate).HasColumnType ("date");

                entity.HasOne (d => d.CreatedByNavigation)
                    .WithMany (p => p.InverseCreatedByNavigation)
                    .HasForeignKey (d => d.CreatedBy)
                    .HasConstraintName ("Users_CreatedBy_fkey");

                entity.HasOne (d => d.Role)
                    .WithMany (p => p.Users)
                    .HasForeignKey (d => d.RoleId)
                    .HasConstraintName ("Users_RoleId_fkey");

                entity.HasOne (d => d.StatusType)
                    .WithMany (p => p.Users)
                    .HasForeignKey (d => d.StatusTypeId)
                    .HasConstraintName ("Users_StatusTypeId_fkey");
            });

            modelBuilder.HasSequence<int> (" Roles_RoleId_seq");

            modelBuilder.HasSequence<int> ("AppMainMenus_AppMainMenuId_seq");

            modelBuilder.HasSequence<int> ("AppRoleMenus_AppRoleId_seq");

            modelBuilder.HasSequence<int> ("AppSubMenus_AppsubMenuId _seq");

            modelBuilder.HasSequence<int> ("Categories_CategoryId_seq");

            modelBuilder.HasSequence<int> ("FoodItems_ItemId_seq");

            modelBuilder.HasSequence<int> ("PlanItems_PlanItemId_seq");

            modelBuilder.HasSequence<int> ("Plans_PlanId_seq");

            modelBuilder.HasSequence<int> ("ProofTypes_ProofTypeId_seq");

            modelBuilder.HasSequence<int> ("Restaurants_RestaurantId_seq");

            modelBuilder.HasSequence<int> ("RestaurantUsers_RestaurantUserId_seq");

            modelBuilder.HasSequence<int> ("StatusTypes_StatusTypeId_seq");

            modelBuilder.HasSequence<int> ("SubCategories_SubCategoryId_seq");

            modelBuilder.HasSequence<int> ("SubscriptionTypes_Id_seq");

            modelBuilder.HasSequence<int> ("SubscriptionUser_SubscriptionUserId_seq");

            modelBuilder.HasSequence<int> ("UserCredentials_Id_seq");

            modelBuilder.HasSequence<int> ("UserLogs_Id_seq");

            modelBuilder.HasSequence<int> ("UserOrders_UserOrderId_seq");

            modelBuilder.HasSequence<int> ("UserProofs_UserProofId_seq");

            modelBuilder.HasSequence<int> ("Users_UserId_seq");
        }
    }
}