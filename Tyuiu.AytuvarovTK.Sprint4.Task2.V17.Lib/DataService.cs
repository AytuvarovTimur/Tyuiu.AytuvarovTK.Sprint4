using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AytuvarovTK.Sprint4.Task2.V17.Lib
{
    public class DataService : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            // Дан одномерный целочисленный массив на 9 элементов заполненный случайными в диапазоне от 3 до 9 подсчитать произведение нечетных элементов массива.
            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                }
            }
            return product;
        }
    }
}
