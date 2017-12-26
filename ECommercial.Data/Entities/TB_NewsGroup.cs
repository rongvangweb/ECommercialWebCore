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
    [Table("NewsGroups")]
    public class TB_NewsGroup : DomainEntity<int>, ISwitchable, IHasSeoMetaData, ISortable
    {
        public TB_NewsGroup()
        {
            NewsDetails = new List<TB_NewsDetail>();
        }
        [StringLength(50)]
        public string Name { get; set; }
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
        public int? SortOrder { get; set; }

        public virtual ICollection<TB_NewsDetail> NewsDetails { set; get; }
    }
}
