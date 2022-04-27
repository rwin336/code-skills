Book info

Title:		Practical Numerical methods with C#
Edition:	2nd
Sub title:	Numerical Programming and Math Functions for
    		Real-World .NET Applications with C#
Author:		Jack Xu, PhD
Release date:	2019


========================================================================
Programming notes:

The book requires MathNet.Numerics package.  To install that package
use the following in the project directory.

 $ dotnet add package MathNet.Numerics

this should add the following to the project file.

  <ItemGroup>
    <PackageReference Include="MathNet.Numerics" Version="5.0.0" />
  </ItemGroup>

Test that it is available in the code by importing and running a simple cmd.

------------------------------
Code:
  using System;
  using MathNet.Numerics.LinearAlgebra;
  using static System.Console;

  Vector<double> v = Vector<double>.Build.Dense(5);

  WriteLine($"A Dense Vector: {v}");

-------------------------------
Output:
  $ dotnet build
  $ dotnet run
  A Dense Vector: DenseVector 5-Double
  0
  0
  0
  0
  0


