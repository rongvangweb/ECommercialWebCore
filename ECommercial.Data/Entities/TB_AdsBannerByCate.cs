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
    [Table("TB_AdsBannerByCates")]
    public class TB_AdsBannerByCate : DomainEntity<int>, ISwitchable
    {

        public int? CategoryId { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(255)]
        public string Picture1 { get; set; }
        [StringLength(255)]
        public string Link1 { get; set; }
        [StringLength(255)]
        public string Picture2 { get; set; }
        [StringLength(255)]
        public string Link2 { get; set; }
        [StringLength(255)]
        public string Picure3 { get; set; }
        [StringLength(255)]
        public string Link3 { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Status Status { get; set; }
        [ForeignKey("CategoryId")]
        public virtual TB_ProductCategory Categories { get; set; }
    }
}

