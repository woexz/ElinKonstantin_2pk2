/*
 * Created by SharpDevelop.
 * User: elin.ky1685
 * Date: 03.11.2022
 * Time: 9:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace pz10
{
	class Program
	{
		public static void Main(string[] args)
		{
			string input = Console.ReadLine().ToLower();
			input = input.Replace(" ", "");
			char[] inputarray = input.ToCharArray();
			Array.Reverse(inputarray);
			string output = new string(inputarray);
			if (input == output){
				Console.WriteLine("Строка - палиндром");
			}
			else{
				Console.WriteLine("Строка не палиндром");
			}
			Console.ReadKey();
		}
	}
}