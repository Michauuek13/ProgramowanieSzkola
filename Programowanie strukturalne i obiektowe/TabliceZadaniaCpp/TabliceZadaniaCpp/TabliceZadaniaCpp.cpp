


#include <iostream>
#include <math.h>
using namespace std;

/*
Zadania:
* Napisz funkcjê, która dla kolekcji danych liczbowych obliczy œredni¹ arytmetyczn¹.
* Napisz funkcjê, która dla kolekcji danych liczbowych policzy ile jest liczb wiêkszych od œredniej arytmetycznej.
* Napisz funkcje, która dla kolekcji danych liczbowych przeniesie te liczby do innej kolekcji w odwrotnej kolejnoœci.
* Napisz funkcje, która dla kolekcji danych liczbowych obliczy czêstotliwoœæ wystêpowania danej liczby.
* Napisz funkcjê, która dla kolekcji danych liczbowych znajdzie najd³u¿szy rosn¹cy podci¹g.
* Napisz funkcjê, która dla kolekcji danych liczbowych przeniesie te liczby do osobnych kolekcji liczb parzystych i nieparzystych.
*
*/


/*
Napisz funkcjê w której wczytamy 5 liczb i wyœwietlimy je w odwrotnej kolejnoœci.
 */
void Zadanie1()
{
	int liczba0, liczba1, liczba2, liczba3, liczba4;
	std::cout << "Podaj 0 liczbe:\n";
	std::cin >> liczba0;
	std::cout << "Podaj 1 liczbe:\n";
	std::cin >> liczba1;
	std::cout << "Podaj 2 liczbe:\n";
	std::cin >> liczba2;
	std::cout << "Podaj 3 liczbe:\n";
	std::cin >> liczba3;
	std::cout << "Podaj 4 liczbe:\n";
	std::cin >> liczba4;

	std::cout << liczba4 << ", ";
	std::cout << liczba3 << ", ";
	std::cout << liczba2 << ", ";
	std::cout << liczba1 << ", ";
	std::cout << liczba0;
}

void Zadanie2()
{
	int liczby[5];
	std::cout << "Podaj 0 liczbe:\n";
	std::cin >> liczby[0];
	std::cout << "Podaj 1 liczbe:\n";
	std::cin >> liczby[1];
	std::cout << "Podaj 2 liczbe:\n";
	std::cin >> liczby[2];
	std::cout << "Podaj 3 liczbe:\n";
	std::cin >> liczby[3];
	std::cout << "Podaj 4 liczbe:\n";
	std::cin >> liczby[4];

	std::cout << liczby[4] << ", ";
	std::cout << liczby[3] << ", ";
	std::cout << liczby[2] << ", ";
	std::cout << liczby[1] << ", ";
	std::cout << liczby[0] << ", ";
}

void Zadanie3()
{
	const int rozmiar = 5;
	int liczby[rozmiar];
	std::cout << "Podaj 0 liczbe:\n";
	std::cin >> liczby[0];
	std::cout << "Podaj 1 liczbe:\n";
	std::cin >> liczby[1];
	std::cout << "Podaj 2 liczbe:\n";
	std::cin >> liczby[2];
	std::cout << "Podaj 3 liczbe:\n";
	std::cin >> liczby[3];
	std::cout << "Podaj 4 liczbe:\n";
	std::cin >> liczby[4];

	for (int i = rozmiar - 1; i >= 0; i--)
		std::cout << liczby[i] << ", ";
}

void Zadanie4()
{
	const int rozmiar = 5;
	int liczby[rozmiar];

	for (int i = 0; i < rozmiar; i++)
	{
		std::cout << "Podaj " << i << " liczbe:\n";
		std::cin >> liczby[i];
	}

	for (int i = rozmiar - 1; i >= 0; i--)
	{
		std::cout << liczby[i] << ", ";
	}
}

/*
 Napisz program, który uzupe³ni tablicê liczbami pseudolosowymi,
 wyswietli jej zawartoœæ oraz znajdzie wartoœæ najwieksz¹.
 */

