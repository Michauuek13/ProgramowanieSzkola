


#include <iostream>
#include <string>
using namespace std;

/*
* Napisz program, kt�ry poprosi u�ytkownika o wprowadzenie dowolnej liczby ca�kowitej.Nast�pnie program powinien obliczy� i wy�wietli� liczb� cyfr w tej liczbie.
* Program sprawdzaj�cy czy podana liczba jest liczb� doskona��(czyli tak�, kt�rej suma dzielnik�w(z wy��czeniem samej siebie) jest r�wna danej liczbie, np. 6 jest liczb� doskona��, poniewa� 1 + 2 + 3 = 6).
* Popro� u�ytkownika o wprowadzenie liczby ca�kowitej.Nast�pnie oblicz sum� wszystkich cyfr w tej liczbie i wy�wietl wynik.
* Program wy�wietlaj�cy na ekranie wszystkie liczby podzielne przez 3 z zakresu od 1 do 100
* Popro� u�ytkownika o wprowadzenie liczby ca�kowitej w systemie dziesi�tnym.Nast�pnie u�ywaj�c p�tli do - while, skonwertuj t� liczb� na system dw�jkowy(binarny) i wy�wietl wynik.
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