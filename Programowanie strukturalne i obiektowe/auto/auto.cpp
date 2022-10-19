
#include <iostream>
using namespace std;




struct CoordinateGPS
{
    int x, y;
};

struct Direction
{
    int x, y;
};
class Car
{
public:
    Car(std::string name)
    {
        this->name = name;
        coordinateGPS.x = 0;
        coordinateGPS.y = 0;
        direction.x = 1;
        direction.y = 0;
    }

    Car(std::string name, int x ,int y)
    {
        this->name = name;
        coordinateGPS.x = x;
        coordinateGPS.y = y;
        direction.x = 1;
        direction.y = 0;
    }

    void ShowInfo()
    {
        cout << "***************************************\n";
        cout << "Samochod o nazwie " << name << "\n";
        cout << "Pozycja (" << coordinateGPS.x << " ; " << coordinateGPS.y <<")\n";
        cout << "****************************************\n";
    }
    
    void MoveForward()
    {
        coordinateGPS.x += direction.x;
        coordinateGPS.y += direction.y;
    }

    void TurnLeft()
    {
        int tmpX = direction.x;
        direction.x = -direction.y;
        direction.y = tmpX;
    }

    void TurnRight()
    {
        int tmpX = direction.x;
        direction.x = direction.y;
        direction.y = -tmpX;

    }

protected:
private:
    std::string name;
    
    CoordinateGPS coordinateGPS;

    Direction direction;
};

int main()
{
    Car carFirst("Bzykbzak");
    Car cardwa("Quadra Turbo", 10, 10);

    carFirst.ShowInfo();
    cardwa.ShowInfo();

    carFirst.MoveForward();
    carFirst.ShowInfo();
}

