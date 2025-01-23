using Microsoft.EntityFrameworkCore;
using ServicesBlazor.Data.Model;

namespace ServicesBlazor.Data.DB;

public class AppDbContext : DbContext
{
    public DbSet<ServicesModel> Services { get; set; }
    public DbSet<CompanyModel> Companies { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServicesModel>()
            .HasOne(s => s.Company)
            .WithMany(c => c.Services)
            .HasForeignKey(s => s.CompanyId);
    }
}
