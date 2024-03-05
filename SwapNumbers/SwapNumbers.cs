public class SwapNumbers
{
    public static void Main()
    {
        Console.WriteLine("Input your first number");
        int i1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input your second number");
        int i2 = Convert.ToInt32(Console.ReadLine());
        int o1 = i2;
        int o2 = i1;
        i1 = o1;
        i2 = o2;
        Console.WriteLine("Your first number has been swapped to " + i1);
        Console.WriteLine("Your second number has been swapped to " + i2);
    }
}