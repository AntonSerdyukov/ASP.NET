using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность масссива");
            int arrayLength = int.Parse(Console.ReadLine());            
            double[] array = new double[arrayLength];
            Random rnd = new Random();
            Console.WriteLine("Начальный массив");
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = Math.Round(100 * (rnd.NextDouble() - 0.5), 2);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Конечный массив");
            array = ChangeArray(array);
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
        static double[] ChangeArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
            return array;
        }
    }
}
