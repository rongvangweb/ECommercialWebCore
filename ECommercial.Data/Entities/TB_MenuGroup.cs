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
    [Table("TB_MenuGroups")]
    public class TB_MenuGroup : DomainEntity<int>, ISwitchable
    {
        public TB_MenuGroup()
        {
            Menus = new List<TB_Menu>();
        }
        [StringLength(125)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<TB_Menu> Menus { set; get; }

    }
}
