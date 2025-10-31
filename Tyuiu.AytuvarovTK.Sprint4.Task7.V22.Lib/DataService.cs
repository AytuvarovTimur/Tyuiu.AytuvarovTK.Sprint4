using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AytuvarovTK.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            // Дана строка из одноразрядных цифр "695324951753684". Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение четных чисел.
            int[,] matrix = new int[n, m];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }
            int product = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                    }
                }
            }
            return product;

        }
    }
}
