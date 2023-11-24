


#include <iostream>
#include <string>
using namespace std;

/*
* Napisz program, który poprosi u¿ytkownika o wprowadzenie dowolnej liczby ca³kowitej.Nastêpnie program powinien obliczyæ i wyœwietliæ liczbê cyfr w tej liczbie.
* Program sprawdzaj¹cy czy podana liczba jest liczb¹ doskona³¹(czyli tak¹, której suma dzielników(z wy³¹czeniem samej siebie) jest równa danej liczbie, np. 6 jest liczb¹ doskona³¹, poniewa¿ 1 + 2 + 3 = 6).
* Poproœ u¿ytkownika o wprowadzenie liczby ca³kowitej.Nastêpnie oblicz sumê wszystkich cyfr w tej liczbie i wyœwietl wynik.
* Program wyœwietlaj¹cy na ekranie wszystkie liczby podzielne przez 3 z zakresu od 1 do 100
* Poproœ u¿ytkownika o wprowadzenie liczby ca³kowitej w systemie dziesiêtnym.Nastêpnie u¿ywaj¹c pêtli do - while, skonwertuj tê liczbê na system dwójkowy(binarny) i wyœwietl wynik.
*/

void LiczbaCyfr()
{
	cout << "Wprowadz liczbe calkowita\n";
	string number;
	cin >> number;
	int liczbacyfr = number.length();
	cout << "\nLiczba cyfr w tej liczbie: " << liczbacyfr;
}

void LiczbaDoskonala()
{
	cout << "Podaj liczbe";
	int liczba;
	cin >> liczba;
	
}

void SumaCyfr()
{
	cout << "Wprowadz liczbe calkowita\n";
	string number;
	cin >> number;
	int liczbacyfr = number.length();
}

int main()
{
	cout << "1.Liczba cyfr\n";

    int choice;
    cin >> choice;
	system("CLS");
	switch (choice)
	{
	case(1):
		LiczbaCyfr();
		break;

	default:
		cin >> choice;
		break;
	}
}