#include <iostream>
#include <ctime>
using namespace std;



class Person
{
public:
    void Info()
    {
        cout << "Imie: " << name << "\n";
        cout << "Nazwisko: " << surename << "\n";
        cout << "Wzrost: " << height << "\n";
        cout << "Wiek: " << date  << "\n";
        cout << "Waga: " << weight << "\n";
        
    }

    void Pelnoletniosc()
    {
        if (date >= 18)
            cout << "Pelnoletni\n";
        else
            cout << "Niepelnoletni\n";
    }

    

    Person(std::string name, std::string surename, int height, int date, int weight)
    {
        this->name = name;
        this->surename = surename;
        this->height = height;
        this->date = date;
        this->weight = weight;
    }
    Person1(std::string name, std::string surename)
    {
        this->name = name;
        this->surename = surename;
        this->height = 170;
        this->date = time_t givemetime = time(NULL);
        this->weight = 60;
    }
    

private:
    std::string name;
    std::string surename;
    int height;
    int dataUrodzenia;
    int date;
    int weight;
    
};


int main()
{
    time_t now = time(0);
    tm* ltm = new tm;
    localtime_s(ltm, &now);
    int data;
    data = 1900 + ltm->tm_year;
    
   
    Person Osoba1("Jackie", "Wellles", 180, data - 1990, 90 );

    Person Osoba2("Judy", "Alvarez", 160, data - 2006, 55);

    Person1 Osoba1("Victor", "Vector");

    Osoba1.Info();
    cout << "\n";
    Osoba1.Pelnoletniosc();
    cout << "\n";
    

    Osoba2.Info();
    cout << "\n";
    Osoba2.Pelnoletniosc();

    cout << "\n";
    Osoba1.Info();
    delete ltm;
}


