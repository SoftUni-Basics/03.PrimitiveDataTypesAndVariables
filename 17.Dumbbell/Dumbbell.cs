using System;

class Dumbbell
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        
        Console.WriteLine("{0}{1}&{2}&{1}{0}", new string('.', input / 2), new string('&', input / 2), new string('.', input));
        for (int i = 1; i <= (input / 2) - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                new string('.', (input / 2) - i), new string('*', (input / 2) + i-1), new string('.', input));
        }
        Console.WriteLine("&{0}&{1}&{0}&", new string('*', input - 2), new string('=', input));
        for (int i = 1; i <= (input / 2) - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", 
                new string('.', i), new string('*', (input - 2) - i), new string('.', input));
        }
        Console.WriteLine("{0}{1}&{2}&{1}{0}", new string('.', input / 2), new string('&', input / 2), new string('.', input));
    }
}
