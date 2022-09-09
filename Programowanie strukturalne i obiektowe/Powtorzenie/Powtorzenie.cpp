

#include <iostream>
using namespace std;

void PT()
{
    system("cls");
    float a;
    float h;
    cout << "Podaj a:\n";
    cin >> a;
    cout << "Podaj wysokosc:\n";
    cin >> h;
    cout << "Pole trojkata wybosi: " << a * h / 2;
}

void PK()
{
    system("cls");
    float a;
    float b;
    cout << "Podaj a:\n";
    cin >> a;
    cout << "Podaj b\n";
    cin >> b;
    cout << "Pole prostokata wynosi: " << a * b << "\n";
}

void wyborfun()
{
    int wybor;
    cout << "\n";
    cin >> wybor;
    if (wybor == 1)
    {
        cout << "\n";
        cout << "POLE PROSTOKATA\n";
        PK();
    }
    if (wybor == 2)
    {
        cout << "\n";
        cout << "POLE TROJKATA\n";
        PT();
    }
    if (wybor == 3)
    {

    }
    if (wybor > 3)
    {
        cout << "Wprowadz wybor: "; 
        wyborfun();
    }
}

void mainProgram()
{
    
    cout << "Wybierz se od 1-3\n";
    cout << "1.Pole prostokata \n";
    cout << "2.Pole Trojkata \n";
    cout << "3. \n";
    cout << "Wprowadz wybor: ";
    wyborfun();
}

int main()
{
    mainProgram();
    //std::cout << "Hello World!\n";
}


