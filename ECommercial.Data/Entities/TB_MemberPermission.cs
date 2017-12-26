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
    public class TB_MemberPermission : DomainEntity<int>
    {

        public int? TypeId { get; set; }

        [StringLength(500)]
        public string ListMenuId { get; set; }

        public bool CanRead { get; set; }
        public bool CanCreate { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }

        [ForeignKey("TypeId")]
        public virtual TB_MemberType MemberTypes { get; set; }
    }
}