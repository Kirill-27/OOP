using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomLibrary.Models
{
    [Serializable]
    //клас пользователь, объеденяющий свойства админа и покупателя
    public abstract class User
    {
        public string Name { set; get; }
        public string Password { set; get; }
    }
}
