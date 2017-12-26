using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_MenuAdmins")]
    public class TB_MenuAdmin : DomainEntity<int>, ISwitchable, ISortable
    {
        public int? ParentId { get; set; }
        public int? Level { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Controller { get; set; }

        [StringLength(50)]
        public string Action { get; set; }

        [StringLength(50)]
        public string Awesome { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public Status Status { get; set; }
        public int? SortOrder { get; set; }
    }
}