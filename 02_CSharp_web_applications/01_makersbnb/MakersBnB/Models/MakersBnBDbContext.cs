namespace MakersBnB.Models;
using Microsoft.EntityFrameworkCore;

public class MakersBnBDbContext : DbContext
{
    internal DbSet<Space>? Spaces { get; set; }
    internal DbSet<User>? Users { get; set; }

    internal string? DbPath { get; }

    internal string dbName = "makersbnb_aspdotnet_dev";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
        @"Host=localhost;Username=aysinakpinar;Password=1234;Database=" + this.dbName
        );
}
