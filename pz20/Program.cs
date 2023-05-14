namespace pz20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            Console.WriteLine(Register(stroka));
        }
        static string Register(string stroka)
        {
            string time_str = "0";
            if (Char.IsUpper(stroka[0]))
                time_str = Convert.ToString(stroka[0]).ToLower();
            else
                time_str = Convert.ToString(stroka[0]).ToUpper();
            for (int i = 1; i < stroka.Length; i++)
            {
                if (Char.IsUpper(stroka[i]))
                {
                    time_str += Convert.ToString(stroka[i]).ToLower();
                }
                else if (Char.IsLower(stroka[i]))
                {
                    time_str += Convert.ToString(stroka[i]).ToUpper();
                }
            }
            return time_str;
        }
    }
}