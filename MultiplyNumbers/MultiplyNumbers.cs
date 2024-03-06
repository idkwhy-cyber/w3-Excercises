public class MultiplyNumbers
{
    public static void Main()
    {
        Console.WriteLine("This application will multiply three numbers for you !");
        Console.WriteLine("input your first number ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input your second number ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input your third number ");
        int n3 = Convert.ToInt32(Console.ReadLine());

        int product = n1 * n2 * n3;

        Console.WriteLine(n1 + " x " + n2 + " x " + n3 + " = " + n1*n2*n3);

    }
}