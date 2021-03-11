using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crap_A_Dappa
{
    public class Statistics
    {
        public static int[] Wins = new int[22];
        public static int[] Losses = new int[22];

        public double AverageLength()
        {
            double avg;
            int sumOfRounds = 0;

            for (int i = 1; i <= 21; i++)
            {
                sumOfRounds += (Wins[i] * i) + (Losses[i] * i);
            }

            avg = (sumOfRounds * 1.0) / (Wins.Sum() + Losses.Sum());
            return avg;
        }
        public void SetStats(int round, CrapsGame.GameStatus result)
        {
            if (result == CrapsGame.GameStatus.Win)
            {
                if (round <= 20)
                    Wins[round] += 1;
                else
                    Wins[21] += 1;
            }
            else if (result == CrapsGame.GameStatus.Lose)
            {
                if (round <= 20)
                    Losses[round] += 1;
                else 
                    Losses[21] += 1;

            }
        }


        public void DisplayStatistics()
        {
            double probability;
            double avg;

            for (int i = 1; i <= 21; i++)
            { 
                if (i == 21)
                    Console.WriteLine($"Round 21 or more wins: {Wins[i]}");
                else
                    Console.WriteLine($"Round {i} wins: {Wins[i]}");
            }

            for (int i = 1; i <= 21; i++)
            {
                if (i == 21)
                    Console.WriteLine($"Round 21 or more loses: {Losses[i]}");
                else
                    Console.WriteLine($"Round {i} loses: {Losses[i]}");
            }

            probability = ProbabilityOfWinning();
            Console.WriteLine($"Chances of winning the game of Craps is {probability:P}");
            Console.WriteLine($"Average length of a game of Craps is {AverageLength():N2} rounds");
        }

        public double ProbabilityOfWinning()
        {
            return (Wins.Sum() * 1.0) / (Wins.Sum() + Losses.Sum());
        }
    }
}
