using System;
using System.Threading;

namespace PlayerScoreTest
{
    class Player
    {
        public int Score = 100;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Player player = new Player();
            bool isRunning = true;


            Console.WriteLine("Velkommen til Score Test!");
            Console.WriteLine("Tryk på tastatur for at ændre score:");
            Console.WriteLine("  [A] Tilføj 10 point");
            Console.WriteLine("  [S] Fjern 10 point");
            Console.WriteLine("  [Q] Afslut");
            Console.WriteLine($"Nuværende score: {player.Score}");

            while (isRunning)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.A:
                            player.Score += 10;
                            Console.WriteLine($"Score: {player.Score} (+10)");
                            break;
                        case ConsoleKey.S:
                            player.Score -= 10;
                            Console.WriteLine($"Score: {player.Score} (-10)");
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