using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:1-сумма трех целых чисел,2-сумма двух целых чисел,3-сумма трех дробных чисел,4-сумма двух строк,5-сумма двух массивов");
            bool isActionNumCorrect = int.TryParse(Console.ReadLine(),out int actionNum);

            if (isActionNumCorrect == true)
            {

                if (actionNum == 1)
                {
                    Console.WriteLine("Введите 3 целых числа по одному в каждой строке");
                    bool isFirstNumCorrect = int.TryParse(Console.ReadLine(), out int firstNum);
                    bool isSecondNumCorrect = int.TryParse(Console.ReadLine(), out int secondNum);
                    bool isThirdNumCorrect = int.TryParse(Console.ReadLine(), out int thirdNum);

                    if (isFirstNumCorrect == true && isSecondNumCorrect == true && isThirdNumCorrect == true)
                    {
                        int sum = GetSum(firstNum, secondNum, thirdNum);
                        Console.WriteLine("Их сумма:" + sum);
                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                    }

                }

                else if (actionNum == 2)
                {
                    Console.WriteLine("Введите 2 целых числа по одному в каждой строке");
                    bool isFirstNumCorrect = int.TryParse(Console.ReadLine(), out int firstNum);
                    bool isSecondNumCorrect = int.TryParse(Console.ReadLine(), out int secondNum);

                    if (isFirstNumCorrect == true && isSecondNumCorrect == true)
                    {
                        int sum = GetSum(firstNum, secondNum);
                        Console.WriteLine("Их сумма:" + sum);
                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                    }

                }

                else if (actionNum == 3)
                {
                    Console.WriteLine("Введите 3 дробных числа по одному в каждой строке");
                    bool isFirstNumCorrect = double.TryParse(Console.ReadLine(), out double firstNum);
                    bool isSecondNumCorrect = double.TryParse(Console.ReadLine(), out double secondNum);
                    bool isThirdNumCorrect = double.TryParse(Console.ReadLine(), out double thirdNum);

                    if (isFirstNumCorrect == true && isSecondNumCorrect == true && isThirdNumCorrect == true)
                    {
                        double sum = GetSum(firstNum, secondNum, thirdNum);
                        Console.WriteLine("Их сумма:" + sum);
                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                    }

                }

                else if (actionNum == 4)
                {
                    Console.WriteLine("Введите 2 строки по одному в каждой строке");
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string sum = GetSum(firstString, secondString);
                    Console.WriteLine("Их сумма:" + sum);
                }

                else if (actionNum == 5)
                {
                    Console.WriteLine("Введите размер 1-го массива");
                    bool isFirstArrayLengthCorrect = int.TryParse(Console.ReadLine(), out int firstArrayLength);
                    Console.WriteLine("Введите размер 2-го массива");
                    bool isSecondArrayLengthCorrect = int.TryParse(Console.ReadLine(), out int secondArrayLength);
                    Random rnd = new Random();

                    if (isFirstArrayLengthCorrect == true && isSecondArrayLengthCorrect == true && firstArrayLength > 0 && secondArrayLength > 0)
                    {
                        int[] firstArray = new int[firstArrayLength];
                        int[] secondArray = new int[secondArrayLength];
                        Console.WriteLine("Первый массив");

                        for (int i = 0; i < firstArray.Length; i++)
                        {
                            firstArray[i] = rnd.Next(100) - 50;
                            Console.WriteLine(firstArray[i]);
                        }

                        Console.WriteLine("Второй массив");

                        for (int i = 0; i < secondArray.Length; i++)
                        {
                            secondArray[i] = rnd.Next(100) - 50;
                            Console.WriteLine(secondArray[i]);
                        }

                        int[] sumArray = GetSum(firstArray, secondArray);
                        Console.WriteLine("Суммарный массив");
    
                        for (int i = 0; i < sumArray.Length; i++)
                        {
                            Console.WriteLine(sumArray[i]);
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

            }

            else
            {
                Console.WriteLine("Неправильно введены данные");
            }

            Console.ReadLine();
        }
        static int GetSum(int firstNum,int secondNum,int thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }
        static int GetSum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        static double GetSum(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }
        static string GetSum(string firstString, string secondString)
        {
            return firstString + secondString;
        }      
        static int[] GetSum(int[] firstArray,int[] secondArray)
        {
            int[] sumArray;
            int littleArrayLength = 0;

            if (firstArray.Length >= secondArray.Length)
            {
                sumArray = new int[firstArray.Length];
                littleArrayLength = secondArray.Length;
            }

            else
            {
                sumArray = new int[secondArray.Length];
                littleArrayLength = firstArray.Length;
            }

            for (int i = 0; i < sumArray.Length; i++)
            {

                if (littleArrayLength > i )
                {
                    sumArray[i] = firstArray[i] + secondArray[i];
                }

                else
                {

                    if (firstArray.Length >= secondArray.Length)
                    {
                        sumArray[i] = firstArray[i];
                    }

                    else
                    {
                        sumArray[i] = secondArray[i];
                    }

                } 
                
            }

            return sumArray;
        }
    }
}
