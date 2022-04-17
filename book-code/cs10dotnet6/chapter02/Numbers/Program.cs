using static System.Console;

WriteLine("");
WriteLine("Book:    \tC# 10 and .Net6");
WriteLine("Author:  \tMark J. Price");
WriteLine("Chapter: \t02");
WriteLine("Numbers");
WriteLine("");

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

WriteLine($"Decimal Notation: \t{decimalNotation}");
WriteLine($"Binary Notation: \t{binaryNotation}");
WriteLine($"Hexadecimal Notation: \t{hexadecimalNotation}");
WriteLine("");
WriteLine($"{decimalNotation == binaryNotation}");
WriteLine($"{decimalNotation == hexadecimalNotation}");
WriteLine("");
WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue} to {double.MaxValue}");
WriteLine($"decimal uses {sizeof(decimal)} bytes anc can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

WriteLine();
WriteLine("Using doubles");
double a = 0.1;
double b = 0.2;

if( a + b == 0.3) 
{
    WriteLine($"{a} + {b} equals {0.3}");
} 
else
{
    WriteLine($"{a} + {b} does NOT equal {0.3}");
}
WriteLine("");


WriteLine();
WriteLine("Using decimals");
decimal ad = 0.1M;
decimal bd = 0.2M;

if( ad + bd == 0.3M) 
{
    WriteLine($"{ad} + {bd} equals {0.3M}");
} 
else
{
    WriteLine($"{ad} + {bd} does NOT equal {0.3M}");
}
WriteLine("");


WriteLine();
