using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Factory.Models
{
  public class FactoryContextFactory : IDesignTimeDbContextFactory<FactoryContext>
  {
    FactoryContext IDesignTimeDbContextFactory<FactoryContext>.CreateDbContext(String[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .addJsonFile("appsettings.json")
        .build();

      var builder = new DbContextOptionsBuilder<FactoryContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new FactoryContext(builder.Options);
    }
  }
}