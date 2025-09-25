using Microsoft.EntityFrameworkCore;

namespace MovieTicketBackend.Models.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User>  Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .Property(q => q.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<User>()
                .Property(q=>q.CreatedAt)
                .HasDefaultValueSql("SYSUTCDATETIME()");
            modelBuilder.Entity<User>()
                .Property(q => q.UpdatedAt)
                .HasDefaultValueSql("SYSUTCDATETIME()");
        }
    }
}
