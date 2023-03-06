using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmApp
{
    class Animals
    {
        public virtual void ShowInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Obiekt klasy Animal");
            
            Console.WriteLine("-----------------------");
        }
    }
}
