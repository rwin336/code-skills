using static System.Console;
using System.Xml;

WriteLine("");
WriteLine("Book:    \tC# 10 and .Net6");
WriteLine("Author:  \tMark J. Price");
WriteLine("Chapter: \t02");
WriteLine("Variables");
WriteLine("");

object height = 1.88;
object name = "Amir";

WriteLine($"{name} is {height} metres tall");


//int length1 = name.Length;
int length2 = ((string)name).Length;
WriteLine($"{name} has {length2} characters.");

// storing a string in a dynamic object
// string has a Length property
dynamic something  = "Ahmed";

// int does not have a Length property
//something = 12;

// an array of any type has a length property
something = new[] { 3, 5, 7};

// this compiles but would throw an exception at run-time
// if you later store a data type that does not have a 
// property named Length
WriteLine($"Length is {something.Length}");

var population = 66_000_000;    // 66 million in UK
var weight = 1.88;              // in kilos
var price = 4.99M;              // in pounds sterling
var fruit = "Apples";           // strings use double-quotes
var letter = 'Z';               // chars use single-quotes
var happy = true;               // Booleans have value of true or false

// good use of var because it avoids the repeated type
// as show in the more verbose second statement.
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in 
// second statement.
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

WriteLine("");
WriteLine($"default(int) = {default(int)}");
WriteLine($"default(bool) = {default(bool)}");
WriteLine($"default(DateTime) = {default(DateTime)}");
WriteLine($"default(string) = {default(string)}");

WriteLine("");
int number = 13;
WriteLine($"number has be sent to: {number}");

number = default;
WriteLine($"number has been reset to its default: {number}");

WriteLine("");
string[] names;  // can reference any size array of strings

// allocating memory for four strings in an array
names = new string[4];

// storing items at index positions
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";

// Lopping through the names
for(int i = 0; i < names.Length; i++)
{
    WriteLine(names[i]);
}

WriteLine("");
