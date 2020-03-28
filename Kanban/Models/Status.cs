using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Status>().HasData(
          new Status {StatusId = 0, StatusName = "To-Do",},
          new Status {StatusId = 1, StatusName = "In Progress",},
          new Status {StatusId = 2, StatusName = "Testing",},
          new Status {StatusId = 3, StatusName = "Done",}
        );
    }
    
  }
}