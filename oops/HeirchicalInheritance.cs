
// C# program to illustrate the above concept
using System;

// Base Class
public class Father
{
    public string FatherName()
    {
        return "Ravi";
    }
}

// Derived Class
public class ChildFirst : Father
{
    public string ChildDName()
    {
        return "Rohan";
    }
}

// Derived Class
public class ChildSecond : Father
{
    public string ChildDName()
    {
        return "Nikhil";
    }
}

class GFG
{

    static void Main(string[] args)
    {
        ChildFirst first = new ChildFirst();

        // Displaying Child Name and Father Name for
        // ChildFirst
        Console.WriteLine("My name is " + first.ChildDName() +
                          ". My father name is " +
                          first.FatherName() + ".");
        ChildSecond second = new ChildSecond();

        // Displaying Child Name and Father Name for
        // ChildSecond
        Console.WriteLine("My name is " + second.ChildDName() +
                          ". My father name is " +
                          second.FatherName() + ".");
    }
}