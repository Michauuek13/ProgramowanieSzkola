
#include <iostream>
using namespace std;



class point
	{public:
		double calculateDistance()
	{
		double distance = sqrt(x * x + y * y);
		return distance;
	}
		void SetX(int a)
		{
			if (x >= 0)
				this->x = x;
		}
		void SetY(int b)
		{
			if (y >= 0)
				this->y = y;
		}
	private:
		int x;
		int y;
	};
int main()
{
	
	int x, y;
	point point;
	point.SetX(10);
	point.SetY(15);
	double distance = point.calculateDistance();
	cout << distance;
}

