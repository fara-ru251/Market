using Market.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence.Configurations
{
    public class CamerasZonesConfiguration : IEntityTypeConfiguration<CameraZones>
    {
        public void Configure(EntityTypeBuilder<CameraZones> builder)
        {
            builder.HasKey(e => new { e.ZoneId, e.CameraId })
                    .HasName("camera_zones_pkey");

            builder.ToTable("camera_zones");

            builder.Property(e => e.ZoneId).HasColumnName("zone_id");

            builder.Property(e => e.CameraId).HasColumnName("camera_id");

            builder.Property(e => e.Coordinates).HasColumnName("coordinates");

            builder.HasOne(d => d.Camera)
                .WithMany(p => p.CameraZones)
                .HasForeignKey(d => d.CameraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cm_cm_fk");

            builder.HasOne(d => d.Zone)
                .WithMany(p => p.CameraZones)
                .HasForeignKey(d => d.ZoneId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cm_zn_fk");
        }
    }
}
