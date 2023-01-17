using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class Zadania
    {
        public void Srednia()
        {
            Console.WriteLine("Podaj liczbe1: ");
            double number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe2: ");
            double number2 = double.Parse(Console.ReadLine());

            double averange = (number1 + number2) / 2;

            Console.WriteLine("Srednia arytmetyczna wynosi " + averange);

        }

        public void RectangleArea()
        {
            Console.WriteLine("Podaj dlugosc boku a: ");
            int sideA = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dlugosc boku b: ");
            int sideB = int.Parse(Console.ReadLine());

            int Area = sideA * sideB;

            Console.WriteLine("Pole prostokąta wynosi: " + Area);
        }

        public void coneVolume()
        {
            Console.WriteLine("Podaj promien podstawy: ");
            int podstawa = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokosc: ");
            int height = int.Parse(Console.ReadLine());

            double volume = (1.0 / 3.0) * Math.PI * podstawa * podstawa * height;
            Console.WriteLine("Objetosc stożka wynosi: " + volume);
        }

        public void CircleArea()
        {
            Console.WriteLine("Podaj promien: ");
            int r = int.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            Console.WriteLine("Pole koła wynosi: " + area);
        }

        public void mathExpression()
        {
            Console.WriteLine("Podaj a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            double b = double.Parse(Console.ReadLine());

            double result = a * a * b * b;
            Console.WriteLine("Wynik " + result);
        }

        public void TriangleArea()
        {
            Console.WriteLine("Podaj podstawe: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokosc: ");
            double h = double.Parse(Console.ReadLine());

            double TriangleArea = b * h / 2;
            Console.WriteLine("Pole wynosi: " + TriangleArea);
        }

        public void GlobeArea()
        {
            Console.WriteLine("Podaj promien: ");
            double r = double.Parse(Console.ReadLine());

            double area = (4.0 / 3.0) * Math.PI * r * r * r;
            Console.WriteLine("Objetosc wynosi" + area);
        }

        public void TrapezeArea()
        {
            Console.WriteLine("Podaj bok a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj bok b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokosc: ");
            double h = double.Parse(Console.ReadLine());

            double area = (a + b) * h / 2;
            Console.WriteLine("Pole trapezu wynosi: " + area);
        }

        public void WeightedAverage()
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wage pierwszej liczby: ");
            double weight1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wage drugiej liczby: ");
            double weight2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecia liczbe: ");
            double number3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wage trzeciej liczby: ");
            double weight3 = double.Parse(Console.ReadLine());

            double averange = (number1 * weight1 + number2 * weight2 + number3 * weight3) / (weight1 + weight2 + weight3);

            Console.WriteLine("Srednia wazona wynosi: " + averange);
        }
    }
}
