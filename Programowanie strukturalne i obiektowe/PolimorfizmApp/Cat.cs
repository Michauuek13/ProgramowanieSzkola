using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmApp
{
    class Cat: Animals
    {
        private string name;

        public Cat(string catName)
        {
            name = catName;
        }

        public void Meow()
        {
            Console.WriteLine($"Kot o imieniu {name} miałczy.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Obiekt klasy cat");
            Console.WriteLine($"Kot o imieniu {name}");
            Console.WriteLine("-----------------------");
        }
    }
}
