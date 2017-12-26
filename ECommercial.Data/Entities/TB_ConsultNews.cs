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
    [Table("TB_ConsultNews")]
    public class TB_ConsultNews : DomainEntity<long>, ISwitchable, IHasSeoMetaData, IDateTracking
    {
        [Required]
        public long? SupplierId { get; set; }
        [StringLength(300)]
        public string Title { get; set; }
        public string Brief { get; set; }
        public string Detail { get; set; }
        [StringLength(300)]
        public string Picture { get; set; }
        public int? ApprovalStatus { get; set; }
        [StringLength(100)]
        public string ApprovalProcessing { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        [StringLength(300)]
        public string SeoPageTitle { get; set; }
        [StringLength(300)]
        public string SeoAlias { get; set; }
        [StringLength(300)]
        public string SeoKeywords { get; set; }
        [StringLength(500)]
        public string SeoDescription { get; set; }
        public Status Status { get; set; }

        [ForeignKey("SupplierId")]
        public virtual TB_Supplier Suppliers { get; set; }
        
    }
}
