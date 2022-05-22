using System;
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

