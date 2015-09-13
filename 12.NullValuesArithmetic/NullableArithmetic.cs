/*  Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.
 */

using System;

class NullableArithmetic
{
    static void Main()
    {

        int? intNumber = null;
        double? doubleNumber = null;

        Console.WriteLine("Int= {0}; Double= {1}.", intNumber, doubleNumber);

        intNumber = 1 + null;
        doubleNumber = 1.0001 + null;

        Console.WriteLine("Int= {0}; Double= {1}.", intNumber, doubleNumber);
        Console.WriteLine("Int= {0}; Double= {1}.", intNumber.GetValueOrDefault(), doubleNumber.GetValueOrDefault());
    }
}
