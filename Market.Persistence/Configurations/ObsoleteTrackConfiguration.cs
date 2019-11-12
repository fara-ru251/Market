//using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence.Configurations
{
    //public class TrackConfiguration : IEntityTypeConfiguration<Track>
    //{
    //    public void Configure(EntityTypeBuilder<Track> builder)
    //    {
    //        builder.HasKey(e => e.TrackId)
    //                .HasName("Tracks_pkey");

    //        builder.Property(e => e.TrackId)
    //            .HasColumnName("track_id")
    //            .HasDefaultValueSql("nextval('track_id_seq'::regclass)");

    //        builder.Property(e => e.Age).HasColumnName("age");

    //        builder.Property(e => e.CameraId).HasColumnName("camera_id");

    //        builder.Property(e => e.Date)
    //            .HasColumnName("date")
    //            .HasColumnType("date");

    //        builder.Property(e => e.Gender).HasColumnName("gender");

    //        builder.Property(e => e.InTime)
    //            .HasColumnName("in_time")
    //            .HasColumnType("time without time zone");

    //        builder.Property(e => e.OutTime)
    //            .HasColumnName("out_time")
    //            .HasColumnType("time without time zone");

    //        builder.Property(e => e.ZoneId).HasColumnName("zone_id");

    //        builder.HasOne(d => d.Camera)
    //            .WithMany(p => p.Tracks)
    //            .HasForeignKey(d => d.CameraId)
    //            .HasConstraintName("tr_cm_fk");
    //    }
    //}
}
