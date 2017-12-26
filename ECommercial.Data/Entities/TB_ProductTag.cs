using ECommercial.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ECommercial.Data.Entities
{
    [Table("TB_ProductTags")]
    public class TB_ProductTag: DomainEntity<long>
    {
        public long? ProductId { get; set; }
        [StringLength(100)]
        public string TagId { get; set; }
        [ForeignKey("ProductId")]
        public virtual TB_Product Products { get; set; }
        [ForeignKey("TagId")]
        public virtual TB_Tag Tags { get; set; }
    }
}
