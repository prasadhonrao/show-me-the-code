using System;

Console.WriteLine("First N Prime Numbers");

Console.Write("Enter a number: " );
var input = Int32.Parse(Console.ReadLine());

List<int> primes = new List<int>();

for (int i = 0; i < Int32.MaxValue; i++)
{
    if (IsPrimeNumber(i))
    {
        primes.Add(i);
        if (primes.Count == input)
            break;
    }
}

Console.WriteLine(string.Join(", ", primes));

// Function to check if a number is a prime number or not
bool IsPrimeNumber(int number) {
    if (number <= 0 || number == 1) 
        return false;
    
    bool IsPrime = true;
    for (int i = 2; i < number; i++){
        if (number % i == 0) IsPrime = false;
    }
    return IsPrime;
}