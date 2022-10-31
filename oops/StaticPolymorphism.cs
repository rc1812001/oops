// C# program to demonstrate the function
// overloading by changing the
// Order of the parameters
using System;
class User
{
   

    // Method Created named as identity
    public void Identity(String FirstName)
	{

		Console.WriteLine("FirstName is : " + FirstName );
	}

	// Method
	public void Identity( String LastName, string Email)
	{

		Console.WriteLine("LastName is : " + LastName + ", "
						+ "EmailId : " + Email);
	}

	public void Identity(double PhoneNum)
	{

		Console.WriteLine("Phone Number is " + PhoneNum);
	}

	// Main Method
	public static void Main(String[] args)
	{

		// Creating Object
		User obj = new User();

		obj.Identity("Akku");
		obj.Identity( "Abby","xyz@gmail.com");
		obj.Identity(897669896);
	}
}
