using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProductManagement.Models
{
  public class ProductManagementContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Product> Products { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<ToDoList> ToDoLists {get; set;}
    public DbSet<ProductManager> ProductManagers { get; set; }
    public ProductManagementContext(DbContextOptions options) : base(options){}
  }
}