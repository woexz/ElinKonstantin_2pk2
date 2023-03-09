namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\Костя\текстовые файлы\pz15.txt";
            //FileStream file1 = new FileStream(path);
            StreamReader streamReader = new StreamReader(path);
            string max_surname = "";
            int year = 100000000;
            int month = 100000000;
            int day = 100000000;
            string[] array = streamReader.ReadToEnd().Split('\n');
            for (int i = 0; i < array.Length; i++)
            {
                string[] array_of_string = array[i].Split();
                string[] array_of_data = array_of_string[0].Split("-");
                int[] int_array_of_data = new int[array_of_data.Length];
                foreach (string item in array_of_string)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------------------");
                foreach (string item in array_of_data)
                {
                    Console.WriteLine(item);
                }
                
                Console.WriteLine("------------------------------------");


                for (int j = 0; j < array_of_data.Length; j++)
                {
                    int_array_of_data[j] = int.Parse(array_of_data[j]);
                }


                foreach (int item in int_array_of_data)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------------------");
                if (int_array_of_data[0] < year)
                {
                    year = int_array_of_data[0];
                    max_surname = array_of_string[1];
                    continue;
                }
                if (int_array_of_data[0] > year)
                {
                    continue;
                }
                if (int_array_of_data[1] < month)
                {
                    month = int_array_of_data[1];
                    max_surname = array_of_string[1];
                    continue;
                }
                if (int_array_of_data[1] > month)
                {
                    continue;
                }
                if (int_array_of_data[2] < day)
                {
                    day = int_array_of_data[2];
                    max_surname = array_of_string[1];
                }
            }

            foreach  (string item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(max_surname);
        }
    }
}