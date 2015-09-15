using System;
using System.Collections.Generic;
using System.Linq;

class EncryptedMatrix
{
    static void Main()
    {
        string message = Console.ReadLine();
        string checker = Console.ReadLine();

        int[] msgLastDigit = new int[message.Length];
        for (int i = 0; i < message.Length; i++)
        {
            msgLastDigit[i] = message[i] % 10;
        }

        string digits = string.Empty;
        int[] encryptDigits = new int[msgLastDigit.Length];
        for (int i = 0; i < msgLastDigit.Length; i++)
        {
            if (msgLastDigit[i] % 2 == 1)
            {
                if (msgLastDigit.Length == 1)
                {
                    digits += msgLastDigit[i];
                }
                else if (i == 0)
                {
                    digits += msgLastDigit[i] + msgLastDigit[i + 1];
                }
                else if (i == msgLastDigit.Length -1)
                {
                    digits += msgLastDigit[i] + msgLastDigit[i - 1];    
                }
                else
                {
                    digits += msgLastDigit[i] + msgLastDigit[i + 1] + msgLastDigit[i - 1];    
                }
            }
            else
            {
                digits += msgLastDigit[i] * msgLastDigit[i];
            }
        }

        int[,] matrix = new int[digits.Length, digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            int tmp;
            bool temp = int.TryParse(digits[i].ToString(), out tmp);
            matrix[i, i] = tmp;
        }

        if (checker == "\\")
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0,2}", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int r = matrix.GetLength(0)-1; r >= 0; r--)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0,2}", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
