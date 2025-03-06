using System.ComponentModel.DataAnnotations;
using AthletiCore.Backend.Models;
using Microsoft.EntityFrameworkCore;
namespace AthletiCore.Backend.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.email)
                .IsUnique();

            modelBuilder.Entity<User>()
                .ToTable(t => t.HasCheckConstraint("CK_User_Role", "role IN ('admin', 'trainer', 'member')"));


            modelBuilder.Entity<User>()
                .Property(u => u.created_at)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }

    }

}
