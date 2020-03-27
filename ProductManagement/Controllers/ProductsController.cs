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

    public ActionResult Details(int id)
    {
      var thisProduct = _db.Products
          .Include(product => product.ToDoLists) //keep an eye on this;
          .Include(product => product.Managers)
          .ThenInclude(join => join.Manager)
          .FirstOrDefault(product => product.ProductId == id);
      return View(thisProduct);
    }

    public ActionResult Edit(int id)
    {
      var thisProduct = _db.Products.FirstOrDefault(product => product.ProductId ==id);
      return View(thisProduct);
    }

    [HttpPost]
    public ActionResult Edit(Product product)
    {
      _db.Entry(product).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisProduct = _db.Products.FirstOrDefault(product => product.ProductId == id);
      return View(thisProduct);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisProduct = _db.Products.FirstOrDefault(product => product.ProductId == id);
      _db.Products.Remove(thisProduct);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  } 
}