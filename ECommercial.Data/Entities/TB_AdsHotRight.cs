using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_AdsHotRights")]
    public class TB_AdsHotRight : DomainEntity<int>, ISwitchable
    {
        public int? CategoryId { get; set; }

        [StringLength(255)]
        public string Picture { get; set; }

        [StringLength(255)]
        public string Link { get; set; }

        public Status Status { get; set; }

        [ForeignKey("CategoryId")]
        public virtual TB_ProductCategory Categories { get; set; }
    }
}