using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            bool isArrayLengthCorrect = int.TryParse(Console.ReadLine(),out int arraySize);
            
            if (isArrayLengthCorrect==true && arraySize > 0)
            {

                int[] array = new int[arraySize];
                Random rnd = new Random();
                Console.WriteLine("Случайный массив");

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(100) - 50;
                    Console.WriteLine(array[i]);
                }          

                do
                {                   
                    Console.WriteLine("Выберите действие:1-максимальный элемент,2-минимальный элемент,3-сумма элементов массива,4-разность между максимальным и минимальный элементом,5-увеличение четных элементов на максимальный элемент,уменьшение нечетных элементов на минимальный элемент");
                    bool isActionNumCorrect = int.TryParse(Console.ReadLine(),out int actionNum);

                    if (isActionNumCorrect)
                    {

                        if (actionNum == 1)
                        {
                            Console.WriteLine("Максмальный элемент массива:" + GetMaxValue(array)); 
                        }

                        else if (actionNum == 2)
                        {
                            Console.WriteLine("Минимальный элемент массива:" + GetMinValue(array));
                        }

                        else if (actionNum == 3)
                        {
                            Console.WriteLine("Сумма всех элементов массива:" + GetElementsSum(array));
                        }

                        else if (actionNum == 4)
                        {
                            Console.WriteLine("Разность между максимальным и минимальный элементом:" + GetDifferenceBetweenMaxAndMinValue(array));
                        }

                        else if (actionNum == 5)
                        {
                            array = ChangeArrayElements(array);
                            Console.WriteLine("Новый массив");

                            for (int i = 0; i < array.Length; i++)
                            {
                                Console.WriteLine(array[i]);
                            }

                        }

                        else
                        {
                            Console.WriteLine("Такого номера операции не существует");
                        }

                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                        Console.ReadLine();
                    }

                    Console.WriteLine("Хотите ли продолжить работу с данным массивом:1-да,2-нет");                                   
                }
                while (Console.ReadLine() == "1");

            }

            else
            {
                Console.WriteLine("Неверно введены данные");
                Console.ReadLine();
            }

        }
        static int GetMaxValue(int[] array)
        {
            int maxValue = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {

                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }

            }

            return maxValue;
        }
        static int GetMinValue(int[] array)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {

                if (minValue > array[i])
                {
                    minValue = array[i];
                }
       
            }

            return minValue;
        }
        static int GetElementsSum(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];                
            }

            return sum;
        }
        static int GetDifferenceBetweenMaxAndMinValue(int[] array)
        {          
            return GetMaxValue(array)-GetMinValue(array);
        }
        static int[] ChangeArrayElements(int[] array)
        {
            int maxValue = GetMaxValue(array);
            int minValue = GetMinValue(array);

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2==0)
                {
                    array[i] += maxValue;
                }

                else

                {
                    array[i] -= minValue;
                }

            }

            return array;
        }
    }
}
