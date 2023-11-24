using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryConsoleApp
{
    internal class Point
    {
        private int x, y;

        public int Y
        {
            get 
            { return y; }
            set 
            {
                if (value > 0)
                    y = value;
                else
                    throw new ArgumentException("Nie mozna ustawic wartosci ujemnych");
            }
        }

        public double DistanceFromCenter
        {
            get
            {
                return Math.Sqrt(x*x + y*y); 
            }
        }

        public void Display()
        {
            Console.WriteLine(x.ToString() + ", " + y.ToString());
        }

        public void SetX(int a)
        {
            if(a>0)
            {
                x = a;
            }
        }

        public int GetX()
        { 
        return x; 
        }
    }
}
