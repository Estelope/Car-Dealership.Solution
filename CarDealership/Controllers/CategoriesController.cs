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

    [HttpGet("/categories/{id}")]
  public ActionResult Show(int id)
  {
    Dictionary<string, object> model = new Dictionary<string, object>();
    Category selectedCategory = Category.Find(id);
    List<Car> categoryItems = selectedCategory.Cars;
    model.Add("category", selectedCategory);
    model.Add("Cars", categoryItems);
    return View(model);
  }

  [HttpPost("/categories/{categoryId}/cars")]
    public ActionResult Create(int categoryId, string carDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      Car newCar = new Car(carDescription);
      foundCategory.AddCar(newCar);
      List<Car> categoryCars = foundCategory.Cars;
      model.Add("cars", categoryCars);
      model.Add("category", foundCategory);
      return View("Show", model);
    }
  }
}