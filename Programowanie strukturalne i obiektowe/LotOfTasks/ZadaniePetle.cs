using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotOfTasks
{
    class ZadaniePetle
    {
        public void IsPrimeNumber()
        {
            Console.WriteLine("Podaj liczbe");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Liczba jest pierwsza");
            }
            else
            {
                Console.WriteLine("Liczba nie jest pierwsza");
            }
        }

        public void IsPalindrome()
        {
            Console.WriteLine("Podaj wyraz");
            string word = Console.ReadLine();
            bool isPalindrome = false;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - i - 1])
                {
                    isPalindrome = false;
                }
                else
                    isPalindrome = true;
            }


            if (isPalindrome == true)
            {
                Console.WriteLine("Wyraz jest palindromem");
            }
            else
            {
                Console.WriteLine("Wyraz nie jest palindromem");
            }
        }

        public void isAnagram()
        {
            Console.WriteLine("Podaj wyraz");
            string word1 = Console.ReadLine();
            Console.WriteLine("Podaj drugi wyraz");
            string word2 = Console.ReadLine();

            bool areAnagrams = true;

            if (word1.Length != word2.Length)
            {
                areAnagrams = false;
            }
            else
            {
                char[] firstWordChars = word1.ToCharArray();
                Array.Sort(firstWordChars);

                char[] secondWordChars = word2.ToCharArray();
                Array.Sort(secondWordChars);

                for (int i = 0; i < firstWordChars.Length; i++)
                {
                    if (firstWordChars[i] != secondWordChars[i])
                    {
                        areAnagrams = false;
                    }
                }
            }

            if (areAnagrams == true)
            {
                Console.WriteLine("Wyrazy sa anagramami");
            }
            else
            {
                Console.WriteLine("Wyrazy nie sa anagramami");
            }
        }

        public void idealNumber()
        {
            Console.WriteLine("Podaj liczbe");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine("Liczba jest doskonala");
            }
            else
                Console.WriteLine("Liczba nie jest doskonala");
        }


    }
}
