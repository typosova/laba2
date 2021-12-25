using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var input_data = new int[] { 2, 3, 4, 6, 9, 10, 12, 15, 17, 18, 20, 22, 25 };

            int check = 24;

            int n = input_data.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int summ = input_data[i] + input_data[j];
                    if (summ == 24)
                    {
                        Console.WriteLine("Num 1 = {0}, Num 2 = {1}", input_data[i], input_data[j]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
