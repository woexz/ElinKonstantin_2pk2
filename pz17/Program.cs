namespace pz17
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double value;
            void* ukazatel = &value;
            byte* bukazatel = (byte*)&ukazatel;

            bukazatel[0] = 1;
            bukazatel[1] = 2;
            Console.WriteLine($"{(ulong)&bukazatel[0]} {bukazatel[0]}");
            Console.WriteLine($"{(ulong)&bukazatel[1]} {bukazatel[1]}");

            int maxChar = (sizeof(double) - 2) * sizeof(byte) / sizeof(char);

        }
    }
}