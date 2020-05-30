using CarShowroomLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShowroomLibrary.DAL;

namespace CarShowroomLibrary.Models
{
    [Serializable]
    //Класс автосалон в котором содержатся все нужные для работы программы списки,
    //методы создания тестовыйх данных, сохраниния в файл и загрузки от туда,
    //добавления нового элемента в колекцию, флаг проверки синхронизации данных
    public class CarShowroom
    {
        public bool ifSaved = true;
        public List<CarInApplic> Application { private set; get; }
        public List<Car> Cars { private set; get; }
        public List<Car> ShoppingCart { private set; get; }
        public List<Buyer> Buyers { private set; get; }
        public List<Report> Reports { private set; get; }
        public string[] coun = new string[] { "China","USA","Japan","Germany","South Korea","India","Spain",
                "Japan", "Germany", "Germany", "Japan", "Japan" };
        public string[] mar = new string[] { "Lifan", "Tesla", "Toyota", "BMW", "Kia", "TATA Motors",
                "SEAT", "Suzuki", "Audi", "Porsche", "Mitsubishi", "Subaru" };
        public CarShowroom()
        {
            Cars = new List<Car>();
            Buyers = new List<Buyer>();
            Reports = new List<Report>();
            Application = new List<CarInApplic>();
            ShoppingCart = new List<Car>();
        }
        public void FindBestModel(Buyer buyer)
        {
            ShoppingCart.Clear();
            foreach (var c in Cars)
            {
                if(c.Model==buyer.ModelRequired|| buyer.ModelRequired.Equals("nope"))
                {
                    ShoppingCart.Add(c);
                }
            }
        }
        public void FindBestPrice(Buyer buyer)
        {
            ShoppingCart.Clear();
            foreach (var c in Cars)
            {
                if (Convert.ToInt32(c.Price) <= Convert.ToInt32(buyer.FinancialOpp) )
                {
                    ShoppingCart.Add(c);
                }
            }
        }
        public void FindAllthebest(Buyer buyer)
        {
            ShoppingCart.Clear();
            foreach (var c in Cars)
            {
                if (Convert.ToInt32(c.TechState) <= Convert.ToInt32(buyer.PerfomanceRequired)
                    && Convert.ToInt32(c.Price) <= Convert.ToInt32(buyer.FinancialOpp)
                    && (c.Model == buyer.ModelRequired || buyer.ModelRequired.Equals("nope"))
                    && Convert.ToInt32(c.MaksSpeed) <= Convert.ToInt32(buyer.MaksSpeedRequired))
                {
                    ShoppingCart.Add(c);
                }
            }
        }

        public void AddCar(Car NewCar)
        {
            int ma = 0;
            bool chek = true;
            foreach (var t in Cars)
            {
                if (t.ID > ma) ma = t.ID;
                if (t.ID.Equals(NewCar.ID)) chek = false;
            }
            if(chek== true|| NewCar.ID.Equals(null) || NewCar.ID.Equals(-1)) NewCar.ID = ma + 1;
            Cars.Add(NewCar);
        }
            public void FillTestData(int n)
        {
            // Cars
            Cars.Clear();
            for (int i = 0; i < n; i++)
            {
                Cars.Add(new Car()
                {
                    Features = "nope",
                    ID =i+1,
                    MaksSpeed = (i * 10) % 180 + 100 + 5*(i%2),
                    Price = (i * 1000) % 20000 + 6000,
                    ProdCountry = coun[i % coun.Length],
                    Model = mar[i % mar.Length],
                    TechState = (3*i + 20) % 100,
                    YearOfIssue = 2000 + i % 20
                }) ; 
            }
            // Buyers
            for (int i = 1; i <= n; i++)
            {
                int numb = 80042900 + i % 2000;
                Buyer NewB= new Buyer()
                { 
                    Contacts = $"+{numb}",
                    FinancialOpp = ((i * i + 1) * 1000) % 50000 + 7000,
                    MaksSpeedRequired = (i * 10) % 140 + 60,
                    ModelRequired = mar[(i + 3) % mar.Length],
                    Name = $"Buyer_{i}",
                    Password = "9999",
                    PerfomanceRequired = i
                };
                if (i % 5 == 0) NewB.ModelRequired = "nope";
                Buyers.Add(NewB);
            }
            // Reports
            int div = 2;//сколько в каждом отчете машин
            for (int t = 0; t < n/div; t++)
            {
                var ps = new List<Car>();
                for (int j = 0; j < div; j++)
                {
                    ps.Add(new Car {
                        Features = Cars[t * div + j].Features,
                        ID = Cars[t * div + j].ID,
                        MaksSpeed = Cars[t * div + j].MaksSpeed,
                        Model = Cars[t * div + j].Model,
                        Price = Cars[t * div + j].Price,
                        ProdCountry = Cars[t * div + j].ProdCountry,
                        TechState = Cars[t * div + j].TechState,
                        YearOfIssue = Cars[t * div + j].YearOfIssue
                    }) ;
                }
                Reports.Add(new Report(ps, Buyers[t].Name,DateTime.Now+TimeSpan.FromDays(t)));
            }
            
        }
        public void Save()
        {
            new Dao(this).Save();
        }
        public void Load()
        {
            new Dao(this).Load();
        }
        public void Send()
        {
            new Dao(this).SaveAppl();
        }
    }
}
