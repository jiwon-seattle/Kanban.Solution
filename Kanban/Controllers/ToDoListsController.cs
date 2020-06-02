using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Kanban.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Kanban.Controllers
{
  public class ToDoListsController : Controller
  {
    private readonly KanbanContext _db;

    public ToDoListsController(KanbanContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<ToDoList> model = _db.ToDoLists
      .Include(todolists => todolists.Project)
      .Include(todolists => todolists.Status)
      .Include(todolists => todolists.Manager)
      .ToList();
      return View(model);
    }

    public ActionResult Create(int ProjectId)
    {
      Console.WriteLine("ProjectId is");
      Console.WriteLine(ProjectId);
      ViewBag.ProjectId = ProjectId;
      ViewBag.StatusId = new SelectList(_db.Statuses, "StatusId", "StatusName");
      ViewBag.ManagerId = new SelectList(_db.Managers, "ManagerId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(ToDoList todolist)
    {
      _db.ToDoLists.Add(todolist);
      _db.SaveChanges();
      return RedirectToAction("Index"); // set page to projectDetails
    }

    public ActionResult Details(int id)
    {
      ToDoList thisToDoList = _db.ToDoLists.FirstOrDefault(todolists => todolists.ToDoListId == id);
      Status thisStatus = _db.Statuses.FirstOrDefault(status => status.StatusId == thisToDoList.StatusId);
      Manager thisManager = _db.Managers.FirstOrDefault(manager => manager.ManagerId == thisToDoList.ManagerId);
      ViewBag.StatusName = thisStatus.StatusName;
      ViewBag.Name = thisManager.Name;
      return View(thisToDoList);
    }

    public ActionResult Edit(int id)
    {
      var thisToDoList = _db.ToDoLists.FirstOrDefault(todolists => todolists.ToDoListId == id);
      ViewBag.ProjectId = new SelectList(_db.Projects, "ProjectId", "ProjectName");
      ViewBag.StatusId = new SelectList(_db.Statuses, "StatusId", "StatusName");
      ViewBag.ManagerId = new SelectList(_db.Managers, "ManagerId", "Name");
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
      var thisToDoList = _db.ToDoLists.FirstOrDefault(todolists => todolists.ToDoListId == id);
      return View(thisToDoList);
    }

    [HttpPost,ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisToDoList = _db.ToDoLists.FirstOrDefault(todolists => todolists.ToDoListId == id);
      _db.ToDoLists.Remove(thisToDoList);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}