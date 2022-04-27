using System;
using System.Collections;
using static System.Console;

int x = 0;

while(x < 10)
{   
    WriteLine(x);
    x++;
}

string? password;
int i = 0;
do
{
    Write("Enter your password: ");
    password = ReadLine();
    i++;
}
while(password != "Pa$$w0rd" && i < 10);

if(i < 10) 
{
    WriteLine("Correct");
}
else
{
    WriteLine("Too many password attempts");
}

for(int y = 1; y <= 10; y++)
{
    WriteLine(y);
}


string[] names = {"Adam", "Barry", "Charlie"};
foreach(string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

IEnumerator e = names.GetEnumerator();
while(e.MoveNext())
{
    string name = (string)e.Current;  // Current is readonly
    WriteLine($"{name} has {name.Length} characters");
}

