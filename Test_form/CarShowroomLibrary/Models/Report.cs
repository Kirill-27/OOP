using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_form.Models
{
    [Serializable]
    // класс отчет содерждит ,
    public class Report
    {
        public Report(List<Car> cars, Buyer buyer, DateTime? t = null)
        {
            Cars_R = cars;
            Buyer = buyer;
            if (t == null)
                DateTime = DateTime.Now;
            else
                DateTime = (DateTime)t;
        }

        public List<Car> Cars_R { private set; get; }
        public Buyer Buyer { private set; get; }
        public DateTime DateTime { private set; get; }
    }
}