void Zadanie5()
{
	const int ROZMIAR_TABLICY = 5;
	int tablicaLiczb[ROZMIAR_TABLICY];

	srand(time(NULL));

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		//zakres <0; 100>
		tablicaLiczb[i] = rand() % 101; // <0; RAND_MAX)
	}

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		std::cout << tablicaLiczb[i] << ", ";
	}
	std::cout << "\n";

	//szukanie maksymalnej
	int max = tablicaLiczb[0];
	for (int i = 1; i < ROZMIAR_TABLICY; i++)
	{
		if (tablicaLiczb[i] > max)
			max = tablicaLiczb[i];
	}
	std::cout << "Maksymalna liczba to " << max << "\n";
}

/*
 Napisz program, który dla kolekcji liczb policzy ile jest liczb parzystych.
 */

void Zadanie6()
{
	const int ROZMIAR_TABLICY = 5;
	int tablicaLiczb[ROZMIAR_TABLICY];

	int zakresDolny = 6;
	int zakresGorny = 10;

	srand(time(NULL));

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		//zakres <zakresDolny; zakresGorny>
		tablicaLiczb[i] = rand() % (zakresGorny - zakresDolny + 1) + zakresDolny;
	}

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		std::cout << tablicaLiczb[i] << ", ";
	}
	std::cout << "\n";

	//Tutaj umieszczamy algorytm dla zadania
	int licznik = 0;
	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		if (tablicaLiczb[i] % 2 == 0)
			//if (tablicaLiczb[i] > 0) // czy liczba jest dodatnia
			licznik++;
	}
	std::cout << "Ilosc liczb parzystych to: " << licznik << "\n";
}

/*
  Napisz program, który dla kolekcji liczb policzy srednia artymetyczna tych liczb
 */

void Zadanie7()
{
	const int ROZMIAR_TABLICY = 6;
	int tablicaLiczb[ROZMIAR_TABLICY];

	int zakresDolny = 6;
	int zakresGorny = 10;

	srand(time(NULL));

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		//zakres <zakresDolny; zakresGorny>
		tablicaLiczb[i] = rand() % (zakresGorny - zakresDolny + 1) + zakresDolny;
	}

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		std::cout << tablicaLiczb[i] << ", ";
	}
	std::cout << "\n";

	//Tutaj umieszczamy algorytm dla zadania
	int suma = 0;
	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		suma = suma + tablicaLiczb[i];
	}
	float srednia = (suma * 1.0) / ROZMIAR_TABLICY;
	std::cout << "Srednia arytmetyczna to: " << srednia << "\n";
}

/*
 Napisz funkcjê, która posortuje rosn¹co liczby w tablicy.
 */

void Zadanie8()
{
	const int ROZMIAR_TABLICY = 5;
	int tablicaLiczb[ROZMIAR_TABLICY];

	int zakresDolny = 6;
	int zakresGorny = 10;

	srand(time(NULL));

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		//zakres <zakresDolny; zakresGorny>
		tablicaLiczb[i] = rand() % (zakresGorny - zakresDolny + 1) + zakresDolny;
	}

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		std::cout << tablicaLiczb[i] << ", ";
	}
	std::cout << "\n";

	//Tutaj umieszczamy algorytm dla zadania

	//sortowanie b¹belkowe

	for (int i = 0; i < ROZMIAR_TABLICY - 1; i++)
	{
		for (int j = 0; j < ROZMIAR_TABLICY - 1; j++)
		{
			if (tablicaLiczb[j] > tablicaLiczb[j + 1])
			{
				int tmp = tablicaLiczb[j];
				tablicaLiczb[j] = tablicaLiczb[j + 1];
				tablicaLiczb[j + 1] = tmp;
			}
		}
	}

	std::cout << "Kolekcja po posotrowaniu:\n";
	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		std::cout << tablicaLiczb[i] << ", ";
	}
	std::cout << "\n";

}

/*
 Zadanie 25
Napisz program który pobiera ci¹g liczb jednocyfrowych od u¿ytkownika (0 koñczy ci¹g)
a nastêpnie wyœwietla statystyki ile razy wyst¹pi³a dana liczba.
 */

