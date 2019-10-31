using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в массиве");
            int numAmount = int.Parse(Console.ReadLine());
            if (numAmount > 0)
            {
                double[] array = new double[numAmount];
                Random rnd = new Random();
                Console.WriteLine("Исходный массив");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = 100 * (rnd.NextDouble() - 0.5);
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine("Результат:");
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[i - 1])
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Неправильно введены данные");
            }
            Console.ReadLine();
        }
    }
}
