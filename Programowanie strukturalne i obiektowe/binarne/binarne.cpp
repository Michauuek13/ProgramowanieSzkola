

#include <iostream>
using namespace std;

int main()
{
    cout << "podaj liczbe\n";
    int liczba;
    cin >> liczba;
    int i = 0;
    int tab[32];

        while (liczba != 0)
        {
            tab[i++] = liczba % 2;
            liczba /= 2;
        }
    for (int j =i - 1; j >= 0; j--)
        cout << tab[j];
}


