﻿using System;
using Packt.Shared;
using static System.Console;

// var bob = new Person();  // C# 1.0 or later
Person bob = new();         // C# 9.0 or later
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = 
    WondersOfTheAncientWorld.HangingGardenOfBabylon 
    | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

bob.Children.Add(new Person { Name = "Alfred"});   // C# 3.0 or later
bob.Children.Add(new() { Name = "Zoe"});

WriteLine(bob.ToString());
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}", 
    arg0: bob.Name, 
    arg1: bob.DateOfBirth);
WriteLine(
    format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name,
    arg1: bob.FavoriteAncientWonder,
    arg2: (int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name}' bucket list is {bob.BucketList}");
WriteLine(
    $"{bob.Name} has {bob.Children.Count} children");

for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"  {bob.Children[childIndex].Name}");
}
WriteLine("");

Person alice = new() 
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7)
};

WriteLine(format: "{0} was born on {1:dd MMM yy}",
    arg0: alice.Name,
    arg1: alice.DateOfBirth);
WriteLine();

BankAccount.InterestRate = 0.012M;  // store a shared value

BankAccount jonesAccount = new();  // C# 9.0 or later
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine(
    format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate
);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine(
    format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate
);

WriteLine($"{bob.Name} is a {Person.Species}");

WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

Person blankPerson = new();

WriteLine(format:
  "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
  arg0: blankPerson.Name,
  arg1: blankPerson.HomePlanet,
  arg2: blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

WriteLine(format:
    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Name} {fruitNamed.Number}");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} childern");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} childern");

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));
