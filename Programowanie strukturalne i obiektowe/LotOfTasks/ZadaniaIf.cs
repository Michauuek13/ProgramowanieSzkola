using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class ZadaniaIf
    {
        public void evenNumber()
        {
            Console.WriteLine("Podaj liczbe: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("Liczba jest parzysta");
            else
                Console.WriteLine("Liczba jest nie parzysta");
        }

        public void PostiveNegativeZero()
        {
            Console.WriteLine("Podaj liczbe: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
                Console.WriteLine("Liczba jest dodatnia");
            if (number < 0)
                Console.WriteLine("Liczba jest ujemna");
            if (number == 0)
                Console.WriteLine("Liczba jest rowna 0");
        }

        public void leapYear()
        {
            Console.WriteLine("Podaj rok: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeapYear = false;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }

            if (isLeapYear == true)
            {
                Console.WriteLine("Rok jest przestepny");
            }
            else
            {
                Console.WriteLine("Rok jest nieprzestepny");
            }
        }

        public void MarkInfo()
        {
            Console.WriteLine("Podaj ocene od 1-6");
            int mark = int.Parse(Console.ReadLine());

            switch (mark)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczajacy");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujacy");
                    break;
            }
        }

        public void Password()
        {
            Console.WriteLine("Wprowadz hasło");
            string password = "abc123";
            string input = Console.ReadLine();
            if (password == input)
                Console.WriteLine("Hasło poprawne");
            else
                Console.WriteLine("Haslo niepoprawne");
        }

        public void dateCheck()
        {
            Console.WriteLine("Wprowadz date RRRR-MM-DD");
            string input = (Console.ReadLine());

            if(DateTime.TryParse(input, out DateTime date))
            {
                if(date.Year >= 1 && date.Year <= 9999 && date.Month >= 1 && date.Month <= 12 && date.Day >=1 && date.Day <= DateTime.DaysInMonth(date.Year, date.Month))
                {
                    Console.WriteLine("Data jest poprawna");
                }
            }
            else
            {
                Console.WriteLine("Data jest niepoprawna");
            }
        }

        public void Temperature()
        {
            Console.WriteLine("Podaj temperature");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature >= 20)
                Console.WriteLine("Jest ciepło");
            else
                Console.WriteLine("Jest zimno");
        }
    }
}
