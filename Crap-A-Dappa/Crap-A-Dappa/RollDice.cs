using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crap_A_Dappa
{
	public class RollDice
	{
		private Random _rand = new Random();
		public int Die1 { get; set; }
		public int Die2 { get; set; }

		public int DiceRoll()
		{
			Die1 = _rand.Next(1, 7);
			Die2 = _rand.Next(1, 7);

			return Die1 + Die2;
		}
	}
}