void Zadanie25()
{
	int liczbaUzytkownika;
	int statystykaTablica[10];

	for (int i = 0; i < 10; i++)
		statystykaTablica[i] = 0;

	do
	{
		std::cout << "Podaj liczbe:\n";
		std::cin >> liczbaUzytkownika;
		if (liczbaUzytkownika >= 0 && liczbaUzytkownika <= 9)
		{
			statystykaTablica[liczbaUzytkownika]++;
		}
		else
		{
			if (liczbaUzytkownika < 0)
				liczbaUzytkownika = -liczbaUzytkownika;
			int reszta;
			int liczba = liczbaUzytkownika;
			do
			{
				reszta = liczba % 10;
				statystykaTablica[reszta]++;
				liczba = liczba / 10;
			} while (liczba != 0);
		}

	} while (liczbaUzytkownika != 0);
	std::cout << "Statystyka:\n";
	for (int i = 0; i < 10; i++)
		std::cout << "Liczb " << i << " podano " << statystykaTablica[i] << "\n";
}

/*
 Napisz funkcjê, która pobierze od uzytkownika liczbê
 i sprawdzi czy jest on pierwsza.
 */

void Zadanie26()
{
	int liczbaUzytkownika;
	std::cout << "Podaj liczbe:\n";
	std::cin >> liczbaUzytkownika;

	bool jestPierwsza = true;
	// <2 ; liczbaUzytkowanika-1>
	// <2; pierwiastekKwadratowy(liczbaUzytkownika)>
	for (int i = 2; i <= sqrt(liczbaUzytkownika); i++)
	{
		if (liczbaUzytkownika % i == 0)
		{
			jestPierwsza = false;
			break;
		}
	}

	if (jestPierwsza == true)
		std::cout << "Liczba " << liczbaUzytkownika << " jest pierwsza\n";
	else
		std::cout << "Liczba " << liczbaUzytkownika << " nie jest pierwsza\n";
}

/*
Napisz funkcjê która wyœwitli wszystkie liczby pierwsze
z zakresu podanego przez u¿ytkownika
*/

void Zadanie27()
{
	int zakresGorny;
	std::cout << "Podaj zakres gorny:\n";
	std::cin >> zakresGorny;

	for (int i = 2; i <= zakresGorny; i++)
	{
		bool jestPierwsza = true;
		for (int j = 2; j <= sqrt(i); j++)
		{
			if (i % j == 0)
			{
				jestPierwsza = false;
				break;
			}
		}

		if (jestPierwsza)
			std::cout << i << ", ";
	}
}

/*
Napisz funkcjê, która wyznaczy liczby pierwsze
za pomoc¹ algorytmu sita Eratostenesa
*/

void Zadanie28()
{
	int zakresGorny;
	std::cout << "Podaj zakres gorny:\n";
	std::cin >> zakresGorny;

	bool jestPierwsza[200];
	for (int i = 0; i < 200; i++)
		jestPierwsza[i] = true;

	double wynikPierwiastka = sqrt(zakresGorny);
	for (int i = 2; i < wynikPierwiastka; i++)
	{
		//if (liczba i nie jest wykreœlona)
		if (jestPierwsza[i] == true)
		{
			//nalezy wykreœliæ wszystkie jej wielokrotnoœci
			for (int j = i + i; j < zakresGorny; j = j + i)
			{
				jestPierwsza[j] = false;
			}
		}
	}

	for (int i = 2; i < zakresGorny; i++)
		if (jestPierwsza[i])
			std::cout << i << ", ";

}



void Szablon()
{
	const int ROZMIAR_TABLICY = 5;
	int tablicaLiczb[ROZMIAR_TABLICY];

	int zakresDolny = 6;
	int zakresGorny = 10;

	srand(time(NULL));

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		//zakres <zakresDolny; zakresGorny>
		tablicaLiczb[i] = rand() % (zakresGorny - zakresDolny + 1) + zakresDolny;
	}

	for (int i = 0; i < ROZMIAR_TABLICY; i++)
	{
		std::cout << tablicaLiczb[i] << ", ";
	}
	std::cout << "\n";

	//Tutaj umieszczamy algorytm dla zadania
}

void Srednia()
{
	const int rozmiar = 5;
	int liczby[rozmiar];

	for (int i = 0; i < rozmiar; i++)
	{
		std::cout << "Podaj " << i << " liczbe:\n";
		std::cin >> liczby[i];
	}
	
	int suma = 0;
	int srednia;
	for (int i = 0; i < rozmiar; i++)
	{
		suma = liczby[i] + suma;
	}
	srednia = suma / rozmiar;
	cout << "Srednia wynosi: " << srednia;
}

