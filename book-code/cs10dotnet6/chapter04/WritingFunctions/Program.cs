using System;
using static System.Console;

namespace com.rwin.codeskills.cs10dotnet6.chap4.writingfunctions
{

    public class WritingFunctions
    {

        public static void Main(string[] args)
        {

            TimesTable(number: 6);
        


        }



        public static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table");

            for(int row = 1; row <= 12; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine("");
        }

    }



}