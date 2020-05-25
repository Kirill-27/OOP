using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_form.Models
{
    [Serializable]
    //Покупатель - имя, пароль, контакты, требования к марке,
    //требования к техническому состоянию, требования к характеристикам, финансовые возможности.
    public class Buyer : User
    {
        public string Contacts { set; get; }
        public string ModelRequired { set; get; }
        public int PerfomanceRequired { set; get; }
        public int MaksSpeedRequired { set; get; }
        public int FinancialOpp { set; get; }

        public void FindCar()
        {
            
        }
    }
}
