using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarShowroomLibrary.Models;

namespace MyCarsTest
{
    [TestClass]
    public class CarsTest //класс для тестирований приложения
    {
        
        CarShowroom CarShowroom1;
        [TestMethod]
        public void TestCountryAndModel()//тестирует правильность работы метода FillTestData;
        {
            CarShowroom1 = new CarShowroom();
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
        [TestMethod]
        public void TestBuyerPass()//тестирует правильность работы метода для составления паролей;
        {
            CarShowroom1 = new CarShowroom();
            int n = 50;
            CarShowroom1.FillTestData(n);
            foreach(var b in CarShowroom1.Buyers)
            {
                Assert.IsTrue(b.Password.Length >= 3);
                Assert.IsTrue(b.Name.Length >= 3);
            }
        }

    }
}
