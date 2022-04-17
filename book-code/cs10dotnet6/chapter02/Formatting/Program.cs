using static System.Console;

WriteLine("");
WriteLine("Book:    \tC# 10 and .Net6");
WriteLine("Author:  \tMark J. Price");
WriteLine("Chapter: \t02");
WriteLine("Formatting");
WriteLine("");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);

WriteLine(formatted);
// WriteToFile(formatted);

WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

WriteLine("");

string applesText = "Apples";
int appleCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: "Name",
    arg1: "Count"
);

WriteLine(
    format: "{0, -10} {1,6:N0}",
    arg0: applesText,
    arg1: appleCount
);

WriteLine(
    format: "{0, -10} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount
);

WriteLine("");

Write("Type your first name and press Enter: ");
string? firstName = ReadLine();

Write("Type you age and press Enter: ");
string? age = ReadLine();

WriteLine($"Hello {firstName}, you look good for {age}");

WriteLine();

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
if(key.Key == ConsoleKey.UpArrow) {

} 
string? line = ReadLine();

WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers
);
WriteLine($"L: {line}");

WriteLine();