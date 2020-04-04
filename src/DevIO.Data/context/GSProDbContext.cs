using DevIO.Bussines.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DevIO.Data.context
{
    public class GSProDbContext : DbContext
    {
        public GSProDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Siati> Siatis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GSProDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);

        }
    }
}
