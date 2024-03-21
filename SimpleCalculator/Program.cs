// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("Hello, World!");
Console.WriteLine("First number:");
string firstNumberInput = Console.ReadLine();
int firstNumber = int.Parse(firstNumberInput);
Console.WriteLine("Second number:");

string secondNumberInput = Console.ReadLine();
int secondNumber = int.Parse(secondNumberInput);

Console.WriteLine("What do you want?");
Console.WriteLine("[A]dd numbers?");
Console.WriteLine("[S]ubract numbers");
Console.WriteLine("[M]ultiply number");

string operatorInput = Console.ReadLine();
string lowerOperatorInput = operatorInput.ToLower();

int result;

if (lowerOperatorInput == "a")
{
    result = firstNumber + secondNumber;
    HandleOperator(firstNumber, secondNumber, result, "+");
}
else if (lowerOperatorInput == "s")
{
    result = firstNumber - secondNumber;
    HandleOperator(firstNumber, secondNumber, result, "-");
}
else if (lowerOperatorInput == "m")
{
    result = firstNumber * secondNumber;
    HandleOperator(firstNumber, secondNumber, result, "*");
}
else
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

void HandleOperator(int firstNumber, int secondNumber, int result, string operatorStr)
{
    Console.WriteLine($"{firstNumber} {operatorStr} {secondNumber} = {result}");
}