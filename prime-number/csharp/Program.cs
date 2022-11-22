Console.Write("Enter a number: " );
var input = Int32.Parse(Console.ReadLine());

if (IsPrimeNumber(input))
    Console.WriteLine(input + " is a prime number.");
else 
    Console.WriteLine(input + " is a not prime number.");

// Function to check if a number is a prime number or not
bool IsPrimeNumber(int number) {
    bool IsPrime = true;
    for (int i = 2; i < number; i++){
        if (number % i == 0) IsPrime = false;
    }
    return IsPrime;
}