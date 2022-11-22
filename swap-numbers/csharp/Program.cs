using System;

Console.Write("Enter first number: ");
var number1 = Int32.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
var number2 = Int32.Parse(Console.ReadLine());

SwapNumberUsingThirdVariable(number1, number2);
SwapNumberWithoutUsingThirdVariable(number1, number2);

static void SwapNumberUsingThirdVariable(int number1, int number2)
{
    System.Console.WriteLine("Swapping numbers using a third variable...");

    var temp = number1;
    number1 = number2;
    number2 = temp;

    System.Console.WriteLine("First Number is " + number1);
    System.Console.WriteLine("Second Number is " + number2);
}

static void SwapNumberWithoutUsingThirdVariable(int number1, int number2)
{
    System.Console.WriteLine("Swapping numbers without using a third variable...");

    number1 = number1 + number2;
    number2 = number1 - number2;
    number1 = number1 - number2;

    System.Console.WriteLine("First Number is " + number1);
    System.Console.WriteLine("Second Number is " + number2);
}
