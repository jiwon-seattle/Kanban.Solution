using System;
using System.Collections.Generic;

namespace Kanban.Models
{
  public class Status
  {
   public int StatusId {get; set;}
   public string StatusName {get; set;}
   public virtual ICollection<ToDoList> ToDoLists {get; set;}

    public Status()
    {
      this.ToDoLists = new HashSet<ToDoList>();
    }
    
  }
}