using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomLibrary.Models
{
    // Класс для реализации заявок для поставщиков содержит кол-во авто в данный позиции
    // модель, страну-производитель, год выпвуска, техническое состояние.
    public class CarInApplic
    {
        public int Amount { set; get; }
        public string Model { set; get; }
        public string ProdCountry { set; get; }
        public int YearOfIssue { set; get; }
        public int TechState { set; get; }
    }
}
