/*  Declare two string variables and assign them with following value:
        The "use" of quotations causes difficulties.
 */

using System;

class StringQuotes
{
    static void Main()
    {
        string first = @"The ""use"" of quotations causes difficulties.";
        string second = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine("{0}\r\n{1}", first, second);
    }
}
