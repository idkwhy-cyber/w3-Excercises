public class CheckIntRange
{
    public static void Main()
    {
        Console.WriteLine("Input First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1>-10 && num1<10 || num2>-10 && num2<10);
    }

}