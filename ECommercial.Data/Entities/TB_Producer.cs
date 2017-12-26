using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using ECommercial.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ECommercial.Data.Entities
{
    [Table("TB_Producers")]
    public class TB_Producer : DomainEntity<long>, ISwitchable, IHasSeoMetaData
    {
        public TB_Producer()
        {
            Products = new List<TB_Product>();
        }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Logo { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public Status Status { get; set; }
        [StringLength(300)]
        public string SeoPageTitle { get; set; }
        [StringLength(300)]
        public string SeoAlias { get; set; }
        [StringLength(300)]
        public string SeoKeywords { get; set; }
        [StringLength(500)]
        public string SeoDescription { get; set; }
        public virtual ICollection<TB_Product> Products { set; get; }
    }
}
