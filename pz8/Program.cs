using System;

namespace pz8
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[,] array = new int[5, 5] {{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0},{0,0,0,0,0}};
            for (int k = 0; k < 5; k++)
            {
                int delta = 0;
                while (k + delta != 5)
                {
                    array[k + delta, delta] = k + 1;
                    array[delta, k + delta] = k + 1;
                    delta += 1;
                }
            }
            for (int i = 0; i < 5; ++i)
            {
                for (int k = 0; k < 5; k++)
                {
                    Console.Write(array[i, k]);
                }
                Console.WriteLine("");
            }
        }
	}
}
