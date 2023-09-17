using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
      [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Item> allCars = Cars.GetAll();
      return View(allCars);
    }
  }
}