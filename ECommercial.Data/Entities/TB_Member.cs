using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_Members")]
    public class TB_Member : DomainEntity<long>, ISwitchable, IDateTracking,IHasSoftDelete
    {
        public TB_Member()
        {
            Orders = new List<TB_Order>();
        }

        [Required]
        public int? TypeId { get; set; }
        public int? PlaceId { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string PinCode { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public bool Gender { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(50)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string OldPassword { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Picture { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        [StringLength(50)]
        public string BankCode { get; set; }

        [StringLength(250)]
        public string BankName { get; set; }

        [StringLength(50)]
        public string BankUser { get; set; }

        [StringLength(50)]
        public string Voucher { get; set; }

        public Status Status { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("PlaceId")]
        public virtual TB_Place Places { get; set; }
        [ForeignKey("TypeId")]
        public virtual TB_MemberType MemberTypes { set; get; }

        public virtual ICollection<TB_Order> Orders { get; set; }
        
    }
}