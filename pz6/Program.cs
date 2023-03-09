namespace pz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int flag = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                m = n + 1;
                flag = n + 1;
            }
            else
            {
                m = n;
                flag = n;
            }
            while (m < flag * 2)
            {
                if (m % 2 != 0)
                {
                    Console.WriteLine(m);
                }
                m += 1;
            }
        }
    }
}