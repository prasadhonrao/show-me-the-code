Console.WriteLine("Simple Calculator");

Console.Write("Enter first number: ");
var number1 = Int32.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
var number2 = Int32.Parse(Console.ReadLine());

Console.Write("Choose operation from + - * / % : ");
var operation = Console.ReadLine();

switch (operation) {
    case "+":
        Console.WriteLine(number1 + number2);
        break;
    case "-":
        Console.WriteLine(number1 - number2);
        break;
    case "*":
        Console.WriteLine(number1 * number2);
        break;
    case "/":
        if (number2 == 0) {
            Console.WriteLine("cannot divide by zero");
            return;
        }
        Console.WriteLine(number1 / number2);
        break;
    case "%":
        if (number2 == 0) {
            Console.WriteLine("cannot divide by zero");
            return;
        }
        Console.WriteLine(number1 % number2);
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}