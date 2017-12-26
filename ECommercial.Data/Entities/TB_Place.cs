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
    [Table("TB_Places")]
    public class TB_Place : DomainEntity<int>, ISwitchable
    {
        public TB_Place()
        {
            //ShippingBills = new List<TB_ShippingBill>();
            Orders = new List<TB_Order>();
            Members = new List<TB_Member>();
            //StorePlace = new List<TB_StorePlace>();
        }
        public int? ParentId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? PlaceLevel { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public int? CityLevel { get; set; }
        public int? AreaLevel { get; set; }
        public int? CitySpecial { get; set; }
        public bool TransSupport { get; set; }
        public decimal? TranFee { get; set; }
        public Status Status { get; set; }
        //public virtual ICollection<TB_ShippingBill> ShippingBills { set; get; }
        public virtual ICollection<TB_Order> Orders { set; get; }
        public virtual ICollection<TB_Member> Members { set; get; }
        //public virtual ICollection<TB_StorePlace> StorePlace { set; get; }
    }
}
