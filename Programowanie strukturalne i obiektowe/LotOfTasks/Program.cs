using System;

namespace LotOfTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadania zadania = new Zadania();
            ZadaniaIf zadaniaIf = new ZadaniaIf();
            ZadaniePetle zadaniePetle = new ZadaniePetle();
            ZadaniaFor zadaniaFor = new ZadaniaFor();
            ZadaniaDoWhile zadaniaDoWhile = new ZadaniaDoWhile();
            Trudniejsze trudniejsze = new Trudniejsze();

            Console.WriteLine("1.Podstawy programowania");
            Console.WriteLine("2.Instrukcja If");
            Console.WriteLine("3.Pętle");
            Console.WriteLine("4.Pętla for");
            Console.WriteLine("5.Petla Do-while");
            Console.WriteLine("6.Trudniejsze");
            Console.WriteLine("Podaj numer dzialu");
            int choose1 = int.Parse(Console.ReadLine());
            if (choose1 == 1)
            {
                Console.WriteLine("Podaj numer zadania: ");
                Console.WriteLine("1. Program obliczający średnią arytmetyczną dwóch liczb.");
                int choose2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choose2)
                {
                    case 1:
                        zadania.Srednia();
                        break;

                    case 2:
                        zadania.RectangleArea();
                        break;

                    case 3:
                        zadania.coneVolume();
                        break;

                    case 4:
                        zadania.CircleArea();
                        break;

                    case 5:
                        zadania.mathExpression();
                        break;

                    case 6:
                        zadania.TriangleArea();
                        break;
                    case 7:
                        zadania.GlobeArea();
                        break;
                    case 8:
                        zadania.TrapezeArea();
                        break;
                    case 9:
                        zadania.WeightedAverage();
                        break;
                }
            }
            if (choose1 == 2)
            {
                Console.Clear();
                Console.WriteLine("Podaj numer zadania: ");
                int choose2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choose2)
                {
                    case 1:
                        zadaniaIf.evenNumber();
                        break;
                    case 2:
                        zadaniaIf.PostiveNegativeZero();
                        break;
                    case 3:
                        zadaniaIf.leapYear();
                        break;
                    case 4:
                        zadaniaIf.MarkInfo();
                        break;
                    case 5:
                        zadaniaIf.Password();
                        break;
                    case 6:
                        zadaniaIf.dateCheck();
                        break;
                    case 7:
                        zadaniaIf.Temperature();
                        break;
                }
            }

            if (choose1 == 3)
            {
                Console.Clear();
                Console.WriteLine("Podaj numer zadania: ");
                int choose2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choose2)
                {
                    case 1:
                        zadaniePetle.IsPrimeNumber();
                        break;
                    case 2:
                        zadaniePetle.IsPalindrome();
                        break;
                    case 3:
                        zadaniePetle.isAnagram();
                        break;
                    case 4:
                        zadaniePetle.idealNumber();
                        break;

                }
            }

            if (choose1 == 4)
            {
                Console.Clear();
                Console.WriteLine("Podaj numer zadania: ");
                int choose2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choose2)
                {
                    case 1:
                        zadaniaFor.NaturalNumbers();
                        break;
                    case 2:
                        zadaniaFor.Sum100();
                        break;
                    case 3:
                        zadaniaFor.squaresOfNumbers();
                        break;
                    case 4:
                        zadaniaFor.lineOfNumbers();
                        break;
                    case 5:
                        zadaniaFor.multiplicationTable();
                        break;
                    case 6:
                        zadaniaFor.subordinateBy3();
                        break;
                    case 7:
                        zadaniaFor.sumOfSquares();
                        break;
                    case 8:
                        zadaniaFor.fibonacioSequence();
                        break;
                    case 9:
                        zadaniaFor.squareOf2();
                        break;
                }
            }

            if (choose1 == 5)
            {
                Console.Clear();
                Console.WriteLine("Podaj numer zadania: ");
                int choose2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choose2)
                {
                    case 1:
                        zadaniaDoWhile.Password();
                        break;
                    case 2:
                        zadaniaDoWhile.squareSum();
                        break;
                }
            }

            if (choose1 == 6)
            {
                Console.Clear();
                Console.WriteLine("Podaj numer zadania: ");
                int choose2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch(choose2)
                {
                    case 1:
                        trudniejsze.Nwd();
                        break;
                    case 2:
                        trudniejsze.Nww();
                        break;
                }
            }
        }
    }
}