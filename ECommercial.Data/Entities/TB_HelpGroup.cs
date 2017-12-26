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
    public class TB_HelpGroup : DomainEntity<int>, ISwitchable
    {
        public TB_HelpGroup()
        {
            HelpDetails = new List<TB_HelpDetail>();
        }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<TB_HelpDetail> HelpDetails { set; get; }
    }
}
