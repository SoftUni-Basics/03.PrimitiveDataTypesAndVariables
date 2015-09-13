/*  Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
           ©
          © ©
         ©   ©
        © © © ©
 * Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
 */

using System;

class Triangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char symbol = '©';
        int start = 8;
        
        for (int i = 0; i < start/2; i++)
        {
            int curent = (start << i) | (start >> i);
            if ((curent & 1) == 1)
            {
                for (int j = 1; j <= start/2; j++)
                {
                    if ((j & 1) != 1)
                    {
                        curent |= (1 << j);
                    }
                }
            }
            string binary = Convert.ToString(curent, 2).PadLeft(8, '0');
            binary = binary.Replace('0', ' ').Replace('1', symbol);
            Console.WriteLine(binary);
        }
    }
}