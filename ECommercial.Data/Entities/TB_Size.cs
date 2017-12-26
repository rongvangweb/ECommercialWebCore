using System;
using ECommercial.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_Sizes")]
    public class TB_Size : DomainEntity<int>
    {
        [StringLength(250)]
        public string Name { get; set; }
    }
}