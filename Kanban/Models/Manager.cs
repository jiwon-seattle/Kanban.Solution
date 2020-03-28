using System;
using System.Collections.Generic;

namespace Kanban.Models
{
  public class Manager
  {
    public int ManagerId { get; set;}
    public string Name { get; set; }
    public string ContactInfo {get; set;}
    public DateTime RegisteredDate {get; set;}
    public string Position {get; set;} //desining positions
    public bool CurrentStatus {get; set;}
    //public virtual ApplicationUser User {get; set;}
    public ICollection<ProjectManager> Projects {get; set;}
    public Manager()
    {
      this.Projects = new HashSet<ProjectManager> ();
    }
  }
}