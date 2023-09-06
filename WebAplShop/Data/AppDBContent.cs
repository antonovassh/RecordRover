using Microsoft.EntityFrameworkCore;
using VinylRecords.Data.Models;

namespace VinylRecords.Data;
public class AppDBContent : DbContext
{
    public AppDBContent() { }

    public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
    {

    }
    public DbSet<Plate> Plates { get; set; }

    public DbSet<Category> Category { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = configuration.GetConnectionString("DbCoreConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

