namespace ProductManagement.Models
{
  public class ProductManagerToDoList
  {
    public int ProductManagerToDoListId {get; set;}
    public int ProductId {get; set;}
    public int ManagerId {get; set;}
    public int ToDoListId {get; set;}
    public Product Product {get; set;}
    public Manager Manager {get; set;}
    public ToDoList ToDoList {get; set;}
  }
}