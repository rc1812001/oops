using System;

namespace MyInterface
{
    // Interface
    interface IFruit
    {
        void FruitInformation(); // interface method (does not have a body)
    }

    // Apple "implements" the IFruit interface
    class Apple : IFruit
    {
        public void FruitInformation()
        {
            // The body of FruitInformation() is provided here
            Console.WriteLine("Nmae of fruit is APPLE");
            Console.WriteLine("An Apple a day keeps the doctor away");
            Console.WriteLine("Color of Apple is RED");
        }
    }

    class Orange : IFruit
    {
        public void FruitInformation()
        {
            // The body of FruitInformation() is provided here
            Console.WriteLine("Nmae of fruit is ORANGE");
            Console.WriteLine("An Orange contains Vitamin-C");
            Console.WriteLine("Color of Orangw is ORANGE");
        }
    }

    class Program
       {
           static void Main(string[] args)
           {
            Apple myApple = new Apple();  // Create an Apple object
            myApple.FruitInformation();
            Console.WriteLine();
            Orange myOrange = new Orange();  // Create an Orange object
            myOrange.FruitInformation();
        }
       }
   
}