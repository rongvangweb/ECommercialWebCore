using ECommercial.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_SearchKeys")]
    public class TB_SearchKey : DomainEntity<long>
    {
        [StringLength(100)]
        public string Keyword { get; set; }

        public long? ComputerCount { get; set; }
        public long? MobileCount { get; set; }
    }
}