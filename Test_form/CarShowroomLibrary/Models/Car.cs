using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_form.Models
{
    [Serializable]
    //Автомобиль - цена марка, страна-производитель, год выпуска, техн. состояние, 
    //техн.характеристики, особенности автомобиля.
    public class Car
    {
        public int Price { set; get; }
        public string Model { set; get; }
        public int ID { set; get; }
        public string ProdCountry { set; get; }
        public int YearOfIssue { set; get; }
        public int TechState { set; get; }
        public int MaksSpeed { set; get; }
        public string Features { set; get; }
    }
}
