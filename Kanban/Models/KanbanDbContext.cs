using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kanban.Models
{
  public class KanbanContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Project> Projects { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<ToDoList> ToDoLists {get; set;}
    public DbSet<Status> Statuses {get; set;}
    public DbSet<ProjectManager> ProjectManagers { get; set; }
    public KanbanContext(DbContextOptions options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Status>().HasData(
        new Status {StatusId = 1, StatusName = "Idea",},
        new Status {StatusId = 2, StatusName = "ToDo",},
        new Status {StatusId = 3, StatusName = "Doing",},
        new Status {StatusId = 4, StatusName = "Done",}
        );
    }
  }
}