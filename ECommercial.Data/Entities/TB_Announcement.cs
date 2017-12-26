using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using ECommercial.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("TB_Announcements")]
    public class TB_Announcement : DomainEntity<long>, ISwitchable, IDateTracking
    {
        public TB_Announcement()
        {
            AnnouncementUsers = new List<TB_AnnouncementUser>();
        }

        [Required]
        [StringLength(250)]
        public string Title { set; get; }

        [StringLength(250)]
        public string Message { set; get; }

        public Guid UserId { set; get; }

        public virtual ICollection<TB_AnnouncementUser> AnnouncementUsers { get; set; }
        public DateTime? DateCreated { set; get; }
        public DateTime? DateModified { set; get; }
        public Status Status { set; get; }
    }
}