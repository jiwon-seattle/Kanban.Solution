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
  
  [Authorize]
  public class ProjectsController : Controller
  {
    private readonly KanbanContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public ProjectsController(UserManager<ApplicationUser> userManager, KanbanContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userProjects = _db.Projects.Where(entry => entry.User.Id == currentUser.Id);
      return View(userProjects);
    } 
    
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Project project)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      project.User = currentUser;
     _db.Projects.Add(project);
     
      _db.SaveChanges();
     return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisProject = _db.Projects
          .Include(project => project.ToDoLists) //keep an eye on this;
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

    public ActionResult AssignPeople(int id)
    {

      var thisProject = _db.Projects.FirstOrDefault(project => project.ProjectId == id);
      ViewBag.ManagerId = new SelectList(_db.Managers, "ManagerId", "Name");
      return View(thisProject);
    }

    [HttpPost]
    public ActionResult AssignPeople(Project project, int ManagerId)
    {
      if (ManagerId != 0)
      {
        _db.ProjectManagers.Add(new ProjectManager() { ManagerId = ManagerId, ProjectId = project.ProjectId});
      }
      _db.SaveChanges();

      return RedirectToAction("Details", new {id = project.ProjectId});
    }

    
  } 
}