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
    [Table("TB_AccountingCodes")]
    public class TB_AccountingCode : DomainEntity<int>, ISwitchable, ISortable
    {
        public TB_AccountingCode()
        {
            Invoices = new List<TB_Invoice>();
        }
        public int? ParentId { get; set; }
        [Required]
        public int? TypeId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        public int? CodeLevel { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? Value { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public Status Status { get; set; }

        [ForeignKey("TypeId")]
        public virtual TB_AccountingType AccountingTypes { get; set; }

        public virtual ICollection<TB_Invoice> Invoices { get; set; }
    }
}
