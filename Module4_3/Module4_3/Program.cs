using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:1-увеличение переменных,2-найти длину окружности и ее площадь,3-нахождение минимального, максимального элемента массива и суммы всех элементов массива");
            bool isActionNumCorrect = int.TryParse(Console.ReadLine(),out int actionNum);
            
            if (isActionNumCorrect == true)
            {

                if (actionNum == 1)
                {
                    Console.WriteLine("Введите три входных числа по одному в каждой строке");
                    bool isFirstNumCorrect = double.TryParse(Console.ReadLine(), out double firstNum);                    
                    bool isSecondNumCorrect = double.TryParse(Console.ReadLine(), out double secondNum);                    
                    bool isThirdNumCorrect = double.TryParse(Console.ReadLine(), out double thirdNum);

                    if (isFirstNumCorrect == true && isSecondNumCorrect == true && isThirdNumCorrect == true)
                    {                      
                        ChangeParameteres(ref firstNum, ref secondNum, ref thirdNum, out double newFirstNum, out double newSecondNum, out double newThirdNum);
                        Console.WriteLine("Три выходных параметра");
                        Console.WriteLine(newFirstNum);
                        Console.WriteLine(newSecondNum);
                        Console.WriteLine(newThirdNum);
                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                    }

                }

                else if (actionNum == 2)
                {
                    Console.WriteLine("Введите радиус окружности");
                    bool  isRadiusCorrect = double.TryParse(Console.ReadLine(), out double radius);

                    if (isRadiusCorrect == true && radius > 0)
                    {
                        GetCircleLengthAndSquare(ref radius, out double circleLength, out double circleSquare);
                        Console.WriteLine("Длина окружности:" + circleLength);
                        Console.WriteLine("Площадь круга:" + circleSquare);
                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                    }

                }

                else if (actionNum == 3)
                {
                    Console.WriteLine("Введите длину массива");
                    bool isArrayLengthCorrect = int.TryParse(Console.ReadLine(),out int arrayLength);

                    if (isArrayLengthCorrect == true && arrayLength > 0)
                    {
                        Console.WriteLine("Случайный массив");
                        double[] array = new double[arrayLength];                        
                        Random rnd = new Random();

                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = Math.Round(100 * (rnd.NextDouble() - 0.5), 2);
                            Console.WriteLine(array[i]);
                        }

                        GetMinAndMaxValueAndSum(array, out double minValue, out double maxValue, out double sum);
                        Console.WriteLine("Минимальный элемент:" + minValue);
                        Console.WriteLine("Максимальный элемент:" + maxValue);
                        Console.WriteLine("Сумма всех элементов:" + sum);
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

            }

            else
            {
                Console.WriteLine("Неправильно введены данные");
            }

            Console.ReadLine();
        }
        static void ChangeParameteres(ref double firstNum,ref double secondNum,ref double thirdNum,out double newFirstNum,out double newSecondNum,out double newThirdNum)
        {
            newFirstNum = firstNum + 10;
            newSecondNum = secondNum + 10;
            newThirdNum = thirdNum + 10;
        }
        static void GetCircleLengthAndSquare(ref double radius,out double circleLength,out double circleSquare)
        {
            circleLength = Math.Round(2*Math.PI*radius, 2);
            circleSquare = Math.Round(Math.PI * Math.Pow(radius,2), 2);
        }
        static void GetMinAndMaxValueAndSum(double[] array,out double minValue,out double maxValue,out double sum)
        {
            minValue = double.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {

                if (minValue > array[i])
                {
                    minValue = array[i];
                }

            }

            maxValue = double.MinValue;

            for (int i = 0; i < array.Length; i++)
            {

                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }

            }

            sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

        }
    }
}
