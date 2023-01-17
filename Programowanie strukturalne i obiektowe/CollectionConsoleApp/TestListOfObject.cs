using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListOfObject
    {
        public void Test()
        {
            List<Person> listOfPeople = new List<Person>();
            Person person = new Person("Jan", "Kowalski", 40, 100);
            listOfPeople.Add(person);

            listOfPeople.Add(new Person("Ewa", "Nowak", 69, 120));
            listOfPeople.Add(new Person("Kuba", "Bugaj", 43, 169));
            listOfPeople.Add(new Person("Filip", "Frejlik", 20, 180));

            foreach(Person p in listOfPeople)
            {
                p.Info();
            }
            Console.WriteLine();
            List<Person> listOfPegi18;

            listOfPegi18 = listOfPeople.Where(x => x.age >= 18).ToList();
            Console.WriteLine("Lista osob pegi 18");
            foreach(Person p in listOfPegi18)
            {
                p.Info();
            }
            Console.WriteLine();

            List<Person> sortedListByAge = listOfPeople.OrderByDescending(x => x.age).ThenBy(x => x.height).ToList();
            Console.WriteLine("Po wzroscie");
            foreach( Person p in sortedListByAge)
            {
                p.Info();
            }
            Console.WriteLine();

            List<Person> sortedListByName = listOfPeople.OrderBy(x => x.name).ToList();
            Console.WriteLine("Wedlug imienia");
            foreach(Person p in sortedListByAge)
            {
                p.Info();
            }
            Console.WriteLine();

            int age = listOfPeople.Min(x => x.age);
            Console.WriteLine("Najmlodsza " + age);

        }
    }
}
