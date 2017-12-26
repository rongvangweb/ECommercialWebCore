using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_AdsProductByCates")]
    public class TB_AdsProductByCate : DomainEntity<int>, ISwitchable, ISortable
    {
        
        public int? CategoryId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Picture { get; set; }
        public decimal? Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        [StringLength(255)]
        public string Link { get; set; }
        public Status Status { get; set; }
        public int? SortOrder { get; set; }
        [ForeignKey("CategoryId")]
        public virtual TB_ProductCategory Categories { get; set; }
    }
}
