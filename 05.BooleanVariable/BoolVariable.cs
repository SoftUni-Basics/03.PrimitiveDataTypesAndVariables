/*Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. Print it on the console.	
 */

using System;
using System.Collections.Generic;

class BoolVariable
{
    static void Main()
    {
        Console.WriteLine("Please follow some of examples for your answer:\r\n\t\" y, yes, n, no \"");
        Console.Write("\r\nYour gender is Female?\r\nAnswer:    ");
        string answer = Console.ReadLine();

        bool isFemale = true;
        
        List<string> genderFemale = new List<string>() { "y", "yes", };
        List<string> genderMale = new List<string>() { "n", "no", };

        for (int i = 0; i < genderFemale.Count; i++)
        {
            if (string.Equals(answer, genderFemale[i], StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("\r\nYour gender is Female:\r\n{0}\r\n", isFemale);
                return;
            }
            else if (string.Equals(answer, genderMale[i], StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("\r\nYour gender is Male:\r\n{0}\r\n", isFemale);
                return;
            }
        }
        Console.WriteLine("\r\nPlease enter valid answer!\r\n");
    }
}
