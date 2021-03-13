using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crap_A_Dappa
{
	/*
	 The 'CrapsGame' class consists of 2 enum data types and 5 methods, of which are the backbone 
	 of the program. This class utilizes the enums to either name special sums of the dice rolled, 
	 or contains the status of the game(s) until you are no longer in play. Switches are also used 
	 within this class to either evaluate the dice rolls where players will either win or lose on 
	 the first roll, or continue playing up to the desired amount of rolls.
	 */
	public class CrapsGame
	{
		private enum DiceSum //Defines the names for each sum of special roll IF these are the first roll of each game.
		{
			SnakeEyes = 2,
			Trey = 3,
			Seven = 7,
			YoLeven = 11,
			BoxCars = 12
		};
		public enum GameStatus //Defines the game status of either Win, Lose, or Continue.
		{
			Win,
			Lose,
			Continue
		};
		private RollDice _roll; 
		private GameStatus _gameStatus; 
		private DiceSum _diceSum; 
		private int _numRolls; 
		private int _sum; 
		private int _point; 
		public const int numGames = 500; //Edit this if you want to roll a different number of games.
		private Statistics _stats; 

		public CrapsGame()
		{
			_roll = new RollDice();
			_stats = new Statistics();
		}

		private void EvaluateRoll() // Defines switches if specific sums of the die are rolled on the first roll of the game. These are win/lose rolls.
		{
			switch (_sum)
			{
				case 7:
					_diceSum = DiceSum.Seven;
					_gameStatus = GameStatus.Win;
					_point = 0;
					_stats.SetStats(_numRolls, _gameStatus);
					break;
				case 11:
					_diceSum = DiceSum.YoLeven;
					_gameStatus = GameStatus.Win;
					_point = 0;
					_stats.SetStats(_numRolls, _gameStatus); 
					break;
				case 2:
					_diceSum = DiceSum.SnakeEyes;
					_gameStatus = GameStatus.Lose;
					_point = 0;
					_stats.SetStats(_numRolls, _gameStatus); 
					break;
				case 3:
					_diceSum = DiceSum.Trey;
					_gameStatus = GameStatus.Lose;
					_point = 0;
					_stats.SetStats(_numRolls, _gameStatus); 
					break;
				case 12:
					_diceSum = DiceSum.BoxCars;
					_gameStatus = GameStatus.Lose;
					_point = 0;
					_stats.SetStats(_numRolls, _gameStatus);
					break;
				default:
					_gameStatus = GameStatus.Continue;
					_point = _sum;
					break;
			}
		}

		private void DisplayMessage() //These Switches are used to display the game status to the player. 
		{
			switch (_gameStatus)
			{
				case GameStatus.Win:
					Console.WriteLine(_numRolls == 1
						? $"Congratulations, you rolled {_diceSum}. YOU WIN!\n"
						: $"Congratulations, you rolled {_sum}. YOU WIN!\n");
					break;
				case GameStatus.Lose:
					Console.WriteLine(_numRolls == 1
						? $"Sorry, you rolled {_diceSum}. YOU LOSE!\n"
						: $"Congratulations, you rolled {_sum}. YOU WIN!\n");
					break;
				default:
					Console.WriteLine($"You rolled {_sum}. Your point is {_point}. Keep rolling!");
					break;
			}
		}

		public void Play() //this is used to display the current game, and each roll of given game until you either win/lose.
		{
			for (int i = 0; i < numGames; i++)
			{
                Console.WriteLine($"\n\n###############  GAME # {i + 1}  ##################");
				_gameStatus = GameStatus.Continue;
				_numRolls = 0;

				_sum = _roll.DiceRoll();
				_numRolls++;
				EvaluateRoll();
				DisplayMessage();

				while (_gameStatus == GameStatus.Continue)
				{
					KeepPlaying();
					DisplayMessage();
				}
			}
			_stats.DisplayStatistics();
		}



		public void KeepPlaying() //this is used to provide the special conditions for each game.
		{
			_sum = _roll.DiceRoll();
			_numRolls++;

			if (_sum == _point)
			{
				_gameStatus = GameStatus.Win;
				_stats.SetStats(_numRolls, _gameStatus);
			}
			else if (_sum == 7)
			{
				_gameStatus = GameStatus.Lose;
				_stats.SetStats(_numRolls, _gameStatus);
			}
			else
			{
				_gameStatus = GameStatus.Continue;

			}
			
		}

	}
}