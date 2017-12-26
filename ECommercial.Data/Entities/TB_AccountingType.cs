using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_AccountingTypes")]
    public class TB_AccountingType : DomainEntity<int>, ISortable, ISwitchable
    {
        public TB_AccountingType()
        {
            AccountingCodes = new List<TB_AccountingCode>();
        }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public int? SortOrder { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<TB_AccountingCode> AccountingCodes { set; get; }
    }
}