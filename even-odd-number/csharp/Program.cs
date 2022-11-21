Console.Write("Enter a number: ");
var input = Int32.Parse(Console.ReadLine());

if (input % 2 == 0)
    Console.WriteLine("Entered number " + input + " is an even number.");
else
    Console.WriteLine("Entered number " + input + " is an odd number.");

