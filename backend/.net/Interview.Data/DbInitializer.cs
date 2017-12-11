using System;
using System.Linq;
using Interview.Entities;
using Microsoft.EntityFrameworkCore;

namespace Interview.Data
{
  public static class DbInitializer
  {
    public static void Initialize(InterviewDbContext context)
    {
      context.Database.Migrate();
      SeedData(context);
    }

    private static void SeedData(InterviewDbContext context)
    {
      if (context.Assets.Any())
      {
        return;
      };
      context.Assets.AddRange(Asset.GetSeedData());
      context.SaveChanges();
    }


  }
}