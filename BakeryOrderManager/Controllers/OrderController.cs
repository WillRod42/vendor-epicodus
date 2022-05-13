using Microsoft.AspNetCore.Mvc;
using BakeryOrderManager.Models;

namespace BakeryOrderManager.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorName}/orders/new")]
    public ActionResult New(string vendorName)
    {
      return View(Vendor.FindVendor(vendorName));
    }

    [HttpPost("/vendors/{vendorName}")]
		public ActionResult Create(string vendorName, string name, string desc, float price)
		{
			Order newOrder = new Order(name, desc, price);
      Vendor.FindVendor(vendorName).Orders.Add(newOrder);
			return RedirectToAction("Index", "Vendor");
		}
  }
}