namespace pz18
{
    internal class Program
    {
        enum Marks : int{ so_bad = 1, still_bad, ok, good, excellent };
        static void Main(string[] args)
        {
            int mark = Convert.ToInt16(Console.ReadLine());
            switch (mark)
            {
                case Marks.so_bad:
                    break;
                case Marks.still_bad:
                    break;
                case Marks.ok:
                    break;
                case Marks.good:
                    break;
                case (int)Marks.excellent:
                    break;
                default:
                    break;
            }
        }
    }
}