using Backend.Model;

using Microsoft.EntityFrameworkCore;

namespace Backend.Database;

public class StoreContext : DbContext {
    private static readonly string connStr = "Host=localhost;Port=5432;Database=test;Username=postgres;Password=1234";
    public DbSet<Supplier> suppliers => Set<Supplier>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        // TODO: Is this where the EF connects to the db?
        optionsBuilder.UseNpgsql(connStr).UseSnakeCaseNamingConvention();
        base.OnConfiguring(optionsBuilder);
    }
}