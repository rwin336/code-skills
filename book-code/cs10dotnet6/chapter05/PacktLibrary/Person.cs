using System;
using System.Collections.Generic;  // List<T>
using static System.Console;

namespace Packt.Shared;

public class Person : object
{
    // fields
    public string Name;
    public DateTime DateOfBirth;

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public WondersOfTheAncientWorld BucketList;

    public List<Person> Children = new List<Person>();

    public const string Species = "Homo Sapien";

    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;

    // construct
    public Person()
    {
        // set default values for fields
        // include read-only fields
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now; 
    }
    
    // methods 
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}.";
    }

    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    public (string Name, int Number) GetNamedFruit()
    {
        return (Name: "Apples", Number: 5);
    }

    // deconstructors
    public void Deconstruct(out string name, out DateTime dob)
    {
        name = Name;
        dob = DateOfBirth;
    }

    public void Deconstruct(out string name, 
        out DateTime dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = DateOfBirth;
        fav = FavoriteAncientWonder;
    }

}
