namespace FileDemo2
{
    internal class Program
    {
        /// <summary>
        /// задание: реализовать считывание из файла в массив построчно.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int count = 0;
            //создать файл

            string filename = @"F:\Костя\pzs\text.txt";
            FileInfo file = new FileInfo(filename);

            if (!file.Exists) //если файл не существует,
            {
                file.Create(); // создаем файл
            }

            Console.WriteLine("enter text>>");
            //построчно ввести в него текст
            using (StreamWriter sw = new StreamWriter(filename)) //открытие потока на запись в файл
            {
                string line = "";
                while(line != "stop")
                {
                    count++;
                    line = Console.ReadLine();
                    sw.WriteLine(line);
                }
            }//автоматическое закрытие потока sw
            Console.WriteLine("file:");
            //вывести из файла полученное содержимое
            string[] array = new string[count];
            using (StreamReader sr = new StreamReader(filename))//открытие потока на чтение из файла
            {
                array = (sr.ReadToEnd()).Split('\n');
                
            }//автоматическое закрытие потока на чтение
            foreach (string line in array)
            {
                Console.WriteLine(line);
            }


        }
    }
}