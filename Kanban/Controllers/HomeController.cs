using Microsoft.AspNetCore.Mvc;

namespace Kanban.Controllers
{
  public class HomeController : Controller
  {

    public ActionResult Index()
    {
      return View();
    }

  }
}