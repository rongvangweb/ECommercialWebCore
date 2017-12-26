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
    [Table("TB_TranFees")]
    public class TB_TransFee : DomainEntity<int>, ISwitchable
    {
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
        public int? DayNum { get; set; }
        public int? KgsNum { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? Price { get; set; }
        public int? KgsIncrease { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? PriceIncrease { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
