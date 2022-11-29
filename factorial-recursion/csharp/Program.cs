using System;

Console.Write("Enter a number: ");
var input = Int32.Parse(Console.ReadLine());

if (input < 0)
{
    Console.WriteLine("Invalid user input. Please enter a positive number.");
    return;
}

int userInput = input;
long factorial = CalculateFactorial(userInput);

Console.WriteLine("Factorial of " + userInput + " is " + factorial);

long CalculateFactorial(int number) {
    if (number == 0) {
        return 1;
    }
    else if (number == 1) {
        return number;
    }
    else {
        return CalculateFactorial(number - 1) * number;
    }
}