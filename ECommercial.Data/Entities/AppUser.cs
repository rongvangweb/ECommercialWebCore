using ECommercial.Data.Enums;
using ECommercial.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommercial.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        [StringLength(50)]
        public string FullName { get; set; }

        public DateTime? Birthday { get; set; }
        public decimal? Balance { get; set; }
        public string Avatar { get; set; }

        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public Status Status { get; set; }
    }
}