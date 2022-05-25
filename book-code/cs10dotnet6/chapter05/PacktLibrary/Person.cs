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

    

}
