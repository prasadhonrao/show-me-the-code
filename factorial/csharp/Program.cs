Console.Write("Enter a number: ");
var input = Int32.Parse(Console.ReadLine());

int userInput = input;
long factorial = 1;

while (input > 0) {
    factorial = factorial * input;
    input = input - 1;
}

Console.WriteLine("Factorial of " + userInput + " is " + factorial);