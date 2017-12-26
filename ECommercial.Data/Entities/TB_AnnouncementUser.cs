using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_AnnouncementUsers")]
    public class TB_AnnouncementUser : DomainEntity<long>
    {

        public long? AnnouncementId { get; set; }

        public Guid UserId { get; set; }

        public bool HasRead { get; set; }

        [ForeignKey("AnnouncementId")]
        public virtual TB_Announcement Announcements { get; set; }
    }

}
