using System;
using static System.Console;

string password = "ninja";

if(password.Length < 8)
{
    WriteLine("Your password is too short.  Use at least 8 characters");
}
else
{
    WriteLine("Your password is strong(kind-of).");
}

object o = 3;
int j = 4;

if(o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiple!");
}



