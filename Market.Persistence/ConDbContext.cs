using System;
using System.ComponentModel.DataAnnotations.Schema;
using Market.Application.APIVisits.Queries.GetAll;
using Market.Application.Interfaces;
using Market.Domain;
using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Market.Persistence
{
    public partial class ConDbContext : DbContext, IConDbContext
    {
        public ConDbContext()
        {
        }

        public ConDbContext(DbContextOptions<ConDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CameraZones> CameraZones { get; set; }
        public virtual DbSet<Cameras> Cameras { get; set; }
        public virtual DbSet<OperatorService> OperatorService { get; set; }
        public virtual DbSet<OperatorWork> OperatorWork { get; set; }
        public virtual DbSet<Operators> Operators { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }
        public virtual DbSet<Zones> Zones { get; set; }

        //assign primary key
        //public DbSet<GetAllVisitsSP> GetAllVisitsSP { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseNpgsql("Host=172.16.3.62;Port=5432;Database=market;Username=postgres;Password=p@ssw0rd");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForNpgsqlHasEnum(null, "ages", new[] { "young", "teenager", "adult", "old" })
                .ForNpgsqlHasEnum(null, "genders", new[] { "male", "female" })
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");


            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConDbContext).Assembly);


            modelBuilder.Query<VisitAllTimeDTO>();

            modelBuilder.HasSequence("Operator_service_id_seq");

            modelBuilder.HasSequence("Operator_work_id_seq");

            modelBuilder.HasSequence("Visits_visit_id_seq");
        }

    }
}
