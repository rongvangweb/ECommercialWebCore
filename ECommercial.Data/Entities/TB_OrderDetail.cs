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
    public class TB_OrderDetail : DomainEntity<long>, ISwitchable
    {
        public TB_OrderDetail()
        {
           ShippingBills = new List<TB_ShippingBill>();
            
        }
        public long? OrderId { get; set; }

        public long? ProductId { get; set; }
        public long? StoreId { get; set; }
        public string SubCode { get; set; }
        [StringLength(250)]
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? SubTotal { get; set; }
        [StringLength(250)]
        public string Note { get; set; }
        [StringLength(50)]
        public string TransFeeCode { get; set; }
        public int? DayShipping { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Length { get; set; }
        public decimal? Weight { get; set; }
        public decimal? SponseShip { get; set; }
        public decimal? TransFee { get; set; }
        public decimal? ShipperFee { get; set; }
        public decimal? BackStoreFee { get; set; }
        public decimal? Disccount { get; set; }
        public decimal? Prepaid { get; set; }
        public string Processing { get; set; }
        public int? SupplierConfirm { get; set; }
        public decimal? InsureFee { get; set; }
        public decimal? MarketingValue { get; set; }
        public decimal? CommisionValue { get; set; }
        public decimal? Total { get; set; }
        public decimal? RealTotal { get; set; }
        public string Brief { get; set; }
        public string Detail { get; set; }
        [StringLength(250)]
        public string Picture { get; set; }

        [Required]
        public Status Status { get; set; }

        [ForeignKey("OrderId")]
        public virtual TB_Order Order { get; set; }
        [ForeignKey("ProductId")]
        public virtual TB_Product Product { get; set; }
        [ForeignKey("StoreId")]
        public virtual TB_StorePlace StorePlaces { get; set; }
        public virtual ICollection<TB_ShippingBill> ShippingBills { set; get; }
    }
}