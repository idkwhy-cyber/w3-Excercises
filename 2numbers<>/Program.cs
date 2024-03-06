public class TwoNumbers
{
    public static void Main()
    {
        Console.WriteLine("Input Number under 100: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Number over 200: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1<100 && num2>200);
    }
}