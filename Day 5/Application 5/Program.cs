// Getting UserInputs

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hello Welcome to My Mini Form \n ");

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Age: ");
        string age  = Console.ReadLine();
        Console.Write("School: ");
        string school = Console.ReadLine();
        Console.Write("Program: ");
        string program = Console.ReadLine();
        Console.WriteLine("Full name: " + name);
        Console.WriteLine("You are " + age + " years old");
        Console.WriteLine("School:  " + school);
            Console.WriteLine( "Programme of Study: " + program);






        Console.ReadLine(); 
    }
}