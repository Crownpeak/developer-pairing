using System.Linq;
using Interview.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Interview.Data
{
  public class InterviewDbContext : DbContext
  {

    public InterviewDbContext(DbContextOptions<InterviewDbContext> options)
      : base(options)
    {
      
    }

    public bool AllMigrationsApplied()
    {
      var applied = this.GetService<IHistoryRepository>()
        .GetAppliedMigrations()
        .Select(m => m.MigrationId);

      var total = this.GetService<IMigrationsAssembly>()
        .Migrations
        .Select(m => m.Key);

      return !total.Except(applied).Any();
    }

    public DbSet<Asset> Assets { get; set; }
    public DbSet<AssetFields> AssetFields { get; set; }
  }
}