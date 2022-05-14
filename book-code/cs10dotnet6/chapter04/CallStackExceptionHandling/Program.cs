using System;
using Packet;
using Microsoft.Extensions.Logging;
using static System.Console;

WriteLine("In Main");
Alpha();

static void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

static void Beta()
{
    WriteLine("In Beta");

    try 
    {
        Calculator.Gamma();
    }
    catch(IOException ex)
    {
        WriteLine($"Caught this: {ex.Message}");
        throw ex;

        //LogException(ex);
        //
        //throw ex;
        //
        //throw;
        //
        //throw new InvalidOperationException(
        //    message: "Calculation had invalid values.  See inner exception for why.",
        //    innerException: ex
        //);
    }
}