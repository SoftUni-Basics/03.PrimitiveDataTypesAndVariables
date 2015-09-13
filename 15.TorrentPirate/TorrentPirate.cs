/*  Exam Problems 1 */

using System;

class TorrwntPirate
{
    static void Main()
    {
        double download = int.Parse(Console.ReadLine());
        int cinemaPrice = int.Parse(Console.ReadLine());
        int wifeSpend = int.Parse(Console.ReadLine());

        double downloadTime = download / (2 * 60 * 60);
        double downloadMovies = download / 1500;
        double wifeCost = downloadTime * wifeSpend;

        double cinema = cinemaPrice * downloadMovies;

        if (cinema < wifeCost)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinema);
        }
        else if (wifeCost <= cinema)
        {
            Console.WriteLine("mall -> {0:F2}lv", wifeCost);
        }
    }
}
