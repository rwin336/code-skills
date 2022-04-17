using static System.Console;
using System.Xml;

WriteLine("");
WriteLine("Book:    \tC# 10 and .Net6");
WriteLine("Author:  \tMark J. Price");
WriteLine("Chapter: \t02");
WriteLine("Exercise 2.3 Practice number sizes and ranges");
WriteLine("");

string header = String.Format("Type     {0,-30}  Min                            Max", "Byte(s) of memory");
string separator = "---------------------------------------------------------------------------";
WriteLine(separator);
WriteLine(header);
WriteLine(separator);

string[] types = {"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"};
Dictionary<string, int> sizeOfTypes = new Dictionary<string, int>{
    {"sbyte", sizeof(sbyte)},
    {"byte", sizeof(byte)},
    {"short", sizeof(short)},
    {"ushort", sizeof(ushort)},
    {"int", sizeof(int)},
    {"uint", sizeof(uint)},
    {"long", sizeof(long)},
    {"ulong", sizeof(ulong)},
    {"float", sizeof(float)},
    {"double", sizeof(double)},
    {"decimal", sizeof(decimal)}
    };
Dictionary<string, string> typeMin = new Dictionary<string, string>{
    {"sbyte", sbyte.MinValue.ToString()},
    {"byte", byte.MinValue.ToString()},
    {"short", short.MinValue.ToString()},
    {"ushort", ushort.MinValue.ToString()},
    {"int", int.MinValue.ToString()},
    {"uint", uint.MinValue.ToString()},
    {"long", long.MinValue.ToString()},
    {"ulong", ulong.MinValue.ToString()},
    {"float", float.MinValue.ToString()},
    {"double", double.MinValue.ToString()},
    {"decimal", decimal.MinValue.ToString()}
};

Dictionary<string, string> typeMax = new Dictionary<string, string>{
    {"sbyte", sbyte.MaxValue.ToString()},
    {"byte", byte.MaxValue.ToString()},
    {"short", short.MaxValue.ToString()},
    {"ushort", ushort.MaxValue.ToString()},
    {"int", int.MaxValue.ToString()},
    {"uint", uint.MaxValue.ToString()},
    {"long", long.MaxValue.ToString()},
    {"ulong", ulong.MaxValue.ToString()},
    {"float", float.MaxValue.ToString()},
    {"double", double.MaxValue.ToString()},
    {"decimal", decimal.MaxValue.ToString()}
};

string line;
foreach(string type in types)
{
    line = String.Format("{0,-8} {1,-4:D} {2,30:D} {3,30:D}", type, sizeOfTypes[type], typeMin[type], typeMax[type]);
    WriteLine(line);
}
