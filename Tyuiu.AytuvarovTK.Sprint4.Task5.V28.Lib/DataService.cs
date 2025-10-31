using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AytuvarovTK.Sprint4.Task5.V28.Lib
{
    public class DataService : ISprint4Task5V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            //Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными значениями в диапазоне от -6 до 3. Заменить отрицательные элементы на 0.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
