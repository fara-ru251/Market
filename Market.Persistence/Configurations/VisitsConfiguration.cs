using Market.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence.Configurations
{
    class VisitsConfiguration : IEntityTypeConfiguration<Visits>
    {
        public void Configure(EntityTypeBuilder<Visits> builder)
        {
            builder.HasKey(e => e.VisitId)
                    .HasName("visits_pkey");

            builder.ToTable("visits");

            builder.Property(e => e.VisitId)
                .HasColumnName("visit_id")
                .HasDefaultValueSql("nextval('\"Visits_visit_id_seq\"'::regclass)");

            builder.Property(e => e.CameraId).HasColumnName("camera_id");

            builder.Property(e => e.InTime).HasColumnName("in_time");

            builder.Property(e => e.OutTime).HasColumnName("out_time");

            builder.Property(e => e.ZoneId).HasColumnName("zone_id");

            builder.Property(e => e.Gender).HasColumnName("gender").HasConversion(typeof(string));//.HasColumnType<genders>(nameof(genders)).HasConversion(typeof(genders));

            builder.Property(e => e.Age).HasColumnName("age").HasConversion(typeof(string));//.HasColumnType<ages>(nameof(ages)).HasConversion(typeof(ages));


            builder.HasOne(d => d.CameraZones)
                .WithMany(p => p.Visits)
                .HasForeignKey(d => new { d.ZoneId, d.CameraId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_vz_cz");
        }
    }
}
