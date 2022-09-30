#include <iostream>
using namespace std;

struct point
{
	int x;
	int y;

};
void cordinateTestVersion1()
{
	int x, y;
	cout << "Podaj x\n";
	cin >> x;
	cout << "Podaj y\n";
	cin >> y;
	double distance = sqrt(x*x+y*y);
	cout << distance;
}
void cordinateTestVersion2()
{
	int x, y;
	point point;
	cout << "Podaj x\n";
	cin >> point.x;
	cout << "Podaj y\n";
	cin >> point.y;
	double distance = sqrt(x*x+y*y);
	cout << distance;
}


int main()
{
	cordinateTestVersion1();
}

