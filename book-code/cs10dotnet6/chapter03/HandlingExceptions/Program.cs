﻿using System;

using static System.Console;

WriteLine("Before parsing");
Write("What is you age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old");
}
catch(OverflowException)
{
    WriteLine("Your age is a valid number format bit is is either too big or small.");
}
catch(FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch(Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

WriteLine("After parsing");


WriteLine();
Write("Enter an amount: ");
string? amount = ReadLine();

try
{
    decimal amountValue = decimal.Parse(amount);
}
catch(FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts connot use the dollar sign!");
}
catch(FormatException)
{
    WriteLine("Amounts must only contain digits!");
}