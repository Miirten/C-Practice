using System;

// 1. Print "Hello, (your name)"
// string name = "Mat";

// Console.WriteLine($"Hello, {name}");

// 2. Add two numbers
// int a = 1;
// int b = 2;

// int sum = a + b;
// Console.WriteLine($"{sum}");

// Console.WriteLine("Enter a number");

// string? input = Console.ReadLine();
// int c = int.Parse(input);

// Console.Write($"{input}");

// 3. Read an integer and print whether it is even or odd.
// Console.WriteLine("Enter a number: ");
// string? a = Console.ReadLine();

// if (int.TryParse(a, out int number))
// {
//     if (number % 2 == 0)
//     {
//         Console.WriteLine("Your number is even.");
//     }
//     else
//     {
//         Console.WriteLine("Your number is odd.");
//     }
// }

// 4. Read two numbers and print the larger one. Handle the case where they are equal.
// Console.WriteLine("Enter 2 numbers.");
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// if (a > b)
// {
//     Console.WriteLine($"{a}");
// }
// else if (b > a)
// {
//     Console.WriteLine($"{b}");
// }
// else if (a == b)
// {
//     Console.WriteLine($"Same");
// }

// 5. Read a temperature in Celsius and convert it to Fahrenheit using:

// Console.WriteLine("Enter a temperature in celsius");
// int cels = int.Parse(Console.ReadLine());
// double conv = 1.8;
// double fahr = (cels * conv) + 32;

// Console.WriteLine($"{fahr}");

// 1. Print numbers from 1 through 100.
// Print Fizz for multiples of 3, Buzz for multiples of 5, and FizzBuzz for multiples of both.

// for (int i = 1; i <= 100; i++)
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//     }

// 2.
// Given a string, count the vowels: a, e, i, o, and u.
// Treat uppercase and lowercase letters the same.

// string? givenString = ("aAeEiIoOuU,mnbzxcv,mnbzxcv,mnbzxv");
// string? normalizedString = givenString.ToLowerInvariant();
// char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

// int num = 0;
// foreach (char character in normalizedString)
//     if (Array.IndexOf(vowels, character) >= 0)
//     {
//         num++;
//     }

// Console.Write(num);

// 3.
// Read a string and output it reversed.
// Example: hello becomes olleh.
