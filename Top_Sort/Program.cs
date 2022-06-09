using System;
using System.Collections.Generic;
using System.Linq;


namespace Top_Sort
{
    class Program
    {
       
        static void Main(string[] args)
        {
            IEnumerable<int> Number = new List<int>() { 22, 98, 1, 9, 100, 81, 45 };
            foreach (var i in Program.Sort(Number, 100, 2000))
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Возвращает отсортированный по возрастанию поток чисел
        /// </summary>
        /// <param name="inputStream">Поток чисел от 0 до maxValue. Длина потока не превышает миллиарда чисел.</param>
        /// <param name="sortFactor">Фактор упорядоченности потока. Неотрицательное число. Если в потоке встретилось число x, то в нём больше не встретятся числа меньше, чем (x - sortFactor).</param>
        /// <param name="maxValue">Максимально возможное значение чисел в потоке. Неотрицательное число, не превышающее 2000.</param>
        /// <returns>Отсортированный по возрастанию поток чисел.</returns>
        public static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
        {
            bool flag = false;
            IEnumerable<int> Numbers = inputStream.OrderBy(i => i);
            
            foreach (var i in Numbers)
            {
                if (i == sortFactor)
                {
                    flag = true;
                }
                if (flag && i < sortFactor) 
                {

                }
                else
                {
                     yield return i; 
                }
            }
        }
    }
}