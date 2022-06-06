using static System.Console;

namespace Packt.Shared; 


public class Person : object
{

    public string? Name;        // ? allows null
    public DateTime DateOfBirth;
    public List<Person> Children = new();   // C# 9 or later    

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

}
