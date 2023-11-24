
using Fraction_ConsolApp;

Fraction firstFraction = new Fraction(5,8);

Console.WriteLine("Wartość pierwszego ułamka: " + firstFraction);

Fraction secondFraction = new Fraction(1,2);

Console.WriteLine("Wartośc drugiego ułamka: " + secondFraction);

Fraction thirdFraction = new Fraction();
thirdFraction.Numerator = firstFraction.Numerator * secondFraction.Numerator;
thirdFraction.Denominator = firstFraction.Denominator * secondFraction.Denominator;

Console.WriteLine("Wartosc mnozenia ułamka: " + thirdFraction);

Fraction fourthFraction = new Fraction();
fourthFraction.Numerator = firstFraction.Numerator * secondFraction.Denominator;
fourthFraction.Denominator = firstFraction.Denominator * secondFraction.Numerator;
Console.WriteLine("Wartosc dzielenia ułamka: " + fourthFraction);