/*
 * Created by SharpDevelop.
 * User: elin.ky1685
 * Date: 12.11.2022
 * Time: 12:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MeAndMethod
{
	class Program
	{
		public static void Main(string[] args)
		{
		    while (true) {
		    Console.Write("Введите год своего рождения: ");
			PrintYourYearOfDead(int.Parse(Console.ReadLine()));
		    }

			
			Console.ReadKey(true);
		}
		/// <summary>
		/// Выбирает случаную дату смерти специально для вас и выводит её в консоль
		/// </summary>
		public static void PrintYourYearOfDead(int yourAgeYear = 2022)
		{
			Random rndValua = new Random();

			int dayDead = rndValua.Next(1, 29);
			if(dayDead < 10)
			{
				Console.Write("Ваша дата смерти: " + "0" + dayDead + ".");
			}
			else
			{
				Console.Write("Ваша дата смерти: " + dayDead + ".");
			}
			
			int mounthDead = rndValua.Next(1, 12);
			if(mounthDead < 10)
			{
				Console.Write("0" + mounthDead + ".");
			}
			else
			{
				Console.Write(mounthDead + ".");
			}
			
			int yearDead = rndValua.Next(yourAgeYear, 2100);
			Console.WriteLine(yearDead);
			
			
		}
	}
}