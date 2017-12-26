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
    [Table("TB_Menus")]
    public class TB_Menu : DomainEntity<int>, IHasSeoMetaData, ISwitchable
    {

        public int? GroupId { get; set; }
        [StringLength(125)]
        public string Name { get; set; }
        [StringLength(50)]
        public string StyleClass { get; set; }
        [StringLength(50)]
        public string FontAwesome { get; set; }
        [StringLength(255)]
        public string Icon { get; set; }
        [StringLength(255)]
        public string Picture { get; set; }
        public Status Status { get; set; }
        [StringLength(300)]
        public string SeoPageTitle { get; set; }
        [StringLength(300)]
        public string SeoAlias { get; set; }
        [StringLength(300)]
        public string SeoKeywords { get; set; }
        [StringLength(500)]
        public string SeoDescription { get; set; }

        [ForeignKey("GroupId")]
        public virtual TB_MenuGroup MenuGroups { set; get; }
    }
}
