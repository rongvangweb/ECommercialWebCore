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
    [Table("TB_Settings")]
    public class TB_Setting : DomainEntity<int>, ISwitchable
    {
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public string Value { get; set; }
        public Status Status { get; set; }
    }
}
