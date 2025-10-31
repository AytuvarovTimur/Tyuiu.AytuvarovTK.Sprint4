using Tyuiu.AytuvarovTK.Sprint4.Task6.V13.Lib;
using System;

namespace Tyuiu.AytuvarovTK.Sprint4.Task6.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int len;
            Console.WriteLine("Введите длину массива (7):");
            len = Convert.ToInt32(Console.ReadLine());
            string[] strArray = new string[len];
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Введите элемент массива [{i + 1}]:");
                strArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                Console.Write(strArray[i] + " ");
            }
            Console.WriteLine();

            int result = ds.Calculate(strArray);
            Console.WriteLine("Количество элементов, длина которых больше 4:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
