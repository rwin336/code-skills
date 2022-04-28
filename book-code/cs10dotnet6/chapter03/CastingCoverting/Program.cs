﻿using static System.Console;


WriteLine("Chapter 03 - Casting Converting");

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
