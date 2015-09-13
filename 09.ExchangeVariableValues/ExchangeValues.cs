/*  Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.
    Expected Output:  Before: a = 5, b = 10; After: a = 10, b = 5;
 */
using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:\r\na = {0}\r\nb = {1}", a, b);
        
        b = a;
        a += b;
        Console.WriteLine("After:\r\na = {0}\r\nb = {1}", a, b);
    }
}
