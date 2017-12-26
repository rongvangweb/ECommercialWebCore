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
    [Table("TB_StatusTypes")]
    public class TB_StatusType : DomainEntity<int>, ISwitchable, ISortable
    {
        public TB_StatusType()
        {
            StatusDetails = new List<TB_StatusDetail>();
        }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public Status Status { get; set; }
        public int? SortOrder { get; set; }
        public virtual ICollection<TB_StatusDetail> StatusDetails { set; get; }
    }
}
