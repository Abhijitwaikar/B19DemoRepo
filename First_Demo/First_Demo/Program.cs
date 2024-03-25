// See https://aka.ms/new-console-template for more information
using First_Demo;

Console.WriteLine("Hello, World!");
Console.WriteLine("Demo solution");
Console.WriteLine("Welcome to calculator App");
Console.WriteLine("Please enter first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter second number");
int b = int.Parse(Console.ReadLine());
Calculator c = new Calculator();
c.Add(a,b);
Console.ReadLine();
