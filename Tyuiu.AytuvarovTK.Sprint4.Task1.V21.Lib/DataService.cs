﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AytuvarovTK.Sprint4.Task1.V21.Lib
{
    public class DataService : ISprint4Task1V21
    {
        public int Calculate(int[] array)
        {
            // Дан одномерный целочисленный массив на 11 элементов заполненный значениями с клавиатуры в диапазоне от 1 до 8 подсчитать произведение четных элементов массива. С клавиатуры: 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    product *= array[i];
                }
            }
            return product;
        }
    }
}
