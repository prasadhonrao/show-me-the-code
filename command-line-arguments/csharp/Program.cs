using System;

// Note: args is a argument to main function which is been abstracted by higher level statements
if (args.Length == 0) {
    Console.WriteLine("No command line arguments were specified");
}
else
{
    foreach (var item in args)
    {
        Console.WriteLine(item);
    }
}