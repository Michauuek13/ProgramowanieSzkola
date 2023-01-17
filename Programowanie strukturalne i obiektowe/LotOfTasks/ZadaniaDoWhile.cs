using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class ZadaniaDoWhile
    {
        public void Password()
        {

            string password;
            do
            {
                Console.WriteLine("Podaj hasło");
                password = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Hasło nie poprawne");
            } while (password != "abc123");

            if (password == "abc123")
            {
                Console.Clear();
                Console.WriteLine("Hasło poprawne");
            }
        }

        public void squareSum()
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum += i * i;
                Console.Write(i * i + ", ");
                i++;
            } while (sum + i * i <= 10000);
        }
    }
}
