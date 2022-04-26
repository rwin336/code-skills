using System;
using static System.Console;

namespace com.craftinginterpreters.lox
{
    public class Lox 
    {
        static bool hadError;
        
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

       public static bool scan(string line) {
            hadError = false;
            run(line);
            return hadError;
        }

        private static void RunFile(string path)
        {
            run(File.ReadAllText(path));
            if(hadError)
            {
                System.Environment.Exit(65);
            }
        }

        private static void RunPrompt() 
        {
            string? line;
            for(;;)
            {
                Write("> ");
                line = Console.ReadLine();
                if(line == null) 
                {
                    break;
                }
                run(line);
                hadError = false;
           }
        }

        private static void run(string source)
        {
            Scanner scanner = new Scanner(source);
            List<Token> tokens = scanner.scanTokens();

            foreach(Token token in tokens)
            {
                WriteLine($"{token}");
            }
        }

        public static void error(int line, string message)
        {
            report(line, "", message);
        }

        private static void report(int line, string where, string message)
        {
            Error.WriteLine($"[line {line} ] Error: {where}:{message}");
            hadError = true;
        }
    }
}