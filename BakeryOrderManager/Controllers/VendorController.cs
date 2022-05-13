using Microsoft.AspNetCore.Mvc;
using BakeryOrderManager.Models;

namespace BakeryOrderManager.Controllers
{
	public class VendorController : Controller
	{
		[HttpGet("/vendor")]
		public ActionResult Index()
		{
			return View();
		}
	}
}
