using System;
using System.Threading;

namespace Lambda_capture
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i = 0; i < 10; i++) 
			{
				int number = i;
				Thread t = new Thread (() => {
                    //Console.WriteLine(i); // random result
                    Console.WriteLine(number); // sequential result
                });
				t.Start ();
			}

            Console.ReadLine();
        }
    }
}