namespace pz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0; //цикл сдвига массива
            int i = 0; //текущий элемент массива
            int n = 1; //счетчик суммы элементов массива
            Random rand = new Random();


            Console.Write("Введите длину массива: ");
            int len = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите максимальное значение элемента массива: ");
            int max_value = Convert.ToInt16(Console.ReadLine());


            int[] input_array = new int[len];
            int[] array = new int[len];


            for (i = 0; i < input_array.Length; i++) //заполняем массив числами от 0 до 49
            {
                input_array[i] = rand.Next(max_value);
                array[i] = input_array[i];
            }


            i = 0;


            while (i < len && n > 0)
            {
                if (array[i] < 15)
                {
                    for(j = i; j < len - 2; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[len - 2] = 0;
                    n = 0;
                    for (int x = i; x < len - 1; x++)
                    {
                        n += array[x];
                    }
                }
                else
                {
                    i++;
                }
                
            }


            for(i = 0; i < array.Length - 1; i++) //вывод массива
            {
                Console.WriteLine(input_array[i] + "\t" + array[i]);
            }
        }
    }
}
