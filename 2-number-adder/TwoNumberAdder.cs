using System;

public class TwoNumberAdder
{
    public static void Main()
    {

        Console.WriteLine("Input your addends");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = n1 + n2;
        Console.WriteLine("Your sum is " + n3);
    }
}