﻿using Packt.Shared;
using static System.Console;

Person harry = new() { Name = "Harry"};
Person mary = new() { Name = "Mary"};
Person jill = new() { Name = "Jill"};

// call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

// call static method
Person baby2 = Person.Procreate(harry, jill);

// call an operator
Person baby3 = harry * mary;

WriteLine($"{harry.Name} has {harry.Children.Count} children");
WriteLine($"{mary.Name} has {mary.Children.Count} children");
WriteLine($"{jill.Name} has {jill.Children.Count}");

WriteLine(
    format: "{0}'s first child is named \"{1}\".",
    arg0: harry.Name,
    arg1: harry.Children[0].Name
);

WriteLine("");
WriteLine("");
string s1 = "Hello";
string s2 = "World!";
string s3 = string.Concat(s1, s2);
string s4 = s1 + s2;
WriteLine(s3);
WriteLine(s4);

WriteLine("");
WriteLine($"5! is {Person.Factorial(5)}");

