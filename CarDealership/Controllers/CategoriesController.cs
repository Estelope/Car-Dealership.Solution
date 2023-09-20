using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CategoriesController : Controller
  {

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> allCategories = Category.GetAll();
      return View(allCategories);
    }

    [HttpGet("/categories/new")]
  public ActionResult New()
  {
    return View();
  }
  
    [HttpPost("/categories")]
  public ActionResult Create(string categoryName)
  {
    Category newCategory = new Category(categoryName);
    return RedirectToAction("Index");
  }
  }
}