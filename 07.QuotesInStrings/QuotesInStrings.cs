/*Declare two string variables and assign them with following value: 
The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.*/
using System;
using System.Net.Configuration;
using System.Runtime.Remoting.Channels;

internal class QuotesInStrings
{
    private static void Main()
    {
        string withoutQuotes = "\"The \"use\" of quotations causes difficulties.\"";
        string withQuotes = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(withoutQuotes);
        Console.WriteLine(withQuotes);
    }
}

