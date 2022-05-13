using Microsoft.AspNetCore.Mvc;
using BakeryOrderManager.Models;

namespace BakeryOrderManager.Controllers
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
