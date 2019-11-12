using Market.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence.Configurations
{
    class CamerasConfiguration : IEntityTypeConfiguration<Cameras>
    {
        public void Configure(EntityTypeBuilder<Cameras> builder)
        {
            builder.HasKey(e => e.CameraId)
                .HasName("cameras_pkey");

            builder.ToTable("cameras");

            builder.Property(e => e.CameraId)
                .HasColumnName("camera_id")
                .ValueGeneratedNever();

            builder.Property(e => e.CameraName).HasColumnName("camera_name");
        }
    }
}
