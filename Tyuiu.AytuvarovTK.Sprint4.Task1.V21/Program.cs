using Tyuiu.AytuvarovTK.Sprint4.Task1.V21.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint4.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int len;
            Console.WriteLine("Введите длину массива (11):");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"Введите элемент массива {i + 1} (от 1 до 8):");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            int result = ds.Calculate(numsArray);

            Console.WriteLine("Сумма четных элементов массива:");
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
