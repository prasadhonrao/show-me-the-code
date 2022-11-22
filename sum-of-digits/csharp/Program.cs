using System;

Console.Write("Enter a number: ");
var input = Int32.Parse(Console.ReadLine());
var sum = 0;

while (input > 0) {
    sum = sum + (input % 10);
    input = input / 10;
}

System.Console.WriteLine("Sum of the digits: " + sum);