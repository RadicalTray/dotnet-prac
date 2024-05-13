using Microsoft.EntityFrameworkCore;
using Backend.Model;

namespace Backend.Database;

public class SupplierContext : DbContext {
    private static readonly string connStr = "Host=localhost;Port=5432;Database=test;Username=postgres;Password=1234";
    public DbSet<Supplier>? suppliers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseNpgsql(connStr).UseSnakeCaseNamingConvention();
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Supplier>().Property(supplier => supplier.Id).IsRequired();
        base.OnModelCreating(modelBuilder);
    }
}