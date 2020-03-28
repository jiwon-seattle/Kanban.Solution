using System;
using System.Collections.Generic;

namespace Kanban.Models
{
  public class Status
  {
    public int StatusId {get; set;}
    public Tracking Tracking {get;}
    public virtual ICollection<ToDoList> ToDoLists {get; set;}
    public Status()
    {
      this.ToDoLists = new HashSet<ToDoList>();
    }
  }

  public class Tracking
  {
    public string Stories = "Stories";
    public string ToDo = "To Do";
    public string InProgress = "In Progress";
    public string Testing = "Testing";
    public string Done = "Done";
  }
}