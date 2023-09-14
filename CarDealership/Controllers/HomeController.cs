using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller  
  {

        [Route("/")] 
      public string Car() { return "Car list will display here!"; }
      
  }
}