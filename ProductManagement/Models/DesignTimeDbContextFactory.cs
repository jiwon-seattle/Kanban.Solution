using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProductManagement.Models
{
  public class ProductManagementContextFactory : IDesignTimeDbContextFactory<ProductManagementContext>
  {

    ProductManagementContext IDesignTimeDbContextFactory<ProductManagementContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ProductManagementContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new DoctorOfficeContext(builder.Options);
    }
  }
}