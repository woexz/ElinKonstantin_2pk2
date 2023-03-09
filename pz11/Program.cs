using System.Security.Cryptography;

namespace pz11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            double S1, S2, P1, P2;
            CalculationOfArea(a1, b1, a2, b2, out S1, out S2);
            CalculationOfPerimeter(a1, b1, a2, b2, out P1, out P2);
            if (S1 == S2)
            {
                Console.WriteLine("Площадь первого треугольника равна площади второго");
            }
            if (S1 < S2)
            {
                Console.WriteLine("Площадь первого треугольника меньше площади второго");
            }
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            }
            if (P1 == P2)
            {
                Console.WriteLine("Периметр первого треугольника равен периметру второго");
            }
            if (P1 < P2)
            {
                Console.WriteLine("Периметр первого треугольника меньше периметру второго");
            }
            if (P1 > P2)
            {
                Console.WriteLine("Периметр первого треугольника больше периметру второго");
            }
        }
        static void CalculationOfArea(int a1, int b1, int a2, int b2, out double S1, out double S2)
        {
            S1 = (a1 * b1) / 2;
            S2 = (a2 * b2) / 2;
        }
        static void CalculationOfPerimeter(int a1, int b1, int a2, int b2, out double P1, out double P2)
        {
            P1 = Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2)) + a1 + b1;
            P2 = Math.Sqrt(Math.Pow(a2, 2) + Math.Pow(b2, 2)) + a2 + b2;
        }
    }
}