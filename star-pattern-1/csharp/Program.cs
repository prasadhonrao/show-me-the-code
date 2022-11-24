Console.WriteLine("--- Star Pattern 1 ---");

Console.Write("Enter a number: ");
var input = Int32.Parse(Console.ReadLine());

if (input <= 0)
    Console.WriteLine("Invalid input. Please enter a positive number greater than zero.");
else {
    Console.WriteLine("You have entered number: " + input);
    for (int i = 1; i <= input; i++) {
        for (int j = 1; j <= i; j++)
            Console.Write("* ");
        Console.WriteLine("\t");
    }
}

