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
  public class ManagersController : Controller
  {
    private readonly KanbanContext _db;
    public ManagersController(KanbanContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Managers.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.ProjectId = new SelectList(_db.Projects, "ProjectId", "ProjectName");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Manager manager, int ProjectId)
    {
    _db.Managers.Add(manager);
    if (ProjectId != 0)
    {
      _db.ProjectManagers.Add(new ProjectManager() { ProjectId = ProjectId, ManagerId = manager.ManagerId});
    }
    _db.SaveChanges();
    return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisManager = _db.Managers
          .Include(manager => manager.ToDoLists)
          .Include(manager => manager.Projects)
          .ThenInclude(join => join.Project)
          .FirstOrDefault(manager => manager.ManagerId == id);
      return View(thisManager);
    }

    public ActionResult Edit(int id)
    {
      var thisManager = _db.Managers.FirstOrDefault(manager => manager.ManagerId == id);
      ViewBag.ProjectId = new SelectList(_db.Projects, "ProjectId", "ProjectName");
      return View(thisManager);
    }

    [HttpPost]
    public ActionResult Edit(Manager manager, int ProjectId)
    {
      if (ProjectId != 0)
      {
        _db.ProjectManagers.Add(new ProjectManager() { ProjectId = ProjectId, ManagerId = manager.ManagerId});
      }
      _db.Entry(manager).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddProject(int id)
    {
      var thisManager = _db.Managers.FirstOrDefault(manager => manager.ManagerId == id);
      ViewBag.ProjectId = new SelectList(_db.Projects, "ProjectId", "ProjectName");
      return View(thisManager);
    }

    [HttpPost]
    public ActionResult AddProject(Manager manager, int ProjectId)
    {
      if (ProjectId != 0)
      {
        _db.ProjectManagers.Add(new ProjectManager() { ProjectId = ProjectId, ManagerId = manager.ManagerId});
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisManager = _db.Managers.FirstOrDefault(manager => manager.ManagerId == id);
      return View(thisManager);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisManager = _db.Managers.FirstOrDefault(manager => manager.ManagerId == id);
      _db.Managers.Remove(thisManager);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteProject(int joinId)
    {
      var joinEntry = _db.ProjectManagers.FirstOrDefault(entry => entry.ProjectManagerId == joinId);
      _db.ProjectManagers.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}