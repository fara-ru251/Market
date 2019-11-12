using Market.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence.Configurations
{
    class OperatorsConfiguration : IEntityTypeConfiguration<Operators>
    {
        public void Configure(EntityTypeBuilder<Operators> builder)
        {
            builder.HasKey(e => e.OperatorId)
                    .HasName("operators_pkey");

            builder.ToTable("operators");

            builder.Property(e => e.OperatorId)
                .HasColumnName("operator_id")
                .ValueGeneratedNever();

            builder.Property(e => e.OperatorName).HasColumnName("operator_name");
        }
    }
}
