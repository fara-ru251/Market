using Market.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence.Configurations
{
    public class OperatorsWorkConfiguration : IEntityTypeConfiguration<OperatorWork>
    {
        public void Configure(EntityTypeBuilder<OperatorWork> builder)
        {
            builder.HasKey(e => e.OwId)
                    .HasName("operator_work_pkey");

            builder.ToTable("operator_work");

            builder.Property(e => e.OwId)
                .HasColumnName("ow_id")
                .HasDefaultValueSql("nextval('\"Operator_work_id_seq\"'::regclass)");

            builder.Property(e => e.InTime).HasColumnName("in_time");

            builder.Property(e => e.OperatorId).HasColumnName("operator_id");

            builder.Property(e => e.OutTime).HasColumnName("out_time");

            builder.HasOne(d => d.Operator)
                .WithMany(p => p.OperatorWork)
                .HasForeignKey(d => d.OperatorId)
                .HasConstraintName("ow_op_fk");
        }
    }
}
