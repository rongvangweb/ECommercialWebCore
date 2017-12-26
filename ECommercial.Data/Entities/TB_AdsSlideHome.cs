using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_AdsSlideByHomes")]
    public class TB_AdsSlideHome : DomainEntity<int>, ISwitchable, ISortable
    {

        [Required]
        public int CategoryId { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Background { get; set; }
        [StringLength(255)]
        public string PicSlide { get; set; }
        [StringLength(255)]
        public string LinkSlide { get; set; }
        [StringLength(255)]
        public string PicProduct1 { get; set; }
        [StringLength(255)]
        public string LinkProduct1 { get; set; }
        [StringLength(255)]
        public string PicProduct2 { get; set; }
        [StringLength(255)]
        public string LinkProduct2 { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Status Status { get; set; }
        public int? SortOrder { get; set; }
        [ForeignKey("CategoryId")]
        public virtual TB_ProductCategory Categories { get; set; }
    }
}