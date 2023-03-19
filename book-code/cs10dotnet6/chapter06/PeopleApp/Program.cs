using Microsoft.VisualBasic;
using Packt.Shared;
using static System.Console;
using static System.Collections.Hashtable;

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

static void Harry_Shout(object? sender, EventArgs e)
{
    if(sender is null)
    {
        return;
    }
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

harry.Shout += Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

///////////////////////////////////////
// Working with non-generic types
WriteLine("");
System.Collections.Hashtable lookupObject = new();

lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;
WriteLine(format: "Key {0} has a value: {1}",
        arg0: key,
        arg1: lookupObject[key]);

WriteLine(format: "Key {0} has a value: {1}",
        arg0: harry.Name,
        arg1: lookupObject[harry]);

//////////////////////////////////////
// Working with generic types
WriteLine("");
// generic Loopup collection
Dictionary<int, string> lookupIntString = new();

lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
// fails to compile
// lookupIntString.Add(key: harry, value: "Delta");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has a value: {1}",
        arg0: key,
        arg1: lookupIntString[key]);

//////////////////////////////////////////
// Implementing interfaces
WriteLine("");

Person[] people =
{
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adman" },
    new() { Name = "Richard" }
};

WriteLine("Initial list of people:");
foreach(Person p in people)
{
    WriteLine($"  {p.Name}");
}

WriteLine("");
WriteLine("Use Person's IComparable implementation to sort:");
Array.Sort(people);

foreach(Person p in people)
{
    WriteLine($"  {p.Name}");
}

// Sort using Comparer
WriteLine("");
WriteLine("Use PersonComparer's IComparer implementation to sort:");
Array.Sort(people, new PersonComparer());
foreach(Person p in people)
{
    WriteLine($"    {p.Name}");
}


DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;

WriteLine();
WriteLine("Displacement Vector Addition");
WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

Employee john = new()
{
    Name = "John Jones",
    DateOfBirth = new(year: 1990, month: 7, day: 28)
};
WriteLine();
john.WriteToConsole();
john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

WriteLine();
