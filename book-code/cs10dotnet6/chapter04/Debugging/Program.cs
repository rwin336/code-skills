using System;

using static System.Console;

namespace com.rwin.codeskills.cs10dotnet6.chap4.debugging
{
    public class Debugging
    {
        static void Main(string[] args)
        {
            double a = 4.5;
            double b = 2.5;
            double answer = Add(a, b);

            WriteLine("Press ENTER to end the app");
            ReadLine();
        }


        static double Add(double a, double b)
        {
            return a * b;  // deliberate bug
        }

    }
}