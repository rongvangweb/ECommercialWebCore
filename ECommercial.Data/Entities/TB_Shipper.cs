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
    public class TB_Shipper : DomainEntity<long>, ISwitchable, IDateTracking, IHasSoftDelete
    {
        public TB_Shipper()
        {
            ShippingBills = new List<TB_ShippingBill>();

        }
        [Required]
        public long? MemberId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        [StringLength(50)]
        public string PinCode { get; set; }
        public bool Gender { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
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
        public Status Status { get; set; }
        [Column(TypeName = "numeric")]
        public decimal AccountBalance { get; set; }
        [Column(TypeName = "numeric")]
        public decimal MoneyHolding { get; set; }
        [Column(TypeName = "numeric")]
        public decimal MoneyTranfering { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("MemberId")]
        public virtual TB_Member Member { set; get; }
        public virtual ICollection<TB_ShippingBill> ShippingBills { set; get; }
        
    }
}