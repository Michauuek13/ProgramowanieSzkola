using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmApp
{
    class Point
    {
        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowInfo()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Obiekt klasy point");
            Console.WriteLine($"Współrzedna punktu x {x}, y {y}");
            Console.WriteLine("--------------------------");
        }
    }
}
