using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Kanban.Models
{
  public class KanbanContext : DbContext
  {
    public virtual DbSet<Project> Projects { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<ToDoList> ToDoLists {get; set;}
    public DbSet<Status> Statuses {get; set;}
    public DbSet<ProjectManager> ProjectManagers { get; set; }
    public KanbanContext(DbContextOptions options) : base(options){}
  }
}