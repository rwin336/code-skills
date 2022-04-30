Project setup

 $ dotnet new console -o CsLox
 $ dotnet new mstest -o CsLoxTests
 $ dotnet sln add ./CsLox/CsLox.csproj 
 $ dotnet sln add ./CsLoxTests/CsLoxTests.csproj 
 $ dotnet add AntlrCSharp package Antlr4.Runtime.Standard
 $ dotnet add CsLox package Antlr4.Runtime.Standard
 $ dotnet add CsLoxTests reference CsLox
 $ dotnet build
 $ dotnet run --project CsLox
 $ dotnet test 
 $ dotnet new console -o CsTools
 $ dotnet sln add ./CsTools/CsTools.csproj
 




