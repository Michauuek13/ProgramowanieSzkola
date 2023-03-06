using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetAge(120);

            int age = person.GetAge();
        }
    }
}
