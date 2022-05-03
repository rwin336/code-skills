using System;
using static System.Console;


namespace com.craftinginterpreters.lox.tools
{
    
    public class GenerateAst
    {
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Error.WriteLine("Usage: run <output directory>");
                System.Environment.Exit(64);
            }
            string outputDir = args[0];
            defineAst(outputDir, "Expr", new List<string>(){
                "Binary   : Expr left, Token oper, Expr right",
                "Grouping : Expr expression",
                "Literal  : Object value",
                "Unary    : Token oper, Expr right"
            });

        }

        private static void defineAst(string outputDir, string baseName, List<string>types)
        {

            string path = outputDir + "/" + baseName + ".cs";

            FileStream  fs = new FileStream(path,FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine("// * * * Auto Generated - Do not edit  * * * ");
            writer.WriteLine("//");
            writer.WriteLine("// GenerateAst:   1.0");
            writer.WriteLine($"// Date:          {DateTime.Now}");
            writer.WriteLine("//");
            writer.WriteLine("namespace com.craftinginterpreters.lox ");
            writer.WriteLine("{");
            writer.WriteLine("");
            writer.WriteLine("  abstract class " + baseName);
            writer.WriteLine("  {");
            foreach(string type in types)
            {
                string className = type.Split(":")[0].Trim();
                string fields = type.Split(":")[1].Trim();
                defineType(writer, baseName, className, fields);
            }

            writer.WriteLine("");
            writer.WriteLine("  }");
            writer.WriteLine("}");
            writer.Close();
        }


        private static void defineType(StreamWriter writer, string baseName, string className, string fieldList)
        {
            writer.WriteLine("");
            writer.WriteLine("");
            writer.WriteLine($"    class {className} : {baseName} " );
            writer.WriteLine( "    {");

            writer.WriteLine($"      {className}({fieldList}) ");
            writer.WriteLine( "      {");

            string[] fields = fieldList.Split(", ");
            foreach(string field in fields)
            {
                string name = field.Split(" ")[1];
                writer.WriteLine($"        this.{name} = {name};");
            }
            writer.WriteLine( "      }");

            writer.WriteLine("");
            foreach(string field in fields)
            {
                writer.WriteLine($"      readonly {field};");
            }
            writer.WriteLine("    }");
        }
    }

}
