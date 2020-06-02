using System;
using System.Collections.Generic;

namespace Kanban.Models
{
  public class ToDoList
  {
    public int ToDoListId {get; set;}
    public int ProjectId {get; set;}
    public int StatusId {get; set;}
    public int ManagerId {get; set;}
    public virtual Project Project {get; set;}
    public virtual Status Status {get; set;}
    public virtual Manager Manager {get; set;}
    public string Name {get; set;}
    public string Content {get; set;}
    public int Priority {get; set;}
    public bool CheckCompletion {get; set;}
  }
}