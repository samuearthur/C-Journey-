// Working with If statements 
Console.WriteLine("Working with If Statements \n");
bool isMale = true;
bool isTall = true;

if(isMale || isTall)
{
    Console.WriteLine("You are not human \n");
}
else if (isMale && !isTall)
{
    Console.WriteLine("Samuel \n");
}
else
{
    Console.WriteLine("Error \n");
}

if (isMale && isTall)
{
    Console.WriteLine("You are not human \n");
}
else
{
    Console.WriteLine("Error");
}






Console.ReadLine();