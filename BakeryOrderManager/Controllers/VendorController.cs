using Microsoft.AspNetCore.Mvc;
using BakeryOrderManager.Models;

namespace BakeryOrderManager.Controllers
{
	public class VendorController : Controller
	{
		[HttpGet("<insert route here>")]
		public ActionResult Index()
		{
			return View();
		}
	}
}
