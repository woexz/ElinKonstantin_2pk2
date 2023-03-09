/*
 * Created by SharpDevelop.
 * User: elin.ky1685
 * Date: 20.10.2022
 * Time: 10:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace pz8
{
	class Program
	{
		public static void Main(string[] args)
		{
			int count = 0;
			int[,] myMass = new int[5, 5];
			for (int i = 0; i < 5; i++) 
			{
				for (int j = 0; j < 5; j++) 
				{
					myMass[i, j] = 0;
					Console.Write(myMass[i, j]);
				}
				count++;
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}