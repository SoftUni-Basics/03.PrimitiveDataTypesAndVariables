using System;

class BasketBattle
{
    static void Main()
    {
        string[] names = { "Simeon", "Nakov" };
        string inputName = Console.ReadLine();

        if (inputName == "Nakov")
        {
            Array.Reverse(names);
        }

        int maxScore = 500;
        int firstPlayerPoints = 0;
        int secondPlayerPoints = 0;

        int rounds = int.Parse(Console.ReadLine());
        int countRounds = 1;

        for (int i = 0; i < rounds; i++)
        {
            if (countRounds % 2 != 0)
            {
                int point = int.Parse(Console.ReadLine());
                string success = Console.ReadLine();
                if (success == "success")
                {

                    if (firstPlayerPoints + point == maxScore)
                    {
                        Console.WriteLine(names[0]);
                        Console.WriteLine(countRounds);
                        Console.WriteLine(secondPlayerPoints);
                        return;
                    }

                    else if (firstPlayerPoints + point < maxScore)
                    {
                        firstPlayerPoints += point;
                    }
                }

                point = int.Parse(Console.ReadLine());
                success = Console.ReadLine();
                if (success == "success")
                {
                    if (secondPlayerPoints + point == maxScore)
                    {
                        Console.WriteLine(names[1]);
                        Console.WriteLine(countRounds);
                        Console.WriteLine(firstPlayerPoints);
                        return;
                    }

                    else if (secondPlayerPoints + point < maxScore)
                    {
                        secondPlayerPoints += point;
                    }
                }
            }

            else
            {
                int point = int.Parse(Console.ReadLine());
                string success = Console.ReadLine();
                if (success == "success")
                {
                    if (secondPlayerPoints + point == maxScore)
                    {
                        Console.WriteLine(names[1]);
                        Console.WriteLine(countRounds);
                        Console.WriteLine(firstPlayerPoints);
                        return;
                    }

                    else if (secondPlayerPoints + point < maxScore)
                    {
                        secondPlayerPoints += point;
                    }
                }

                point = int.Parse(Console.ReadLine());
                success = Console.ReadLine();
                if (success == "success")
                {
                    if (firstPlayerPoints + point == maxScore)
                    {
                        Console.WriteLine(names[0]);
                        Console.WriteLine(countRounds);
                        Console.WriteLine(secondPlayerPoints);
                        return;
                    }

                    else if (firstPlayerPoints + point < maxScore)
                    {
                        firstPlayerPoints += point;
                    }
                }
            }
            countRounds++;
        }


        if (firstPlayerPoints == secondPlayerPoints)
        {
            Console.WriteLine("DRAW");
            Console.WriteLine(firstPlayerPoints);
        }
        else
        {
            if (firstPlayerPoints > secondPlayerPoints)
            {
                Console.WriteLine(names[0]);
                Console.WriteLine(firstPlayerPoints - secondPlayerPoints);
            }
            else
            {
                Console.WriteLine(names[1]);
                Console.WriteLine(secondPlayerPoints - firstPlayerPoints);
            }
        }
    }
}