using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using ProductManagement.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ProductManagement.Controllers
{
  public class ToDoListsController : Controller
  {
    private readonly ToDoListContext _db;

    public ToDoListsController(ToDoListContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<ToDoList> model = _db.ToDoLists.Include(todolists => todolists.Product).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.ProductId = new SelectList(_db.Products, "ProductId", "ProductName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(ToDoList todolist)
    {
      _db.ToDoLists.Add(todolist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      ToDoList thisToDoList = _db.ToDoLists.FirstOrDefault(todolists => todolists.ToDoListId == id);
      return View(thisToDoList);
    }

    public ActionResult Edit(int id)
    {
      var thisToDoList = _db.ToDoLists.FirstOrDefault(todolists => todolists.ToDoListId == id);
      ViewBag.ProductId = new SelectList(_db.Products, "ProductId", "ProductName");
      return View(thisToDoList);
    }

    [HttpPost]
    public ActionResult Edit(ToDoList todolist)
    {
      _db.Entry(todolist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisToDoList = _db.ToDoLists.FirstOrDefault(todolists => todolists.ToDolistId == id);
      return View(thisToDoList);
    }

    [HttpPost,ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisToDoList = _db.ToDoLists.FirstOrDefault(todolists => todolists.ToDoListId == id);
      _db.ToDoLists.Remove(thisToDoList);
      _db.SaveChangeS();
      return RedirectToAction("Index");
    }
  }
}