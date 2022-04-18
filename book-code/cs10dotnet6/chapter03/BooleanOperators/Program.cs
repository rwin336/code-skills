using static System.Console;
 
WriteLine("");
WriteLine("Book:    \tC# 10 and .Net6");
WriteLine("Author:  \tMark J. Price");
WriteLine("Chapter: \t03");
WriteLine("Boolean Operators");
WriteLine("");


bool a = true;
bool b = false;


WriteLine($"AND   | a     | b     ");
WriteLine($"a     | {a & a,-5} | {a & b,-5}");
WriteLine($"b     | {b & a,-5} | {b & b,-5}");
WriteLine();
WriteLine($"OR    | a     | b     ");
WriteLine($"a     | {a | a,-5} | {a | b,-5}");
WriteLine($"b     | {b | a,-5} | {b | b,-5}");
WriteLine();
WriteLine($"XOR   | a     | b     ");
WriteLine($"a     | {a ^ a,-5} | {a ^ b}");
WriteLine($"b     | {b ^ a,-5} | {b ^ b}");
WriteLine();


static bool DoStuff()
{
    WriteLine("I'm doing some stuff");
    return true;
}

WriteLine();
WriteLine("Logical operator '&'");
WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStugg() = {b & DoStuff()}");
WriteLine();
WriteLine("Conditional Logical operator '&&'");
WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine($"b && DoStugg() = {b && DoStuff()}");

WriteLine();
