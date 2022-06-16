﻿using static System.Console;

namespace Packt.Shared; 


public class Person : object
{

    public string? Name;        // ? allows null
    public DateTime DateOfBirth;
    public List<Person> Children = new();   // C# 9 or later    

    // static method to "multiply"
    public static Person Procreate(Person p1, Person p2)
    {
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    // instance method to "multiply"
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

}
