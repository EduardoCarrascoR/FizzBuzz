﻿for (int number = 1; number < 101; number++)
{
    if ((number % 3 == 0) && (number % 5 == 0)) Console.WriteLine($"{number} - FizzBuzz");
    else if (number % 3 == 0) Console.WriteLine($"{number} - Fizz");
    else if (number % 5 == 0) Console.WriteLine($"{number} - Buzz");
    else Console.WriteLine($"{number}");
}