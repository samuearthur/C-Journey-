// Working with Methods 


Console.WriteLine("Working with Methods \n");
SayHi("Samuel",45);
WelcomeHome();  

Console.ReadLine();

static void SayHi( string name, int age)
{
    Console.WriteLine("Hello " + name + " you are " + age + " years old \n");
}

static void WelcomeHome()
{
    Console.WriteLine("Welcome Home");
}
