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
    [Table("TB_StorePlaces")]
    public class TB_StorePlace : DomainEntity<long>, ISwitchable
    {
        public TB_StorePlace()
        {
            OrderDetails = new List<TB_OrderDetail>();
            ShippingBills = new List<TB_ShippingBill>();
            StoreStates = new List<TB_StoreState>();
        }
        public long? SupplierId { get; set; }
        public int? PlaceId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(250)]
        public string Picture { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public Status Status { get; set; }
        [ForeignKey("PlaceId")]
        public virtual TB_Place Places { set; get; }
        [ForeignKey("SupplierId")]
        public virtual TB_Supplier Suppliers { set; get; }
        public virtual ICollection<TB_OrderDetail> OrderDetails { set; get; }
        public virtual ICollection<TB_ShippingBill> ShippingBills { set; get; }
        public virtual ICollection<TB_StoreState> StoreStates { set; get; }
    }
}
