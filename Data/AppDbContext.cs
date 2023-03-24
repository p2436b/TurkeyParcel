using Microsoft.EntityFrameworkCore;

namespace TurkeyParcel.Data;

public class AppDbContext : DbContext
{
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseNpgsql("Host=localhost;Database=turkey-parcel;User ID=postgres;Password=postgres");
  }

  public DbSet<Feature> Features { get; set; }
}