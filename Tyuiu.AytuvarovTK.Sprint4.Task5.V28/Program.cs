using Tyuiu.AytuvarovTK.Sprint4.Task5.V28.Lib;
using System;

namespace Tyuiu.AytuvarovTK.Sprint4.Task5.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int len;
            Console.WriteLine("Введите длину массива (5 на 5):");
            len = Convert.ToInt32(Console.ReadLine());
            int[,] numsArray = new int[len, len];
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.WriteLine($"Введите элемент массива [{i + 1},{j + 1}] (от -6 до 3):");
                    numsArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(numsArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] result = ds.Calculate(numsArray);
            Console.WriteLine("Изменённый массив");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
