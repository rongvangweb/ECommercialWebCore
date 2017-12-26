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
    [Table("TB_Orders")]
    public class TB_Order : DomainEntity<long>, ISwitchable, IDateTracking
    {
        public TB_Order()
        {
            OrderDetails = new List<TB_OrderDetail>();
            
        }

        public long? MemberId { get; set; }
        [Required]
        public int? PlaceId { get; set; }
        public int? ApprovalId { get; set; }
        [StringLength(50)]
        public string OrderNo { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        public bool? Gender { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Approvaler { get; set; }
        [StringLength(50)]
        public string ProcessingStatus { get; set; }
        public bool? Sent { get; set; }
        public decimal? Summary { get; set; }
        public decimal? Prepaid { get; set; }
        public decimal? Discount { get; set; }
        public decimal? TransFee { get; set; }
        public decimal? OtherFee { get; set; }
        public decimal? Total { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public decimal GrandTotal { get; set; }
        [StringLength(50)]
        public string VoucherCode { get; set; }
        [Required]
        public Status Status { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? PaymentMethods { get; set; } //Phương thức thanh toán, thiết lập ở TB_StatusType và TB_StatusDetail
        [ForeignKey("PlaceId")]
        public virtual TB_Place Places { set; get; }
        
        [ForeignKey("MemberId")]
        public virtual TB_Member Members { set; get; }
        public virtual ICollection<TB_OrderDetail> OrderDetails { set; get; }
    }
}