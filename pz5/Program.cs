namespace ConsoleApp1
{
    internal class Program
    {
        
            static void P(int a, out int b)
            {
                a = 44; b = 33;
                Console.WriteLine($" внутри метода {a} {b}");
            }
            static void Main(string[] args)
            {
                int a = 2, b;
                P(a, out b);
                Console.WriteLine($" после вызова {a} {b}");
            }

    }
}