void WiekszeNizSrednia()
{
	const int rozmiar = 5;
	int liczby[rozmiar];

	for (int i = 0; i < rozmiar; i++)
	{
		std::cout << "Podaj " << i << " liczbe:\n";
		std::cin >> liczby[i];
	}

	int suma = 0;
	int srednia;
	for (int i = 0; i < rozmiar; i++)
	{
		suma = liczby[i] + suma;
	}
	srednia = suma / rozmiar;
	cout << "Srednia wynosi: " << srednia << "\n";

	cout << "Liczby wieksze od sredniej: ";
	for (int i = 0; i < rozmiar; i++)
	{
		if (liczby[i] > srednia)
		{
			cout << liczby[i] << " ";
		}
	}
}

void Odwrotnosc()
{
	const int rozmiar = 5;
	int liczby[rozmiar];

	for (int i = 0; i < rozmiar; i++)
	{
		std::cout << "Podaj " << i << " liczbe:\n";
		std::cin >> liczby[i];
	}

	int liczbyR[rozmiar];
		;
	for (int i = rozmiar - 1; i >= 0; i--)
	{
		std::cout << liczby[i] << ", ";
		
	}
}
  
void Czestotliwosc()
{
	const int rozmiar = 5;
	int liczby[rozmiar];
	liczby[0] = 1;
	liczby[1] = 1;
	liczby[2] = 2;
	liczby[3] = 2;
	liczby[4] = 2;

	int count = 0;
	for (int i = 0; i < rozmiar; i++)
	{	
		for (int j = 0; j < rozmiar; j++)
		{
			if (liczby[j++] == liczby[i])
			{
				count = count + 1;
				cout << "Liczba " << liczby[j] << " wystepuje " << count << " razy\n";
			}
		}
		
	}
}

void Podciag()
{
	const int rozmiar = 5;
	int liczby[rozmiar];
	liczby[0] = 1;
	liczby[1] = 2;
	liczby[2] = 1;
	liczby[3] = 2;
	liczby[4] = 3;

	int podciag = 0;
	int maxpodciag = 0;
	for (int i = 0; i < rozmiar; i++)
	{
		if (liczby[i] > (liczby[i-1]))
		{		
			podciag++;
			if (podciag > maxpodciag)
			{
				maxpodciag = podciag;
			}
			
		}
		else
			{
				podciag = 1;
			}
	}
	cout << "Najwyszy podciag jest do: " << podciag << "\n";
}

void ParzysteNieparzyste()
{
	const int rozmiar = 5;
	int liczby[rozmiar];
	liczby[0] = 1;
	liczby[1] = 2;
	liczby[2] = 3;
	liczby[3] = 6;
	liczby[4] = 7;

	int liczbyP[rozmiar];
	int liczbyN[rozmiar];
	int j = 0;
	int k = 0;
	for (int i = 0; i < rozmiar; i++)
	{
		if (liczby[i] % 2 == 0)
		{
			liczbyP[j] = liczby[i];
			j++;
		}
		else
		{
			liczbyN[k] = liczby[i];
			k++;
		}
	}
	cout << "Liczby parzyste: ";
	for (int i = 0; i < j; i++)
	{
		cout << liczbyP[i] << ", ";
	}
	cout << "\n";
	cout << "Liczby nieparzyste: ";
	for (int i = 0; i <  k; i++)
	{
		cout << liczbyN[i] << ", ";
	}
}

int main()
{
	cout << "1.Srednia\n";
	cout << "2.Wieksza niz srednia\n";
	cout << "3.Dowrotna Kolejnosc\n";
	cout << "4.Czestotliwosc\n";
	cout << "5.Podciag\n";
	cout << "6.ParzysteNieparzyste\n";
	int wybor;
	cin >> wybor;
	system("CLS");
	switch (wybor)
	{
	case(1):
		Srednia();
		break;
	case(2):
		WiekszeNizSrednia();
		break;
	case(3):
		Odwrotnosc();
		break;
	case(4):
		Czestotliwosc();
		break;
	case(5):
		Podciag();
		break;
	case(6):
		ParzysteNieparzyste();
		break;
	}
	
}