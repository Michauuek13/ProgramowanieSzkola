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

        public void PESEL()
        {
            Console.WriteLine("Podaj numer pesel");
            string pesel = Console.ReadLine();
            
            if(pesel.Length !=11)
            {
                Console.WriteLine("NUmer pesel powinien miec 11 cyfr");
                return;
            }

            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2, 2));
            int day = int.Parse(pesel.Substring(4, 2));
            int sex = int.Parse(pesel.Substring(9, 1));

            if(sex %2 == 1)
            {
                Console.WriteLine("Płeć mężczyzna");
            }
            else
            {
                Console.WriteLine("Płeć kobieta");
            }
            
            if(month > 80 && month <=92)
            {
                year += 1800;
                month -= 80;
            }
            else if (month > 0 && month <= 12)
            {
                year += 1900;
            }
            else if(month > 20 && month <= 32)
            {
                year += 2000;
                month -= 20;
            }
            else if(month > 40 && month <= 52)
            {
                year += 2100;
                month -= 40;
            }
            else if( month > 60 && month <= 72)
            {
                year += 2200;
                month -= 60;
            }

            Console.WriteLine("Data urodzenia:" + year + "-"+ month + "-" + day);
        }
    }           
}
