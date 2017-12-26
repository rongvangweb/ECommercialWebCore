using ECommercial.Data.EF.Extenssions;
using ECommercial.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommercial.Data.EF.Configurations
{
    public class TagConfiguration: DbEntityConfiguration<TB_Tag>
    {
        public override void Configure(EntityTypeBuilder<TB_Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(100)
                .IsRequired().HasColumnType("varchar(100)");
        }
    }
}
