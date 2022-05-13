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

    [HttpGet("/vendors/{vendorName}/orders/{orderId}")]
    public ActionResult Show(string vendorName, string orderId)
    {
      Vendor vendor = Vendor.FindVendor(vendorName);
      Order order = vendor.GetOrder(orderId);
      return View(new KeyValuePair<Order, string>(order, vendorName));
    }

    [HttpPost("/vendors/{vendorName}")]
		public ActionResult Create(string vendorName, string name, string desc, float price)
		{
      Vendor.FindVendor(vendorName).AddOrder(name, desc, price);
			return RedirectToAction("Show", "Vendor", new {vendorName = vendorName});
		}

    [HttpPost("/vendors/{vendorName}/orders/{orderId}")]
    public ActionResult Destroy(string vendorName, string orderId)
    {
      Vendor vendor = Vendor.FindVendor(vendorName);
      vendor.RemoveOrder(orderId);
      return RedirectToAction("Show", "Vendor", new {vendorName = vendorName});
    }
  }
}