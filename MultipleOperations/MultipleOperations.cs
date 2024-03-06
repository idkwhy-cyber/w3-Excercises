public class MultipleOperations
{
    public static void Main()
    {
        Console.WriteLine("Input your first number ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input your second number ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(n1 + " + " + n2 + " = " + (n1+n2));
        Console.WriteLine(n1 + " - " + n2 + " = " + (n1-n2) );
        Console.WriteLine(n1 + " x " + n2 + " = " + (n1*n2));
        Console.WriteLine(n1 + " / " + n2 + " = " + (n1/n2));
        Console.WriteLine(n1 + " Mod " + n2 + " = " + (n1%n2));  

    }
}