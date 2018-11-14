using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the first player : ");
            string firstPlayer = Console.ReadLine();

            Console.Write("Enter the name of the second player : ");
            string secondPlayer = Console.ReadLine();

            Console.Clear();

            play(firstPlayer, secondPlayer);
        }

        private static void play(string firstPlayer, string secondPlayer)
        {
            Random rnd = new Random();

            int[,] firstPlayerDice = new int[6,2];
            int[,] secondPlayerDice = new int[6, 2];

            int fp_score = 0, sp_score = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    firstPlayerDice[i, j] = rnd.Next(1, 6);
                    secondPlayerDice[i, j] = rnd.Next(1, 6);

                    fp_score += firstPlayerDice[i, j];
                    sp_score += secondPlayerDice[i, j];
                }
            }

            string winner = fp_score > sp_score ? firstPlayer : secondPlayer;

            Console.WriteLine($"{firstPlayer}\t{secondPlayer}");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"({firstPlayerDice[i,0]}, {firstPlayerDice[i,1]})\t({secondPlayerDice[i, 0]}, {secondPlayerDice[i, 1]})");
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine($"{firstPlayer}'s score : {fp_score}");
            Console.WriteLine($"{secondPlayer}'s score : {sp_score}");

            Console.WriteLine();

            Console.WriteLine($"Winner : {winner}");
            
            Console.ReadLine();
        }
    }
}
