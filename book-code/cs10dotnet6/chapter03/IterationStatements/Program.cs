using System;
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


