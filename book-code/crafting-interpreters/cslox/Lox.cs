using System;

using static System.Console;


namespace com.craftinginterpreters.lox
{



    public class Lox 
    {
        static void Main(string[] args)
        {
            if(args.Length > 1) 
            {
                WriteLine("Usage: cslox [script]");
                System.Environment.Exit(64);
            } 
            else if(args.Length == 1)
            {
                RunFile(args[0]);
            }
            else
            {
                RunPrompt();
            }

        }


        private static void RunFile(string path)
        {

        }

        private static void RunPrompt() 
        {

        }
    }




}