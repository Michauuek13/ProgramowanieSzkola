using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionConsoleApp
{
    class TestCollection
    {
        public void TestArray()
        {
            int[] arrayOfNumber = new int[10];
            arrayOfNumber[5] = 2137;

            var random = new Random();
            for(int i = 0; i < arrayOfNumber.Length; i++)
            {
                arrayOfNumber[i] = random.Next()%100;
            }

            foreach(int item in arrayOfNumber)
            {
                Console.Write(item + ", ");
            }

            int max = arrayOfNumber[0];
            foreach(int number in arrayOfNumber)
            {
                if (number > max)
                    max = number;
            }
            Console.WriteLine();
            Console.WriteLine("Max w tablicy to: " + max);
        }

        public void TestObjectArrayCollection()
        {
            Number[] arrayWidthObjectNumbers = new Number[5];
            //arrayWidthObjectNumbers[2].ourNumber = 7;
            Random random = new Random();
            for (int i = 0; i < arrayWidthObjectNumbers.Length; i++)
            {
                arrayWidthObjectNumbers[i] = new Number();
                arrayWidthObjectNumbers[i].ourNumber = random.Next() %100;
            }

            foreach(Number number in arrayWidthObjectNumbers)
            {
                Console.Write($"{number.ourNumber}, ");
            }

            int max = arrayWidthObjectNumbers[0].ourNumber;
            foreach (Number number in arrayWidthObjectNumbers)
            {
                if (number.ourNumber > max)
                    max = number.ourNumber;
            }
            Console.WriteLine();
            Console.WriteLine("Max w tablicy to: " + max);
        }

        public void TestGeneric()
        {
            Number[] numbers = new Number[5];
            NumberFloat[] floatnumbers = new NumberFloat[5];

            NumberGeneric<int>[] intGenericNumbers = new NumberGeneric<int>[5];
            NumberGeneric<float>[] floatGenericNumbers = new NumberGeneric<float>[5];
            NumberGeneric<double>[] doubleGenericNumbers = new NumberGeneric<double>[5];
            NumberGeneric<byte>[] byteGenericNumbers = new NumberGeneric<byte>[5];
        }

        public void ListCollection()
        {
            List<int> listOfInts = new List<int>();
            Console.WriteLine("Ma " + listOfInts.Count);
            listOfInts.Add(5);       
            Console.WriteLine("Ma " + listOfInts.Count);

            for (int i = 0; i < listOfInts.Count; i++)
            {
                listOfInts[i] = 2;
            }

            for (int i = 0; i < 15; i++)
            {
                listOfInts.Add(new Random().Next(1, 100));
            }



            foreach (int item in listOfInts)
            {
                Console.WriteLine("Element: " + item);
            }





        }

    }

    

    class Number
    {
        public int ourNumber;
    }

    class NumberGeneric<T>
    {
        public T ourNumber;
    }

    class NumberFloat
    {
        public float floatnumbers;
    }
}
