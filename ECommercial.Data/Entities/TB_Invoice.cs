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
    [Table("TB_Invoices")]
    public class TB_Invoice : DomainEntity<long>, ISwitchable, IDateTracking
    {
        public int? ObjectId { get; set; }
        public int? TypeId { get; set; }
        public int? AccountingCodeId { get; set; }
        public int? CourseId { get; set; }
        
        public int? ReceiveId { get; set; }
        [StringLength(50)]
        public string CouseName { get; set; }
        public string ApprovalName { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int? ProcessStatus { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string ReferenceCode { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateCompleted { get; set; }
        public Status Status { get; set; }

        [ForeignKey("AccountingCodeId")]
        public virtual TB_AccountingCode AccountingCodes { get; set; }
        [ForeignKey("TypeId")]
        public virtual TB_AccountingType AccountingTypes { get; set; }
        [ForeignKey("CourseId")]
        public virtual TB_InvoiceCourse InvoiceCourse { get; set; }
        
    }
}