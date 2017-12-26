using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_AddBannerByLists")]
    public class TB_AdsBannerByList : DomainEntity<int>, ISwitchable
    {

        
        public int? CategoryId { get; set; }
        [StringLength(255)]
        public string Picture { get; set; }
        [StringLength(255)]
        public string Link { get; set; }
        public Status Status { get; set; }
        [ForeignKey("CategoryId")]
        public virtual TB_ProductCategory Categories { get; set; }
    }
}
