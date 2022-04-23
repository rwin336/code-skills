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




