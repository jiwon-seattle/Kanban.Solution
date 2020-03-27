using System;
using System.Collections.Generic;

namespace ProductManagement.Models
{
  public class ToDoList
  {
    public int ToDoListId {get; set;}
    public int ProductId {get; set;}
    public virtual Product Product {get; set;}
    public string Name {get; set;}
    public string Content {get; set;}
    public DateTime DueDate {get; set;}
    public bool CheckCompletion {get; set;}
  }
}