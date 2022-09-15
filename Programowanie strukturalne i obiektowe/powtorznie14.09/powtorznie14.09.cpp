
#include <iostream>
using namespace std;
#include <string>

void Zadanie1()
{
    cout << "Podaj liczbe\n";
    int liczba;
    cin >> liczba;
    if (liczba % 2 == 0)
    {
        cout << "Liczba jest parzysta";
    }
    else
    {
        while (liczba > 1)
        {
            liczba = liczba - 2;
            cout << liczba << ", ";
        }
    }

}

void Zadanie2()
{
    int dlugosc;
    int liczba;
    int liczba2;
    int liczba3;
    int dlugosc2;
    liczba = 0;
    liczba2 = 0;
    liczba3 = 1;
    cout << "Podaj dlugosc ciagu\n";
    cin >> dlugosc;

    for (int i = 0; i < dlugosc; i++)
    {
        liczba = liczba2 + liczba3;
        cout << liczba << ", ";
        liczba3 = liczba2;
        liczba2 = liczba;
    }
}

void Zadanie3()
{
    int liczba;
    cout << "Wprowadz liczbe\n";
    cin >> liczba;
    for (int i = 1; i <= liczba; i++)
    {
        if (liczba % i == 0)
            cout << i << ",";
    }
    cout << "\n";
}

void Zadanie4()
{
    std::string liczba;
    cout << "Wprowadz liczbe\n";
    
    std::getline(std::cin, liczba);
    std::cout << "Podales: " << liczba << "\n";
    
    //for (int i = 0; i < s; i++)
    int i = 0;

        if (liczba[i] == '1')
        {
            cout << "Jeden ";
        }
        if (liczba[i] == '2')
        {
            cout << "Dwa ";
        }
        if (liczba[i] == '3')
        {
            cout << "Trzy ";
        }
        if (liczba[i] == '4')
        {
            cout << "Cztery ";
        }
        if (liczba[i] == '5')
        {
            cout << "Piec ";
        }
        if (liczba[i] == '6')
        {
            cout << "Szesc ";
        }
        if (liczba[i] == '7')
        {
            cout << "Siedem ";
        }
        if (liczba[i] == '8')
        {
            cout << "Osiem ";
        }
        if (liczba[i] == '9')
        {
            cout << "Dziewiec ";
        }
        if (liczba[i] == '0')
        {
            cout << "Zero ";
        }
        i = 1;
        if (liczba[i] == '1')
        {
            cout << "Jeden ";
        }
        if (liczba[i] == '2')
        {
            cout << "Dwa ";
        }
        if (liczba[i] == '3')
        {
            cout << "Trzy ";
        }
        if (liczba[i] == '4')
        {
            cout << "Cztery ";
        }
        if (liczba[i] == '5')
        {
            cout << "Piec ";
        }
        if (liczba[i] == '6')
        {
            cout << "Szesc ";
        }
        if (liczba[i] == '7')
        {
            cout << "Siedem ";
        }
        if (liczba[i] == '8')
        {
            cout << "Osiem ";
        }
        if (liczba[i] == '9')
        {
            cout << "Dziewiec ";
        }
        if (liczba[i] == '0')
        {
            cout << "Zero ";
        }
        i = 2;
        if (liczba[i] == '1')
        {
            cout << "Jeden ";
        }
        if (liczba[i] == '2')
        {
            cout << "Dwa ";
        }
        if (liczba[i] == '3')
        {
            cout << "Trzy ";
        }
        if (liczba[i] == '4')
        {
            cout << "Cztery ";
        }
        if (liczba[i] == '5')
        {
            cout << "Piec ";
        }
        if (liczba[i] == '6')
        {
            cout << "Szesc ";
        }
        if (liczba[i] == '7')
        {
            cout << "Siedem ";
        }
        if (liczba[i] == '8')
        {
            cout << "Osiem ";
        }
        if (liczba[i] == '9')
        {
            cout << "Dziewiec ";
        }
        if (liczba[i] == '0')
        {
            cout << "Zero ";
        }
        i = 3;
        if (liczba[i] == '1')
        {
            cout << "Jeden ";
        }
        if (liczba[i] == '2')
        {
            cout << "Dwa ";
        }
        if (liczba[i] == '3')
        {
            cout << "Trzy ";
        }
        if (liczba[i] == '4')
        {
            cout << "Cztery ";
        }
        if (liczba[i] == '5')
        {
            cout << "Piec ";
        }
        if (liczba[i] == '6')
        {
            cout << "Szesc ";
        }
        if (liczba[i] == '7')
        {
            cout << "Siedem ";
        }
        if (liczba[i] == '8')
        {
            cout << "Osiem ";
        }
        if (liczba[i] == '9')
        {
            cout << "Dziewiec ";
        }
        if (liczba[i] == '0')
        {
            cout << "Zero ";
        }
        i = 4;
        if (liczba[i] == '1')
        {
            cout << "Jeden ";
        }
        if (liczba[i] == '2')
        {
            cout << "Dwa ";
        }
        if (liczba[i] == '3')
        {
            cout << "Trzy ";
        }
        if (liczba[i] == '4')
        {
            cout << "Cztery ";
        }
        if (liczba[i] == '5')
        {
            cout << "Piec ";
        }
        if (liczba[i] == '6')
        {
            cout << "Szesc ";
        }
        if (liczba[i] == '7')
        {
            cout << "Siedem ";
        }
        if (liczba[i] == '8')
        {
            cout << "Osiem ";
        }
        if (liczba[i] == '9')
        {
            cout << "Dziewiec ";
        }
        if (liczba[i] == '0')
        {
            cout << "Zero ";
        }
}

void Zadanie5()
{
    std::string liczba;
    cout << "Wprowdz hajs\n";

    std::getline(std::cin, liczba);
    std::cout << "Podales: " << liczba << "\n";
    int j = liczba.length();
    cout << "\n";

    if (j == 1)
    {
        if (liczba == "1")
        cout << "Zlotowka";
        if (liczba == "2")
        cout << "Dwa z³ote";  
        if (liczba == "3")
            cout << "Zlotowka + dwa zlote";
        if (liczba == "4")
            cout << "Dwa zlote + dwa zlote";
        if (liczba == "5")
            cout << "Piec zlotych";
        if (liczba == "6")
            cout << "Piec zlotych + zlotowka";
        if (liczba == "7")
            cout << "Piec zlotych + dwa z³ote";
        if (liczba == "8")
            cout << "Piec zlotych + dwa z³ote + zlotowka";
        if (liczba == "9")
            cout << "Piec zlotych + dwa zlote + dwa zlote";

    }
}

int main()
{
    Zadanie5();
}


