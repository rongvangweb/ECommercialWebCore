using ECommercial.Infrastructure.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_Tags")]
    public class TB_Tag : DomainEntity<string>
    {
        public TB_Tag()
        {
            Products = new List<TB_Product>();
        }
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        public virtual ICollection<TB_Product> Products { get; set; }
    }
}