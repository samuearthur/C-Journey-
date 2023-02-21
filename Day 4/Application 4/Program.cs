// Working with strings 

internal class Program
{
    private static void Main(string[] args)
    {
        string phrase = "100 days c# " + " coding";
        Console.WriteLine(phrase);
        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase.ToLower());
        Console.WriteLine(phrase.ToUpper());
        Console.WriteLine(phrase.Contains("coding"));
        Console.WriteLine(phrase.Contains("100 days"));
        Console.WriteLine(phrase[7]);
        Console.WriteLine(phrase.IndexOf("coding"));
        Console.WriteLine(phrase.IndexOf("#"));
        Console.WriteLine(phrase.IndexOf("C"));
        Console.WriteLine(phrase.Substring(6,4));

        Console.ReadLine();
    }
}