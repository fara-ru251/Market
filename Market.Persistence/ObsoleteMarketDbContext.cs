using Market.Application.Interfaces;
//using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Persistence
{
    //public class MarketDbContext : DbContext, IMarketDbContext
    //{
    //    public MarketDbContext(DbContextOptions<MarketDbContext> options)
    //       : base(options)
    //    {
    //    }

    //    public DbSet<Camera> Cameras { get; set; }

    //    public DbSet<Track> Tracks { get; set; }


    //    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    //{
    //    //    if (!optionsBuilder.IsConfigured)
    //    //    {
    //    //        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
    //    //        optionsBuilder.UseNpgsql("Host=172.16.3.62;Database=postgres;Username=postgres;Password=p@ssw0rd");
    //    //        "MarketDatabase": "Host=172.16.3.62;Port=5432;Database=postgres;Username=postgres;Password=p@ssw0rd"
    //    //    }
    //    //}



    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

    //        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MarketDbContext).Assembly);

    //        modelBuilder.HasSequence("track_id_seq");
    //    }
    //}
}
