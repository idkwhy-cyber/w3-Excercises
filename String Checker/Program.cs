public class StringChecker
{
    public static void Main()
    {
        Console.WriteLine("Input String here: ");
        string str1 = Console.ReadLine();
        string result;
        if (str1.IndexOf("HP") == 1)
        {
            result = str1.Remove(str1.IndexOf("HP"), 2);
        }
        else
        {
            result = str1;
        }
        Console.WriteLine(result);

    }
}