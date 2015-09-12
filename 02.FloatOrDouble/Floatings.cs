/*
    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */

using System;

class Floatings
    {
        static void Main()
        {
            //  34.567839023, 12.345, 8923.1234857, 3456.091
            double first = 34.567839023;
            float second = 12.345f;
            double third = 8923.1234857;
            float fourth = 3456.091f;

            Console.WriteLine("{0}\r\n{1}\r\n{2}\r\n{3}", first, second, third, fourth);
        }
    }
