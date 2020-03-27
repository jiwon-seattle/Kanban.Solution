using System;
using System.Collections.Generic;

namespace ProductManagement.Models
{
  public class Manager
  {
    public int ManagerId { get; set;}
    public string Name { get; set; }
    public string ContactInfo {get; set;}
    public DateTime HireDate {get; set;}
    public string Position {get; set;} //desining positions
    public string Level {get; set;} //desining levels
    public bool CurrentStatus {get; set;}
    public virtual ApplicationUser User {get; set;}
    public ICollection<ProductManager> Products {get; set;}
    public Manager()
    {
      this.Products = new HashSet<ProductManager> ();
    }
  }
}