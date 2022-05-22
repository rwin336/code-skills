using System;
using Packt.Shared;
using static System.Console;

// var bob = new Person();  // C# 1.0 or later
Person bob = new();         // C# 9.0 or later
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

WriteLine(bob.ToString());
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}", 
    arg0: bob.Name, 
    arg1: bob.DateOfBirth);
WriteLine(
    format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);

Person alice = new() 
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};

WriteLine(format: "{0} was born on {1:dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);
