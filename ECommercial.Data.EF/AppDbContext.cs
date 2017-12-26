using ECommercial.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ECommercial.Data.EF.Configurations;
using ECommercial.Data.EF.Extenssions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using ECommercial.Data.Interfaces;

namespace ECommercial.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppRole> AppRoles { set; get; }
        public DbSet<AppUser> AppUsers { set; get; }
        public DbSet<TB_AccountingCode> TB_AccountingCodes { set; get; }
        public DbSet<TB_AccountingType> TB_AccountingTypes { set; get; }
        public DbSet<TB_AdsBannerByCate> TB_AdsBannerByCates { set; get; }
        public DbSet<TB_AdsBannerByList> TB_AdsBannerByLists { set; get; }
        public DbSet<TB_AdsHotRight> TB_AdsHotRights { set; get; }
        public DbSet<TB_AdsLogoByCate> TB_AdsLogoByCates { set; get; }
        public DbSet<TB_AdsProductByCate> TB_AdsProductByCates { set; get; }
        public DbSet<TB_AdsSlideByCate> TB_AdsSlideByCates { set; get; }
        public DbSet<TB_AdsSlideHome> TB_AdsSlideHomes { set; get; }
        public DbSet<TB_Announcement> TB_Announcements { set; get; }
        public DbSet<TB_AnnouncementUser> TB_AnnouncementUsers { set; get; }
        public DbSet<TB_Color> TB_Colors { set; get; }
        public DbSet<TB_ConsultNews> TB_ConsultNews { set; get; }
        public DbSet<TB_HelpDetail> TB_HelpDetails { set; get; }
        public DbSet<TB_HelpGroup> TB_HelpGroups { set; get; }
        public DbSet<TB_Invoice> TB_Invoices { set; get; }
        public DbSet<TB_InvoiceCourse> TB_InvoiceCourses { set; get; }
        public DbSet<TB_InvoiceType> TB_InvoiceTypes { set; get; }
        public DbSet<TB_Language> TB_Languages { set; get; }
        public DbSet<TB_Member> TB_Members { set; get; }
        public DbSet<TB_MemberPermission> TB_MemberPermissions { set; get; }
        public DbSet<TB_MemberType> TB_MemberTypes { set; get; }
        public DbSet<TB_Menu> TB_Menus { set; get; }
        public DbSet<TB_MenuAdmin> TB_MenuAdmins { set; get; }
        public DbSet<TB_MenuGroup> TB_MenuGroups { set; get; }
        public DbSet<TB_MenuMember> TB_MenuMembers { set; get; }
        public DbSet<TB_NewsDetail> TB_NewsDetails { set; get; }
        public DbSet<TB_NewsGroup> TB_NewsGroups { set; get; }
        public DbSet<TB_Option> TB_Options { set; get; }
        public DbSet<TB_Order> TB_Orders { set; get; }
        public DbSet<TB_OrderDetail> TB_OrderDetails { set; get; }
        public DbSet<TB_PageInfo> TB_PageInfos { set; get; }
        public DbSet<TB_Place> TB_Places { set; get; }
        public DbSet<TB_PolicyDetail> TB_PolicyDetails { set; get; }
        public DbSet<TB_PolicyGroup> TB_PolicyGroups { set; get; }
        public DbSet<TB_Producer> TB_Producers { set; get; }
        public DbSet<TB_Product> TB_Products { set; get; }
        public DbSet<TB_ProductCategory> TB_ProductCategories { set; get; }
        public DbSet<TB_ProductTag> TB_ProductTag { set; get; }
        public DbSet<TB_SearchKey> TB_SearchKies { set; get; }
        public DbSet<TB_Setting> TB_Settings { set; get; }
        public DbSet<TB_Shipper> TB_Shippers { set; get; }
        public DbSet<TB_ShippingBill> TB_ShippingBills { set; get; }
        public DbSet<TB_Size> TB_Sizes { set; get; }
        public DbSet<TB_StatusDetail> TB_StatusDetails { set; get; }
        public DbSet<TB_StatusType> TB_StatusTypes { set; get; }
        public DbSet<TB_StorePlace> TB_StorePlaces { set; get; }
        public DbSet<TB_StoreState> TB_StoreStates { set; get; }
        public DbSet<TB_Supplier> TB_Suppliers { set; get; }
        public DbSet<TB_Tag> TB_Tags { set; get; }
        public DbSet<TB_TransFee> TB_TransFees { set; get; }
        public DbSet<TB_UserPermission> TB_UserPermissions { set; get; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims").HasKey(x => x.Id);
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.RoleId, x.UserId });
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => new { x.UserId });


            builder.AddConfiguration(new TagConfiguration());
        }
        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changedOrAddedItem.DateCreated = DateTime.Now;
                    }
                    changedOrAddedItem.DateModified = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }


    }
}
