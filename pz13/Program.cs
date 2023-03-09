using System.ComponentModel.DataAnnotations;

namespace pz13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                array[i] = rnd.Next(-35, 35);
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(GetArray(array));
        }
        static int GetArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}