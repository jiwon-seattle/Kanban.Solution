namespace Kanban.Models
{
  public class ProjectManager
  {
    public int ProjectManagerId {get; set;}
    public int ProjectId {get; set;}
    public int ManagerId {get; set;}
    public Project Project {get; set;}
    public Manager Manager {get; set;}
  }
}