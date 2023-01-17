using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class ZadaniaFor
    {
        public void NaturalNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + ", ");
            }
        }

        public void Sum100()
        {
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine("Suma wynosi" + sum);
        }

        public void squaresOfNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = i * i;

                Console.Write(result + ", ");
            }
        }

        public void lineOfNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                int result = 1;
                for (int j = 1; j <= i; j++)
                {
                    result *= j;
                }
                Console.Write(result + ", ");
            }
        }

        public void multiplicationTable()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i + "x" + j + "=" + i * j + " ");
                }

            }
        }

        public void subordinateBy3()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.Write(i + ", ");
            }
        }

        public void sumOfSquares()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;
                sum += square;
            }
            Console.WriteLine("Suma kwadratow wynosi: " + sum);
        }

        public void fibonacioSequence()
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < 20; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

                Console.Write(a + ", ");
            }
        }

        public void squareOf2()
        {
            for (int i = 0; i <= 10; i++)
            {
                int power = (int)Math.Pow(2, i);

                Console.Write(power + ", ");
            }
        }
    }
}
