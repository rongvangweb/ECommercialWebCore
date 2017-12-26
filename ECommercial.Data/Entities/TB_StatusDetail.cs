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
    [Table("TB_StatusDetails")]
    public class TB_StatusDetail : DomainEntity<int>, ISwitchable
    {
        public int? TypeId { get; set; }
        public int? NumValue { get; set; }
        [StringLength(50)]
        public string TextValue { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public Status Status { get; set; }
        [ForeignKey("TypeId")]
        public virtual TB_StatusType StatusTypes { set; get; }
    }
}
