public class CheckDivisible
{
    public static void Main()
    {
        bool isDivisible;
        Console.WriteLine("input your number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        if (num1%3 == 0 || num1%7 == 0)
        {
            isDivisible = true;
        }
        else 
        {
            isDivisible = false;
        }
        Console.WriteLine(isDivisible);
    }
}