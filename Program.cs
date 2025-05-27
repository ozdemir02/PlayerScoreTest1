using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace PlayerScoreTest
{
    class Program
    {
        public static int playerScore = 100;
        private static bool isRunning = true;

        static void Main(string[] args)
        {
            Console.WriteLine("Tryk på tastatur for at ændre score:");
            Console.WriteLine("  [A] Tilføj 10 point");
            Console.WriteLine("  [S] Fjern 10 point");
            Console.WriteLine("  [Q] Afslut");
            Console.WriteLine($"Nuværende score: {playerScore}");

            while (isRunning)
            {
                // Tjekker om der er tastetryk
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.A:
                            playerScore += 10;
                            Console.WriteLine($"Score: {playerScore} (+10)");
                            break;
                        case ConsoleKey.S:
                            playerScore -= 10;
                            Console.WriteLine($"Score: {playerScore} (-10)");
                            break;
                        case ConsoleKey.Q:
                            isRunning = false;
                            break;
                    }
                }
                Thread.Sleep(100);
            }

        }
    }
}