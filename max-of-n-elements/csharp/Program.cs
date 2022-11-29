using System;

Console.WriteLine("Max of N elements");

Console.Write("Enter number of arguments: ");
var numberOfArguments = Int32.Parse(Console.ReadLine());

if ( numberOfArguments <= 0 ){
    Console.WriteLine("Invalid user input. Please enter a positive number greater than zero");
    return;
}

Console.Write("Enter arguments:");
var arguments = Console.ReadLine().Split(' ');

List<int> argumentList = new List<int>(numberOfArguments);

for (int i = 0; i < numberOfArguments ; i++)
{
    argumentList.Add(Int32.Parse(arguments[i]));
}

Console.WriteLine("Max value: " + argumentList.Max());

