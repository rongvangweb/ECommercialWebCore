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
    [Table("TB_HelpDetails")]
    public class TB_HelpDetail : DomainEntity<int>, ISwitchable, ISortable, IDateTracking
    {
        [Required]
        public int GroupId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Picture { get; set; }
        public string Brief { get; set; }
        public string Detail { get; set; }
        public int? SortOrder { get; set; }
        public Status Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? CreateBy { get; set; }
        public int? ModifyBy { get; set; }
        public DateTime? DateModified { get; set; }
        [ForeignKey("GroupId")]
        public virtual TB_HelpGroup HelpGroups { set; get; }
    }
}
