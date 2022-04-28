using static System.Console;
using static System.Convert;

WriteLine("Chapter 03 - Casting Converting");
WriteLine();

int a = 10;
double b = a;
WriteLine($"b = {b}");

double c = 9.8;
//int d = c;     // gives compiler error
int d = (int)c;
WriteLine($"d = {d}");


long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}" );

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

WriteLine();
double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}");

WriteLine();
double[] doubles = new []{ 9.49, 9.5, 9.51, 10.49, 10.5, 10.51};
foreach(double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

WriteLine();
foreach(double  n in doubles)
{
    WriteLine(format:
      "Math.Round({0}, 0, MidpointRounding.AwayFroZero) is {1}",
      arg0: n,
      arg1: Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero));
}

WriteLine();