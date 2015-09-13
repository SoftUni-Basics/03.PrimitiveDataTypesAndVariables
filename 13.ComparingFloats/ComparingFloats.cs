/*  Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
 */
using System;

class ComparingFloats
{
    static void Main()
    {
        double eps = 0.000001;

        double[] arrayA = {  5.3, 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999 };
        double[] arrayB = { 6.01, 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998 };

        for (int index = 0; index < arrayA.Length; index++)
        {
            double difference = Math.Abs(arrayA[index] - arrayB[index]);

            if (Math.Floor(difference * 1000000) == (eps * 1000000))
            {
                Console.WriteLine("false:\t" + "Border case. The difference {0:0.########} == eps.\r\n\tWe consider the numbers are different.", difference);
            }
            else if (Math.Floor(difference * 1000000) < 1)
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
