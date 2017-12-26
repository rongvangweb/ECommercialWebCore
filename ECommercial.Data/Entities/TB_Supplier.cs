using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_Suppliers")]
    public class TB_Supplier : DomainEntity<long>, ISwitchable, IHasSoftDelete, IHasSeoMetaData, IDateTracking
    {
        public TB_Supplier()
        {
            ConsultNews = new List<TB_ConsultNews>();
            Products = new List<TB_Product>();
            StorePlaces = new List<TB_StorePlace>();
        }
        public long? MemberId { get; set; }
        public int? PlaceId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(250)]
        public string ShopName { get; set; }
        [StringLength(250)]
        public string ShopSlug { get; set; }
        [StringLength(50)]
        public string ShortName { get; set; }
        [StringLength(250)]
        public string FullName { get; set; }
        [StringLength(500)]
        public string BusinessField { get; set; } //ngành nghề kinh doanh
        public string Brief { get; set; }
        public string Detail { get; set; }
        [StringLength(50)]
        public string ManagerName { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string TaxCode { get; set; }
        [StringLength(250)]
        public string Logo { get; set; }
        [StringLength(250)]
        public string Picture { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
        [StringLength(50)]
        public string LoginName { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        [StringLength(50)]
        public string OldPassword { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(50)]
        public string BankCode { get; set; }
        [StringLength(250)]
        public string BankName { get; set; }
        [StringLength(50)]
        public string BankUser { get; set; }
        public int? ApproveStatus { get; set; }
        public string SeoPageTitle { get; set; }
        public string SeoAlias { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public bool IsDeleted { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? CreateBy { get; set; }
        public int? ModifyBy { get; set; }
        public bool Locked { get; set; }
        public bool IDeleted { get; set; }

        [ForeignKey("MemberId")]
        public virtual TB_Member Member { set; get; }
        public virtual ICollection<TB_Product> Products { set; get; }
        public virtual ICollection<TB_ConsultNews> ConsultNews { set; get; }
        public virtual ICollection<TB_StorePlace> StorePlaces { set; get; }
        
    }
}