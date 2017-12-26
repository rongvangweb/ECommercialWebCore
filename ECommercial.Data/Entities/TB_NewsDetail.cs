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
    [Table("NewsDetails")]
    public class TB_NewsDetail : DomainEntity<long>, ISwitchable, IHasSeoMetaData, IDateTracking
    {
        [Required]
        public int GroupId { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Detail { get; set; }
        [StringLength(255)]
        public string Picture { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? HotFlag { get; set; }
        [StringLength(300)]
        public string SeoPageTitle { get; set; }
        [StringLength(300)]
        public string SeoAlias { get; set; }
        [StringLength(300)]
        public string SeoKeywords { get; set; }
        [StringLength(500)]
        public string SeoDescription { get; set; }
        public Status Status { get; set; }

        [ForeignKey("GroupId")]
        public virtual TB_NewsGroup NewsGroups { set; get; }
    }
}
