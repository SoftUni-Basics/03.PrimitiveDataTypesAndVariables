/*  Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */
using System;

class ComparingFloats
{
    static void Main()
    {
        decimal eps = 0.000001m;

        decimal[] arrayA = {  5.3m, 5.00000001m, 5.00000005m, -0.0000007m, -4.999999m, 4.999999m };
        decimal[] arrayB = { 6.01m, 5.00000003m, 5.00000001m, 0.00000007m, -4.999998m, 4.999998m };

        for (int index = 0; index < arrayA.Length; index++)
        {
            decimal difference = Math.Abs(arrayA[index] - arrayB[index]);

            if (difference == eps)
            {
                Console.WriteLine("false:\t" + "Border case. The difference {0:0.########} == eps.\r\n\tWe consider the numbers are different.", difference);
            }
            else if (difference < eps)
            {
                Console.WriteLine("True:\t" + "The difference {0:0.########} < eps", difference);   
            }
            else
            {
                Console.WriteLine("false:\t" + "The difference of {0:0.########} is too big (> eps)", difference);
            }
        }
    }
}
