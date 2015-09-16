using System;
using System.Collections.Generic;

class GameOfBits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int numberOfBits = 0;
        for (int i = 0; i < 30; i++)
        {
            string command = Console.ReadLine();
            if (command == "Odd")
            {
                number = BitExtracting(number);
            }
            else if (command == "Even")
            {
                number = number >> 1;
                number = BitExtracting(number);
            }
            else if (command == "Game Over!")
            {
                numberOfBits = BitCounting(number);
                break;
            }
        }

        Console.WriteLine("{0} -> {1}", number, numberOfBits);
    }

    static int BitCounting(uint number)
    {
        uint mask = 1;
        int bits = 0;
        for (int i = 0; i < 32; i++)
        {
            if (((number >> i) & mask) == 1)
            {
                bits++;
            }
            else if ((number >> i) == 0)
            {
                break;
            }
        }
        return bits;
    }

    static uint BitExtracting(uint number)
    {
        uint mask = 1;
        uint curent = 0;
        uint result = 0;

        for (int i = 0; i < 32; i += 2)
        {
            curent = number & (mask << i);
            result |= curent >> (i / 2);
        }
        number = result;

        return number;
    }
}
