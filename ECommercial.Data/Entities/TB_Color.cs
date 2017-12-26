using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ECommercial.Data.Entities
{
    [Table("TB_Colors")]
    public class TB_Color : DomainEntity<int>
    {
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Code { get; set; }
    }
}