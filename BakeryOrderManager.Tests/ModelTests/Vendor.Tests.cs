using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderManager.Models;
using System;
using System.Collections.Generic;

namespace BakeryOrderManager.Tests
{
	[TestClass]
	public class VendorTests : IDisposable
	{
		public void Dispose()
    {
      Vendor.ClearAll();
    }

		[TestMethod]
		public void Vendor_CreateNewInstanceOfClass_NewVendor()
		{
			Vendor newVendor = new Vendor("Test", "lorem ipsum");
			Assert.AreEqual(typeof(Vendor),  newVendor.GetType());
		}

		[TestMethod]
		public void Vendor_CreateNewInstanceOfClassWithOrder_NewVendor()
		{
			Vendor newVendor = new Vendor("Test", "lorem ipsum");
			Assert.AreEqual(typeof(Vendor),  newVendor.GetType());
		}

		[TestMethod]
		public void GetVendors_ReturnListOfAllVendors_VendorList()
		{
			Vendor newVendor = new Vendor("Test", "lorem ipsum");
			Vendor newVendor2 = new Vendor("Test2", "lorem ipsum");
			Vendor newVendor3 = new Vendor("Test3", "lorem ipsum");
			List<Vendor> testVendors = new List<Vendor> { newVendor, newVendor2, newVendor3 };
			CollectionAssert.AreEqual(testVendors, Vendor.GetVendors());
		}

		[TestMethod]
		public void AddOrder_AddOrderWithGivenInfo_Order()
		{
			Vendor newVendor = new Vendor("Test", "lorem ipsum");
			newVendor.AddOrder("TestOrder", "desc", 1f);
			Order testOrder = newVendor.GetOrder("TestOrder0");
			Assert.AreEqual(testOrder.Name, "TestOrder");
			Assert.AreEqual(testOrder.Description, "desc");
			Assert.AreEqual(testOrder.Price, 1f);
		}

		[TestMethod]
		public void RemoveOrder_RemoveCorrectOrder_Order()
		{
			Vendor newVendor = new Vendor("Test", "lorem ipsum");
			newVendor.AddOrder("TestOrder", "desc", 1f);
			newVendor.RemoveOrder("TestOrder0");
			Assert.AreEqual(newVendor.GetOrder("TestOrder0"),  null);
		}

		[TestMethod]
		public void FindVendor_ReturnCorrectVendor_Vendor()
		{
			Vendor newVendor = new Vendor("Test", "lorem ipsum");
			Assert.AreEqual(newVendor, Vendor.FindVendor("Test"));
		}

		[TestMethod]
		public void RemoveVendor_RemoveCorrectVendor_Vendor()
		{
			Vendor newVendor = new Vendor("Test", "lorem ipsum");
			Vendor.RemoveVendor(newVendor.Name);
			Assert.AreEqual(null, Vendor.FindVendor(newVendor.Name));
		}
	}
}
