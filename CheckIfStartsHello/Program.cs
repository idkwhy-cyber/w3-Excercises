public class CheckStartHello
{
    public static void Main()
    {   
        Console.WriteLine("Input Sentence: ");
        string str1 = Console.ReadLine();
        Console.WriteLine(str1.StartsWith("Hello"));
    }
}
