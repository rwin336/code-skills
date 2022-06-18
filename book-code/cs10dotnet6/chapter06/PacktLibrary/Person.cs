﻿using static System.Console;

namespace Packt.Shared; 


public class Person : object, IComparable<Person>
{

    public string? Name;        // ? allows null
    public DateTime DateOfBirth;
    public List<Person> Children = new();   // C# 9 or later

    public event EventHandler? Shout;

    // data field
    public int AngerLevel;

    // method
    public void Poke()
    {
        AngerLevel++;

        if(AngerLevel >= 3)
        {
            // if something is Listening
            if(Shout != null)
            {
                // ... then call the delegate
                Shout(this, EventArgs.Empty);
            }
        }
    }

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

    public static Person operator *(Person p1, Person p2)
    {
        return Person.Procreate(p1, p2);
    }

    public static int Factorial(int number)
    {
        if( number < 0 )
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero");
        }
        return localFactorial(number);

        int localFactorial(int localNumber)
        {
            if(localNumber < 1)
            {
                return 1;
            } 
            return localNumber * localFactorial(localNumber - 1);
        }
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

    public int CompareTo(Person? other)
    {
        if(Name is null)
        {
            return 0;
        }
        return Name.CompareTo(other?.Name);
    }
}
