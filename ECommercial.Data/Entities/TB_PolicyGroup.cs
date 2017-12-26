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
    [Table("TB_PolicyGroups")]
    public class TB_PolicyGroup : DomainEntity<int>, ISwitchable
    {
        public TB_PolicyGroup()
        {
            PolicyDetails = new List<TB_PolicyDetail>();
        }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<TB_PolicyDetail> PolicyDetails { set; get; }
    }
}
