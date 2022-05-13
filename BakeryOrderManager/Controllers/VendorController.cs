using Microsoft.AspNetCore.Mvc;
using BakeryOrderManager.Models;

namespace BakeryOrderManager.Controllers
{
	public class VendorController : Controller
	{
		[HttpGet("/vendors")]
		public ActionResult Index()
		{
			return View(Vendor.GetVendors());
		}

		[HttpGet("/vendors/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpGet("vendors/{vendorName}")]
		public ActionResult Show(string vendorName)
		{
			return View(Vendor.FindVendor(vendorName));
		}

		[HttpPost("/vendors")]
		public ActionResult New(string name, string desc)
		{
			new Vendor(name, desc);
			return RedirectToAction("Index");
		}
	}
}
