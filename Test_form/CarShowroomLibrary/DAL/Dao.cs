using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_form.Models;

namespace Test_form.DAL
{
    public class Dao
    {
        private readonly CarShowroom carShowroom;
        public Dao (CarShowroom carShowroom)
        {
            this.carShowroom = carShowroom;
        }
        const string CARS = "cars.txt";
        const string BUYERS = "buyers.txt";
        const string REPORTS = "reports.txt";
        public void Save()
        {
            SaveCars();
            SaveBuyers();
            SaveReports();
        }

        private void SaveCars()
        {
            using (var wr = new StreamWriter(CARS))
            {
                wr.WriteLine(carShowroom.Cars.Count);
                foreach (var p in carShowroom.Cars)
                {
                    wr.WriteLine(p.Features);
                    wr.WriteLine(p.ID);
                    wr.WriteLine(p.MaksSpeed);
                    wr.WriteLine(p.Model);
                    wr.WriteLine(p.Price);
                    wr.WriteLine(p.ProdCountry);
                    wr.WriteLine(p.TechState);
                    wr.WriteLine(p.YearOfIssue);
                }
            }
        }

        private void SaveBuyers()
        {
            using (var wr = new StreamWriter(BUYERS))
            {
                wr.WriteLine(carShowroom.Buyers.Count);
                foreach (var b in carShowroom.Buyers)
                {
                    wr.WriteLine(b.Contacts);
                    wr.WriteLine(b.FinancialOpp);
                    wr.WriteLine(b.MaksSpeedRequired);
                    wr.WriteLine(b.ModelRequired);
                    wr.WriteLine(b.Name);
                    wr.WriteLine(b.Password);
                    wr.WriteLine(b.PerfomanceRequired);
                }
            }
        }

        private void SaveReports()
        {
            using (var wr = new StreamWriter(REPORTS))
            {
                wr.WriteLine(carShowroom.Reports.Count);
                foreach (var o in carShowroom.Reports)
                {
                    wr.WriteLine(o.Buyer.Name);
                    wr.WriteLine(o.DateTime);
                    wr.WriteLine(o.Cars_R.Count);
                    foreach (var p in o.Cars_R)
                    {
                        wr.WriteLine(p.Features);
                        wr.WriteLine(p.ID);
                        wr.WriteLine(p.MaksSpeed);
                        wr.WriteLine(p.Model);
                        wr.WriteLine(p.Price);
                        wr.WriteLine(p.ProdCountry);
                        wr.WriteLine(p.TechState);
                        wr.WriteLine(p.YearOfIssue);
                    }
                }
            }
        }


        //==================================================================================================

        public void Load()
        {
            LoadCars();
            LoadBuyers();
            LoadReports();
        }

        private void LoadCars()
        {
            using (var rd = new StreamReader(CARS))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                carShowroom.Cars.Clear();
                for (int i = 0; i < n; i++)
                {
                    carShowroom.Cars.Add(new Car
                    {
                        Features = rd.ReadLine(),
                        ID = Convert.ToInt32(rd.ReadLine()),
                        MaksSpeed = Convert.ToInt32(rd.ReadLine()),
                        Model = rd.ReadLine(),
                        Price = Convert.ToInt32(rd.ReadLine()),
                        ProdCountry = rd.ReadLine(),
                        TechState = Convert.ToInt32(rd.ReadLine()),
                        YearOfIssue = Convert.ToInt32(rd.ReadLine())
                    });
                }
            }
        }

        private void LoadBuyers()
        {
            using (var rd = new StreamReader(BUYERS))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                carShowroom.Buyers.Clear();
                for (int i = 0; i < n; i++)
                {
                    carShowroom.Buyers.Add(new Buyer
                    {
                        Contacts = rd.ReadLine(),
                        FinancialOpp = Convert.ToInt32(rd.ReadLine()),
                        MaksSpeedRequired = Convert.ToInt32(rd.ReadLine()),
                        ModelRequired = rd.ReadLine(),
                        Name = rd.ReadLine(),
                        Password = rd.ReadLine(),
                        PerfomanceRequired = Convert.ToInt32(rd.ReadLine()),
                    });
                }
            }
        }

        private void LoadReports()
        {
            using (var rd = new StreamReader(REPORTS))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                carShowroom.Reports.Clear();
                for (int i = 0; i < n; i++)
                {
                    var name = rd.ReadLine();
                    var time = Convert.ToDateTime(rd.ReadLine());
                    var ps = ReadReports(rd);
                    carShowroom.Reports.Add(new Report(ps, GetBuyerByName(name), time));

                }
            }
        }

        private Buyer GetBuyerByName(string name) => carShowroom.Buyers.Single(b => b.Name == name);

        private List<Car> ReadReports(StreamReader rd)
        {
            int n = Convert.ToInt32(rd.ReadLine());
            var ps = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                ps.Add(new Car
                {
                    Features = rd.ReadLine(),
                    ID = Convert.ToInt32(rd.ReadLine()),
                    MaksSpeed = Convert.ToInt32(rd.ReadLine()),
                    Model = rd.ReadLine(),
                    Price = Convert.ToInt32(rd.ReadLine()),
                    ProdCountry = rd.ReadLine(),
                    TechState = Convert.ToInt32(rd.ReadLine()),
                    YearOfIssue = Convert.ToInt32(rd.ReadLine())
                });
            }
            return ps;
        }

        private Car GetCarById(int carId) => carShowroom.Cars.Single(p => p.ID == carId);
    }
}
