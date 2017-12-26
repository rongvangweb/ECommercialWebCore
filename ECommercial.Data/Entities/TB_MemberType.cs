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
    [Table("TB_MemberTypes")]
    public class TB_MemberType : DomainEntity<int>, ISortable
    {
        public TB_MemberType()
        {
            Members = new List<TB_Member>();
            MemberPermissions = new List<TB_MemberPermission>();
        }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Status Status { get; set; }
        public int? SortOrder { get; set; }
        public virtual ICollection<TB_Member> Members { set; get; }
        public virtual ICollection<TB_MemberPermission> MemberPermissions { set; get; }
    }
}
