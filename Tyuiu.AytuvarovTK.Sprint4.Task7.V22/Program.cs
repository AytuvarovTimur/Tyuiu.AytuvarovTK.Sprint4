using Tyuiu.AytuvarovTK.Sprint4.Task7.V22.Lib;
using System;

namespace Tyuiu.AytuvarovTK.Sprint4.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите число строк (5):");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число столбцов (3):");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите строку из одноразрядных цифр (например: 695324951753684):");
            string value = Console.ReadLine() ?? string.Empty;

            if (value.Length != n * m)
            {
                Console.WriteLine($"Ошибка: длина строки должна быть равна {n * m} символам.");
                Console.ReadKey();
                return;
            }

            // Отобразим матрицу для пользователя
            Console.WriteLine("Матрица:");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(value[index] + " ");
                    index++;
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(n, m, value);
            Console.WriteLine("Произведение чётных чисел в матрице:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
