using Market.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence.Configurations
{
    class ZonesConfiguration : IEntityTypeConfiguration<Zones>
    {
        public void Configure(EntityTypeBuilder<Zones> builder)
        {
            builder.HasKey(e => e.ZoneId)
                     .HasName("zones_pkey");

            builder.ToTable("zones");

            builder.Property(e => e.ZoneId)
                .HasColumnName("zone_id")
                .ValueGeneratedNever();

            builder.Property(e => e.ZoneName).HasColumnName("zone_name");
        }
    }
}
