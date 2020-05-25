using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_form.Models;

namespace MyCarsTest
{
    [TestClass]
    public class CarsTest
    {
        [TestMethod]
        public void TestCountryAndModel()
        {
            CarShowroom CarShowroom1 = new CarShowroom();
            int n = 50;
            CarShowroom1.FillTestData(n);
            Assert.AreEqual(CarShowroom1.mar.Length , CarShowroom1.coun.Length);
            if (n > CarShowroom1.mar.Length * 2 + 1) n = CarShowroom1.mar.Length*2+1;
            for(int i=0;i<n;i++)
            {
                Assert.AreEqual(CarShowroom1.mar[i% CarShowroom1.coun.Length], CarShowroom1.Cars[i].Model);
                Assert.AreEqual(CarShowroom1.coun[i % CarShowroom1.mar.Length], CarShowroom1.Cars[i].ProdCountry);
            }
        }
    }
}
