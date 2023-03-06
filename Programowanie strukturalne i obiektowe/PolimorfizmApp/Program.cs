using System;

namespace PolimorfizmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Burek");
            Dog secondDog = new Dog("Reksio");
            Cat cat = new Cat("Andzrej");
            Point point = new Point();

            Animals animals = new Animals();

            dog.Bark();
            cat.Meow();

            dog.ShowInfo();
            cat.ShowInfo();

            InfoAboutDog(dog);
            InfoAboutDog(secondDog);

            InfoAbout(point);
        }

        static void InfoAboutDog(Dog d)
        {
            d.ShowInfo();
        }

        static void InfoAbout(Animals a)
        {
            a.ShowInfo();
        }
    }
}
