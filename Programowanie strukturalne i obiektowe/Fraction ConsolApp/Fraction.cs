using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_ConsolApp
{
    public class Fraction
    {
        private int numerator;  //licznik
        private int denominator;    //miankownik

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                    denominator = value;
                else throw new ArgumentException("Nie mozna wstawic zero");
            }
        }

        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Fraction(int n, int d)
        {
            Numerator = n;
            Denominator = d;
        }

        public override string ToString()
        {
            return "\n" + numerator + "\n-\n" + denominator; 
        }

    }
}
