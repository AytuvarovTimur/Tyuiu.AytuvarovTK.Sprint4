using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AytuvarovTK.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            // Дан строковый массив данных ["Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi"] используя класс Array подсчитайте количество элементов, длина которых больше 4.
            int count = 0;
            foreach (var item in array)
            {
                if (item.Length > 4)
                {
                    count++;
                }
            }
            return count;

        }
    }
}
