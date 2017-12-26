using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_InvoiceCources")]
    public class TB_InvoiceCourse : DomainEntity<int>, ISwitchable
    {
        public TB_InvoiceCourse()
        {
            Invoices = new List<TB_Invoice>();
        }

        [StringLength(300)]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<TB_Invoice> Invoices { set; get; }
    }
}
