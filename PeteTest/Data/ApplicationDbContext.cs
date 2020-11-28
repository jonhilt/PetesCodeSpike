using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PeteTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<GEMMessage> GEMMessages { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<GEMMessage>()
                .HasKey(x => x.message_id);

            modelBuilder
                .Entity<GEMMessage>()
                .HasData(Enumerable.Range(1, 500).Select(x => new GEMMessage
                {
                    last_contact = DateTime.Now.AddMinutes(x * -1),
                    message_id = x
                }));

            base.OnModelCreating(modelBuilder);
        }
    }
}