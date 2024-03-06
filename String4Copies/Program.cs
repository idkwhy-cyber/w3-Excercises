using System;

public class String4Copies
{
    public static void Main()
    {
        Console.WriteLine("Input your string here");
        string? inputString = Console.ReadLine();
        if (inputString.Length >= 4)
        {
            string? outputString = inputString.Substring((inputString.Length-4), 4);
            Console.WriteLine(outputString + outputString + outputString + outputString);
        }
        else 
        {
            Console.WriteLine(inputString + inputString + inputString + inputString);
        }

    }
}