using System;
using Zad_1_Lib;

namespace Zad_1_Console
{
    class Program
    {
        private static double GenerateRandomScore()
        {
            Random rand = new Random();
            double number = 11;
            while (number > 10)
            {
                number = rand.NextDouble() * 11;
            }
            return number;
        }
        static void Main(string[] args)
        {
            Episode ep1, ep2;
            ep1 = new Episode();
            ep2 = new Episode(10, 64.39, 8.7);
            int viewers = 10;
            for (int i = 0; i < viewers; i++)
            {
                ep1.AddView(GenerateRandomScore());
                Console.WriteLine(ep1.GetMaxScore());
            }
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
            {
                Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
            }
            else
            {
                Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
            }
        }
    }
}

