using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_ProductCategories")]
    public class TB_ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public TB_ProductCategory()
        {
            Products = new List<TB_Product>();
            AdsBannerByCates = new List<TB_AdsBannerByCate>();
            AdsBannerByLists = new List<TB_AdsBannerByList>();
            AdsHotRights = new List<TB_AdsHotRight>();
            AdsLogoByCates = new List<TB_AdsLogoByCate>();
            AdsProductByCates = new List<TB_AdsProductByCate>();
            AdsSlideByCates = new List<TB_AdsSlideByCate>();
            AdsSlideByHomes = new List<TB_AdsSlideHome>();
        }
        [StringLength(50)]
        public string Code { get; set; }

        public int? CateLevel { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public int? ParentId { get; set; }
        public bool HomeFlag { get; set; }
        public int? HomeOrder { get; set; }

        [StringLength(300)]
        public string Picture { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MarketingRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VoucherRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CommissionRate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DiscountRate { get; set; }

        [StringLength(300)]
        public string SeoPageTitle { get; set; }

        [StringLength(300)]
        public string SeoAlias { get; set; }

        [StringLength(300)]
        public string SeoKeywords { get; set; }

        [StringLength(500)]
        public string SeoDescription { get; set; }

        public Status Status { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        //Các liên kết ràng buộc dữ liệu
        public virtual ICollection<TB_Product> Products { set; get; }
        public virtual ICollection<TB_AdsBannerByCate> AdsBannerByCates { get; set; }
        public virtual ICollection<TB_AdsBannerByList> AdsBannerByLists { get; set; }
        public virtual ICollection<TB_AdsHotRight> AdsHotRights { get; set; }
        public virtual ICollection<TB_AdsLogoByCate> AdsLogoByCates { get; set; }
        public virtual ICollection<TB_AdsProductByCate> AdsProductByCates { get; set; }
        public virtual ICollection<TB_AdsSlideByCate> AdsSlideByCates { get; set; }
        public virtual ICollection<TB_AdsSlideHome> AdsSlideByHomes { get; set; }
    }
}