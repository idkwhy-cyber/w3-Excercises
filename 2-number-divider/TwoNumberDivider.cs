public class TwoNumberDivider
{
    public static void Main()
    {
        Console.WriteLine("input dividend and divisor in that order");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your Quotient is " + n1/n2);
    }
}
