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
    [Table("TB_ShippingBills")]
    public class TB_ShippingBill : DomainEntity<long>, IDateTracking
    {
        public int? PlaceId { get; set; }
        public long? ShipperId { get; set; }
        public long? OrderDetailId { get; set; }
        public long? StorePlaceId { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string CodeFromShipper { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(250)]
        public string CustomerAddress { get; set; }
        [StringLength(50)]
        public string CustomerPhone { get; set; }
        public decimal? Cash { get; set; }
        public decimal ShipFee { get; set; }
        public decimal? OtherFee { get; set; }
        public decimal? Total { get; set; }
        public DateTime? StartDate { get; set; }
        public int? DayOnShip { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public int? ProcessStatus { get; set; }
        [StringLength(50)]
        public string Processing { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(50)]
        public string StaffCode { get; set; }
        [StringLength(50)]
        public string StaffName { get; set; }
        public bool Closed { get; set; }
        public decimal? InsureFee { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        [ForeignKey("PlaceId")]
        public virtual TB_Place Places { set; get; }
        [ForeignKey("ShipperId")]
        public virtual TB_Shipper Shippers { set; get; }
        [ForeignKey("OrderDetailId")]
        public virtual TB_OrderDetail OrderDetails { set; get; }
        [ForeignKey("StorePlaceId")]
        public virtual TB_StorePlace StorePlaces { set; get; }
    }
}