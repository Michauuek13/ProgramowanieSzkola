using System;

namespace FirstCszarp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number = 13;

            Console.WriteLine(number);
            Console.WriteLine("Wartość zmiennej " + number);
            Console.WriteLine($"Wartość zmiennej {number}");
            Console.WriteLine("Predkość km\\h");

            if (number == 5)
                Console.WriteLine("Rowna");
            else
                Console.WriteLine("nie rowne");
        }
    }
}
