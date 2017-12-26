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
    [Table("TB_PageInfos")]
    public class TB_PageInfo : DomainEntity<int>, ISwitchable, IHasSeoMetaData, ISortable
    {
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public string Value { get; set; }
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
    }
}
