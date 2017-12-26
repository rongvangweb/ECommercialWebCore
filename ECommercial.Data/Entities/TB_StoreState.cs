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
    [Table("TB_StoreStates")]
    public class TB_StoreState : DomainEntity<long>
    {

        public long? StoreId { get; set; }
        public long? ProductId { get; set; }
        public int? TotalQuantity { get; set; }
        public int? SolQuantity { get; set; }
        public decimal? Price { get; set; }
        public DateTime? LastUpdate { get; set; }
        [ForeignKey("StoreId")]
        public virtual TB_StorePlace StorePlace { set; get; }
        [ForeignKey("ProductId")]
        public virtual TB_Product Products { set; get; }
    }
}
