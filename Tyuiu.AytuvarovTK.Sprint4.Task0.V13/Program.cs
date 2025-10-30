using Tyuiu.AytuvarovTK.Sprint4.Task0.V13.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Tyuiu.LavrentevVA.Sprint4.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int sumEvenElements = ds.GetSumEvenArrEl(numsArray);
            Console.WriteLine($"Сумма четных элементов массива: {sumEvenElements}");
            Console.ReadKey();

        }
    }
}
