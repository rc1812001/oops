using System;

public class RBI //BASE CLASS
{
    public float rate_rbi = 6.5f;
    public float calculateBalRBI(int amount, int years)
    {
        return amount + ((amount * rate_rbi * years) / 100);
    }
}
public class SBI : RBI //SBI IS DERIVED CLASS FROM RBI
{
    public float rate_sbi = 7f;
    public float calculateBalSBI(int amount, int years)
    {
        return amount + ((amount * rate_sbi * years) / 100);
    }
}
public class Canera : SBI //AND CANERA IS DERIVED From SBI 
{
    public float rate_canera = 7.2f;
    public float calculateBalCanera(int amount, int years)
    {
        return amount + ((amount * rate_canera * years) / 100);
    }
}

public class InheritanceExample
{
    public static void Main(string[] args)
    {
        Canera c = new Canera();
        Console.WriteLine("Enter the amount you want to invest??");
        int amount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("for how many time you want to invest (in years)?");
        int years = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your amount according to canera bank policies after " + years + " years will be " + c.calculateBalCanera(amount, years));
        Console.WriteLine("Your amount according to State bank of India policies after " + years + " years will be " + c.calculateBalSBI(amount, years));
        Console.WriteLine("Your amount according to Reserve bank of India policies after " + years + " years will be " + c.calculateBalRBI(amount, years));
    }
}
