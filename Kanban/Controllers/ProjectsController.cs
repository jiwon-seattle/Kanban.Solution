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
  public class ProjectsController : Controller
  {
    private readonly KanbanContext _db;

    public ProjectsController(KanbanContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Project> model = _db.Projects.ToList();
      return View(model);
    }
    
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Project project)
    {
      _db.Projects.Add(project);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisProject = _db.Projects
          // .Include(project => project.ToDoLists) //keep an eye on this;
          .Include(project => project.Managers)
          .ThenInclude(join => join.Manager)
          .FirstOrDefault(project => project.ProjectId == id);
      return View(thisProject);
    }

    public ActionResult Edit(int id)
    {
      var thisProject = _db.Projects.FirstOrDefault(project => project.ProjectId ==id);
      return View(thisProject);
    }

    [HttpPost]
    public ActionResult Edit(Project project)
    {
      _db.Entry(project).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisProject = _db.Projects.FirstOrDefault(project => project.ProjectId == id);
      return View(thisProject);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisProject = _db.Projects.FirstOrDefault(project => project.ProjectId == id);
      _db.Projects.Remove(thisProject);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  } 
}