using System;

namespace MyDynamicPolymorphism 
{
    namespace oops
    {
        abstract class Shape // BASE CLASS
        {
            public abstract double Area(double length,double breadth); 
            //NOTE: here i have used abstract instead of virtual beacause virtual KEYWORD demands to have a return value 
            //Also abstract class is empty 
        }
        class Circle : Shape //DERIVED CLASS
        {
            public override double Area(double r,double breadth )
            {
                return (Math.PI * r * r);
            }
        }

        class Square : Shape //DERIVED CLASS
        {
            public override double Area(double length, double breadth = 0)
            {
                return (length * length);
            }
        }

        class Rectangle : Shape //DERIVED CLASS
        {
            public override double Area(double length,double breadth)
            {
                return (length * breadth);
            }
        }
             class DynamicPolymorphism
               {
                   static void Main(string[] args)
                   {
                       Shape shapeCircle = new Circle(); // Object creation for Circle class
                       Shape shapeSquare = new Square(); // Object creation for Square  class
                       Shape shapeRectangle = new Rectangle(); // Object creation for Rectangle class

                       Console.WriteLine("Area of circle is " +  shapeCircle.Area(5,0));
                       Console.WriteLine("Area of sqaure is " +  shapeSquare.Area(6,0));
                       Console.WriteLine("Area of rectangle is " +  shapeRectangle.Area(5, 5));
                   }
         
    }
*/
}
}
