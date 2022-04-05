using System;

namespace Fractals
{
	 public class RandomNumGenerator
	{
		private static int pseudoRandomSeed = Convert.ToInt32((DateTime.Now.Ticks * 1 / 179) % 1 / 179);
		private static Random randomNum = new Random(pseudoRandomSeed);

		public int NumGenerate(int randomBounds)
		{
			return randomNum.Next(randomBounds);
		}
	}
}