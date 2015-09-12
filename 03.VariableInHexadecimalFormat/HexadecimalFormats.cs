/*
    Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”.
 */

using System;

class HexadecimalFormats
{
    static void Main()
    {
        int hexa = 0xFE;
        Console.WriteLine(" \"0x{0:X}\" == {0} ", hexa);
    }
}
