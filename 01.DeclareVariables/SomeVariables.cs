/*
    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.
 */

using System;

class SomeVariables
{
    static void Main()
    {
        // 52130, -115, 4825932, 97, -10000
        ushort first = 52130;
        sbyte second = -115;
        int third = 4825932;
        byte fourth = 97;
        short fifth = -10000;

        Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}", first, second, third, fourth, fifth);
    }
}
