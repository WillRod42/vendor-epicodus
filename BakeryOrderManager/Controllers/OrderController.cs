using Microsoft.AspNetCore.Mvc;
using BakeryOrderManager.Models;
using System.Collections.Generic;

namespace BakeryOrderManager.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorName}/orders/new")]
    public ActionResult New(string vendorName)
    {
      return View(Vendor.FindVendor(vendorName));
    }

    [HttpGet("/vendors/{vendorName}/orders/{orderName}")]
    public ActionResult Show(string vendorName, string orderName)
    {
      Vendor vendor = Vendor.FindVendor(vendorName);
      Order order = vendor.GetOrder(orderName);
      return View(new KeyValuePair<Order, string>(order, vendorName));
    }

    [HttpPost("/vendors/{vendorName}")]
		public ActionResult Create(string vendorName, string name, string desc, float price)
		{
			Order newOrder = new Order(name, desc, price);
      Vendor.FindVendor(vendorName).Orders.Add(newOrder);
			return RedirectToAction("Show", "Vendor", new {vendorName = vendorName});
		}
  }
}