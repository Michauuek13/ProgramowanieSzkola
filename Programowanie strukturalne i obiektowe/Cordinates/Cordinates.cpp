#include <iostream>
using namespace std;


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


int main()
{
	cordinateTestVersion1();
}

