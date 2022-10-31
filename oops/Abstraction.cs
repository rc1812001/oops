using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Vehicle
{
    public abstract void VehicleDetails();
}
class Car : Vehicle
{
    public override void VehicleDetails()
    {
        Console.WriteLine("Model: Ford");
        Console.WriteLine("color: red");
        Console.WriteLine("MaxSpeed: 150km/h");
    }
}
class Bike : Vehicle
{
    public override void VehicleDetails()
    {
        Console.WriteLine("Model: Yamaha-FZ");
        Console.WriteLine("color: black");
        Console.WriteLine("MaxSpeed: 100km/h");
    }
}

public class AbstractionDemo
{
    public static void Main(string[] args)
    {
       Vehicle objCar = new Car();
        objCar.VehicleDetails();
        Console.WriteLine("");
        Vehicle objBike = new Bike();
        objBike.VehicleDetails();
    }
} 