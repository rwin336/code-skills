﻿using System;
using static System.Console;

namespace com.rwin.codeskills.cs10dotnet6.chap4.writingfunctions
{

    public class WritingFunctions
    {

        public static void Main(string[] args)
        {
            //TimesTable(number: 6);

            //decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "FR");
            //WriteLine($"You must pay {taxToPay} in tax.");

            //RunCardinalToOrdianl();

            //RunFactorial();

            //RunFibImperative();
            RunFibFunctional();
        }

        static void RunFibFunctional()
        {
            for(int i = 1; i <= 30; i++)
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                  arg0: CardinalToOrdinal(i),
                  arg1: FibFunctional(term: i));
            }
        }


        static int FibFunctional(int term) =>
          term switch
          {
              1 => 0,
              2 => 1,
              _ => FibFunctional(term - 1) + FibFunctional(term - 2)
          };

        static void RunFibImperative()
        {
            for(int i = 1; i <= 30; i++)
            {
                WriteLine("The {0} term of Fibonacci sequence is {1:N0}.", 
                    arg0: CardinalToOrdinal(i), 
                    arg1: FibImperative(term: i));
                
            }
        }

        static int FibImperative(int term)
        {
            if(term == 1)
            {
                return 0;
            }
            else if(term == 2)
            {
                return 1;
            }
            else 
            {
                return FibImperative(term -1) + FibImperative(term - 2);
            }
        }

        static void RunFactorial()
        {
            for(int i = 1; i < 15; i++)
            {
                try {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch(System.OverflowException)
                {
                    WriteLine($"{i}! is too big for a 32-bit integer");
                }
            }
        }

        static int Factorial(int number)
        {
            if(number < 1)
            {
                return 0;
            }
            else if(number == 1)
            {
                return 1;
            }
            else 
            {
                checked 
                {
                    return number * Factorial(number - 1);
                }
            }
        }

        static void RunCardinalToOrdianl()
        {
            for(int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }

        static string CardinalToOrdinal(int number)
        {
            switch(number)
            {
                case 11:  // special cases for 11th to 13th
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;

                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }


        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;

            switch(twoLetterRegionCode)
            {
                case "CH":  //SwitzerLand
                    rate = 0.08M;
                    break;
                case "DK":  // Denmark
                case "NO":  // Norway
                    rate = 0.25M;
                    break;
                case "GB":  // United Kingdom
                case "FR":  // France
                    rate = 0.2M;
                    break;
                case "HU":  // Hungary
                    rate = 0.27M;
                    break;
                case "OR":  // Oregon
                case "AK":  // Alaska
                case "MT":  // Montana
                    rate = 0.0M;
                    break;
                case "ND":  // North Dakota
                case "WI":  // Wisconsin
                case "ME":  // Maine
                case "VA":  // Virgina
                    rate = 0.05M;
                    break;
                case "CA":  // California
                    rate = 0.0825M;
                    break;
                default:    // Most US States
                    rate = 0.06M;
                    break;
            }

            return amount * rate ;
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