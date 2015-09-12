/*Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the '\u00XX' syntax, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. */

using System;

class UnicodeChars
{
    static void Main()
    {
        char ch = '\u002A';
        Console.WriteLine("u{0:X4} == {0}", Convert.ToUInt32(ch), ch);
    }
}
