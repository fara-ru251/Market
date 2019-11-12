using Market.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence.Configurations
{
    public class OperatorsServiceConfiguration : IEntityTypeConfiguration<OperatorService>
    {
        public void Configure(EntityTypeBuilder<OperatorService> builder)
        {
            builder.HasKey(e => e.ServiceId)
                  .HasName("operator_service_pkey");

            builder.ToTable("operator_service");

            builder.Property(e => e.ServiceId)
                .HasColumnName("service_id")
                .HasDefaultValueSql("nextval('\"Operator_service_id_seq\"'::regclass)");

            builder.Property(e => e.InTime).HasColumnName("in_time");

            builder.Property(e => e.OperatorId).HasColumnName("operator_id");

            builder.Property(e => e.OutTime).HasColumnName("out_time");

            builder.HasOne(d => d.Operator)
                .WithMany(p => p.OperatorService)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("os_op_fk");
        }
    }
}
