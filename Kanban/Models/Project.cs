using System;
using System.Collections.Generic;

namespace Kanban.Models
{
  public class Project
  {
    public int ProjectId {get; set;}
    public string ProjectName {get; set;}
    public string Content {get; set;}
    public DateTime KickOffDate {get; set;}
    public DateTime DueDate {get; set;}
    public bool ActiveStatus {get; set;}
    public virtual ApplicationUser User {get; set;}
    public ICollection<ProjectManager> Managers {get; set;}
    public ICollection<ToDoList> ToDoLists {get; set;}
    public Project()
    {
      this.Managers = new HashSet<ProjectManager> ();
      this.ToDoLists = new HashSet<ToDoList> ();
    }
  }
}