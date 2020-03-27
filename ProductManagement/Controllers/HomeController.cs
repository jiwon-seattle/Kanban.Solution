using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
  public class HomeController : Controller
  {

    public ActionResult Index()
    {
      return View();
    }

  }
}