﻿using System;

using static System.Console;

try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");

        x++;
        WriteLine($"After incrementing: {x}");

        x++;
        WriteLine($"After incrementing: {x}");

        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch(OverflowException)
{
    WriteLine("The code overflowed but I caught the exception.");
}