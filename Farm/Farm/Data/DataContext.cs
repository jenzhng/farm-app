using Farm.Models;
using Microsoft.EntityFrameworkCore;

namespace Farm.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
  public DbSet<User> Users { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Register> Registers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Register>()
                   .HasOne(p => p.Property)
                   .WithMany(pc => pc.Registers)
                   .HasForeignKey(c => c.PropertyId);

            modelBuilder.Entity<Register>()
                   .HasOne(p => p.User)
                   .WithMany(pc => pc.Registers)
                   .HasForeignKey(c => c.UserId);
        }
      

    }

}
