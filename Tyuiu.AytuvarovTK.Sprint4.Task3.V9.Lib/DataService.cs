using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AytuvarovTK.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            // Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями в диапазоне от 3 до 9. Найдите сумму элементов во втором столбце массива. 9, 6, 4, 5, 3, 7, 4, 7, 5, 3,  8, 5, 9, 9, 3, 7, 8, 7, 9, 3, 3, 7, 3, 7, 7,
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, 1];
            }
            return sum;
        }
    }
}
