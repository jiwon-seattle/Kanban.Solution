using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Kanban.Controllers
{
  public class StatusesController : Controller
  {
    private readonly KanbanContext _db;

    public StatusesController(KanbanContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Status> model = _db.Statuses.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Status status)
    {
      _db.Statuses.Add(status);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Status thisStatus = _db.Statuses.FirstOrDefault(status => status.StatusId == id);
      return View(thisStatus);
    }

    public ActionResult Edit(int id)
    {
      var thisStatus = _db.Statuses.FirstOrDefault(status => status.StatusId == id);
      return View(thisStatus);
    }

    [HttpPost]
    public ActionResult Edit(Status status)
    {
      _db.Entry(status).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisStatus = _db.Statuses.FirstOrDefault(status => status.StatusId == id);
      return View(thisStatus);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisStatus = _db.Statuses.FirstOrDefault(status => status.StatusId == id);
      _db.Statuses.Remove(thisStatus);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}