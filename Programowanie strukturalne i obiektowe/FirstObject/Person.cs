using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstObject
{
    class Person
    {
        string name;
        string surename;
        int age;

        public Person()
        {
            name = "Jan";
            surename = "Nieznany";
            age = 21;

        }

        public Person(string name, string surename, int age)
        {
            this.name = name;
            this.surename = surename;
            this.age = age;

        }

        public void ShowInfo()
        {
            Console.WriteLine("Informacje o osobie");
            Console.WriteLine($"Imie {name}");
            Console.WriteLine($"Nazwisko {surename}");
            Console.WriteLine($"Wiek {age}");
        }
    }
}
