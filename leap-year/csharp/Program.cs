using System;

Console.WriteLine("--- Leap Year ---");

Console.Write("Enter a number: ");
var year = Int32.Parse(Console.ReadLine());

if (isLeapYear(year) == true)
    Console.WriteLine("You have entered year " + year + " which is a leap year");
else
    Console.WriteLine("You have entered year " + year + " which is not a leap year");


static bool isLeapYear(int year) {
    if ((year % 400 == 0) || (year % 100 != 0) && (year % 4 == 0))
        return true;
    else
        return false;
}
