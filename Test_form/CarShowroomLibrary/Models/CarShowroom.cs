using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_form.DAL;

namespace Test_form.Models
{
    [Serializable]
    //Класс автосалон в котором содержатся все нужные для работы программы списки,
    //методы создания тестовыйх данных, сохраниния в файл и загрузки от туда,
    //добавления нового элемента в колекцию, флаг проверки синхронизации данных
    public class CarShowroom
    {
        public bool ifSaved = true;
        public List<Car> Cars { private set; get; }
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
        }
        public void AddCar(Car NewCar)
        {
            int ma = 0;
            foreach (var t in Cars)
            {
                if (t.ID > ma) ma = t.ID;
            }
            NewCar.ID = ma + 1;
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
                    Features = "none",
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
                Buyers.Add(new Buyer
                {
                    Contacts = $"+{numb}",
                    FinancialOpp = ((i * i + 1) * 1000) % 50000 + 7000,
                    MaksSpeedRequired = (i * 10) % 140 + 60,
                    ModelRequired = mar[(i + 3) % mar.Length],
                    Name = $"Buyer_{i}",
                    Password = "9999",
                    PerfomanceRequired = i
                });
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
                Reports.Add(new Report(ps, Buyers[t],DateTime.Now+TimeSpan.FromDays(t)));
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
    }
}
