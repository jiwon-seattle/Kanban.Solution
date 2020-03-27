using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using DoctorOffice.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ProductManagement.Controllers
{
  public class ProductsController : Controller
  {
    private readonly ProductManagementContext _db;

    public ProductsController(ProductManagementContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Product> model = _db.Products.ToList();
      return View(model);
    }
    
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Product product)
    {
      _db.Products.Add(product);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  } 
}