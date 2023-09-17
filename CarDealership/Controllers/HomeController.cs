using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller  
  {

        [HttpGet("/")] 
      public ActionResult Index() 
      {
        return View();
      }
  }
}