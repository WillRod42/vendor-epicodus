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
			Vendor newVendor = new Vendor("Test", new Order("TestOrder", "lorem ipsum", 10.00f), "lorem ipsum");
			Assert.AreEqual(typeof(Vendor),  newVendor.GetType());
		}

		[TestMethod]
		public void GetVendors_ReturnListOfAllVendors_VendorList()
		{
			Vendor newVendor = new Vendor("Test", new Order("TestOrder", "lorem ipsum", 10.00f), "lorem ipsum");
			Vendor newVendor2 = new Vendor("Test2", new Order("TestOrder", "lorem ipsum", 10.00f), "lorem ipsum");
			Vendor newVendor3 = new Vendor("Test3", new Order("TestOrder", "lorem ipsum", 10.00f), "lorem ipsum");
			List<Vendor> testVendors = new List<Vendor> { newVendor, newVendor2, newVendor3 };

			Console.WriteLine(testVendors.Count);
			Console.WriteLine(Vendor.GetVendors().Count);

			CollectionAssert.AreEqual(testVendors, Vendor.GetVendors());
		}
	}
}
