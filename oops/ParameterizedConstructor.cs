using System;

namespace ParameterizedConstuctor
{
    class Bike
    {
        public string model;
        public string color;
        public int year;

     
        // Create a class constructor with multiple parameters
        public Bike(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Bike Bajaj = new Bike("Pulsar", "Black", 2000);
            Console.WriteLine(Bajaj.model + " " + Bajaj.color + " " + Bajaj.year);
        }

    }
}