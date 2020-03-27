using System;
using System.Collections.Generic;

namespace ProductManagement.Models
{
  public class Product
  {
    public int ProductId {get; set;}
    public string ProductName {get; set;}
    public string Content {get; set;}
    public DateTime KickOffDate {get; set;}
    public DateTime ReleaseDate {get; set;}
    public DateTime DueDate {get; set;} //desining due date
    public bool ActiveStatus {get; set;}
    public virtual ApplicationUser User {get; set;}
    public ICollection<ProductManager> Managers {get; set;}
    public ICollection<ToDoList> ToDoLists {get; set;}
    public Manager()
    {
      this.Products = new HashSet<ProductManager> ();
      this.ToDoLists = new HashSet<ToDoList> ();
    }
  }
}