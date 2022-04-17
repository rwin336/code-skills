using static System.Console;
 

WriteLine("");
WriteLine("Book:    \tC# 10 and .Net6");
WriteLine("Author:  \tMark J. Price");
WriteLine("Chapter: \t02");
WriteLine("Arguments");
WriteLine("");

WriteLine($"There are {args.Length} arguments");
foreach(string arg in args)
{
    WriteLine(arg);
}

WriteLine();

if(args.Length < 3) 
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true
);


BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true
);

try
{
    // not supported on Linux
    CursorSize = int.Parse(args[2]);
}
catch(PlatformNotSupportedException)
{
    WriteLine("The current Platform does not support changing the size of the cursor");
}

