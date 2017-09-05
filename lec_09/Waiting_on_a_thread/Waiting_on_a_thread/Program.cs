using System;
using System.Threading;

namespace Waiting_on_a_thread
{
	class MainClass
	{
		public static bool finished = false;

		public static void DoWork() 
		{
			// do lots of complicated work

			// signal that the thread is finished
			if (!finished) // unstable judgement
			{
                //finished = true; // "Finished!" can appear twice
                Console.WriteLine ("Finished!"); // slow operation
                finished = true; // "Finished!" appears twice
            }
        }

		public static void Main (string[] args)
		{
			// set up thread
			Thread t = new Thread (DoWork);
			t.Start ();

			// call DoWork on main program thread
			DoWork ();

            Console.ReadLine();
		}
	}
}
