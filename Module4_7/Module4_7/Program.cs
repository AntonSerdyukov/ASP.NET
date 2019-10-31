using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");           
            bool isArrayLengthCorrect = int.TryParse(Console.ReadLine(), out int arrayLength);

            if (isArrayLengthCorrect == true && arrayLength > 0)
            {
                double[] array = new double[arrayLength];
                Console.WriteLine("Начальный массив");
                Random rnd = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Math.Round(100 * (rnd.NextDouble() - 0.5), 2);
                    Console.WriteLine(array[i]);
                }

                Console.WriteLine("Выберите направление сортировки:1-по возрастанию,2-по убыванию");
                bool isNumOfTypeOfSortCorrect = int.TryParse(Console.ReadLine(), out int numOfTypeOfSort);

                if (isNumOfTypeOfSortCorrect == true && numOfTypeOfSort > 0 && numOfTypeOfSort < 3) 
                {
                    double[] sortedArray = SortArray(array, numOfTypeOfSort);
                    Console.WriteLine("Конечный массив");

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(sortedArray[i]);
                    }

                }

                else
                {
                    Console.WriteLine("Неверно введены данные");
                }

            }

            else
            {
                Console.WriteLine("Неверно введены данные");
            }

            Console.ReadLine();
        }
        static double[] SortArray(double[] array,int numOfTypeOfSort)
        {
            
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[i] > array[j])
                    {
                        double temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }

                }

            }

            if (numOfTypeOfSort == 1)
            {
                return array;
            }

            else
            {
                double[] reversedArray=new double [array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    reversedArray[i] = array[array.Length - 1 - i];                   
                }

                return reversedArray;       
            } 
            
        }
    }
}
