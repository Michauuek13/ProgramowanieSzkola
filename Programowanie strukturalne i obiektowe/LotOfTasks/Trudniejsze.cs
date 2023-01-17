using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Trudniejsze
    {
        public void Nwd()
        {
            Console.WriteLine("Podaj liczbe");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe2");
            int number2 = int.Parse(Console.ReadLine());

            while(number2 != 0)
            {
                int temp = number2;
                number2 = number1 % number2;
                number1 = temp;
            }
            Console.WriteLine("Najwiekszy wspolny dzielnik wynosi: "+ number1);
        }

        public void Nww()
        {
            
        }
    }
}
