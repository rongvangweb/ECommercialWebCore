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
    [Table("TB_PolicyDetails")]
    public class TB_PolicyDetail : DomainEntity<int>, ISwitchable, IHasSeoMetaData, ISortable
    {
        public int? GroupId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        public string Brief { get; set; }
        public string Detail { get; set; }
        [StringLength(300)]
        public string Picture { get; set; }
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

        [ForeignKey("GroupId")]
        public virtual TB_PolicyGroup PolicyGroups { set; get; }
    }
}
