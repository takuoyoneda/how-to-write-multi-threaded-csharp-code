using System;
using System.Threading;

namespace multi_threading
{
	public class ThreadExample_01
	{

		private const int REPETITIONS = 1000;

		public static void DoWork()
		{
			for (int i = 0; i < REPETITIONS; i++)
			{
				Console.Write("B");
			}
		}

		public static void Main (string[] args)
		{
			Thread t1 = new Thread (new ThreadStart(DoWork));
			t1.Start();

			for(int i = 0; i < REPETITIONS; i++)
			{
				Console.Write("A");
			}
		}

	}
}

