public class StringChecker
{
    public static void Main()
    {
        Console.WriteLine("Input String here: ");
        string str1 = Console.ReadLine();
        string result = str1.Remove(str1.IndexOf("HP"), 2);
        Console.WriteLine(result);


    }
}