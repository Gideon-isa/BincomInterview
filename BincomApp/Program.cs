// See https://aka.ms/new-console-template for more information
using BincomApp;


/*
 * Task 1
 * 
 */
Console.WriteLine("Task One\n");
string name = "John Doe";
int age = 25;
bool isAdmin = true;

Console.WriteLine($"{name}");
Console.WriteLine($"{age}");
Console.WriteLine($"{isAdmin}");


/**
 * Task 2
 * 
 */
Console.WriteLine("\n\n\n");
Console.WriteLine("Task Two\n");
bool isValid = false;
int validNumber = 0;
while( !isValid )
{
    Console.WriteLine("Please imput a number and press enter");
    var userInput = Console.ReadLine();
    isValid = int.TryParse(userInput, out validNumber);
    if( !isValid )
    {
        Console.WriteLine("You entered a wrong imput; not a nuumber");
    }
}

if ((validNumber % 2) == 1)
{
    Console.WriteLine("Odd");
}
else
{
    Console.WriteLine("Even");
}


/**
 * Task 3
 * 
 */
Console.WriteLine("\n\n\n");
Console.WriteLine("Task Three\n");
for (int i = 0; i < 11; i++)
{
    Console.WriteLine(i);
}

/**
 * Task 4
 * 
 */
Console.WriteLine("\n\n\n");
Console.WriteLine("Task Four\n");
int[] integerArray = new int[] {2, 4, 6, 8, 10};
foreach (var element in integerArray)
{
    Console.WriteLine(element);
}

/**
 * Task 5
 * 
 */
Console.WriteLine("\n\n\n");
Console.WriteLine("Task Five\n");
var userName = "Alice";
Greetings.Greet(userName);
