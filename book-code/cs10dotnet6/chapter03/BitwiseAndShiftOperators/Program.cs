using static System.Console;
 
WriteLine("");
WriteLine("Book:    \tC# 10 and .Net6");
WriteLine("Author:  \tMark J. Price");
WriteLine("Chapter: \t03");
WriteLine("Bitwise and Shift Operators");
WriteLine("");

int a = 10;  // 00001010
int b = 6;   // 00000110

WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}");
WriteLine($"a | b = {a | b}");
WriteLine($"a ^ b = {a ^ b}");
WriteLine();

// 01010000
WriteLine($"a << 3 = {a << 3}");

// multiply by 8
WriteLine($"a * 8 = {a * 8}");

// 00000011 right shift b by one column
WriteLine($"b >> 1 = {b >> 1}");

int c = -3;
WriteLine($"c >> 1 = {c >> 1}");

WriteLine();
WriteLine($"a =      {ToBinaryString(a)}");
WriteLine($"b =      {ToBinaryString(b)}");
WriteLine($"a & b =  {ToBinaryString(a & b)}");
WriteLine($"a | b =  {ToBinaryString(a | b)}");
WriteLine($"a ^ b =  {ToBinaryString(a ^ b)}");
WriteLine();

static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}

