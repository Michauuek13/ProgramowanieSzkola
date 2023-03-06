using System;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                double firstNumber, secondNumber, divNumber;
                Console.WriteLine("Podaj pierwsza liczbe");
                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj druga liczbe");
                secondNumber = int.Parse(Console.ReadLine());

                divNumber = firstNumber / secondNumber;

                Console.WriteLine("Wynik dzielenia " + divNumber);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
