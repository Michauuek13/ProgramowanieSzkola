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

double calcutaledistance(int a, int b)
{
	double distance = sqrt(a * a + b * b);
	return distance;
}

//void calcutatedistance(Point p)
//{
	//double distance = sqrt(p.x * p.x + p.y * p.y);
	
//}

void cordinateTestVersion3()
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


struct Person
{
	std::string name;
	std::string surename;
	int age;
	int height;

};

//Person p1;
//p.1 name
//p1.coordinate.x =5;

Person pTab[5];

std::string nameTab[5];
std::string surenameTab[5];
int age[5];
int height[5];

int main()
{
	cordinateTestVersion1();
}

