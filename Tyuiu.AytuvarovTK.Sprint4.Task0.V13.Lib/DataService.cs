using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AytuvarovTK.Sprint4.Task0.V13.Lib
{
    public class DataService : ISprint4Task0V13
    {
        public int GetSumEvenArrEl(int[] array)
        {
            // Дан одномерный целочисленный массив на 10 элементов зполненный статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных элементов массива.  {2, 6, 2, 3, 4, 5, 4, 9, 7, 8}
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
