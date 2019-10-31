using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_4
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
                    Console.WriteLine(" Введите три входных числа");
                    bool isFirstNumCorrect = double.TryParse(Console.ReadLine(), out double firstNum);
                    bool isSecondNumCorrect = double.TryParse(Console.ReadLine(), out double secondNum);
                    bool isThirdNumCorrect = double.TryParse(Console.ReadLine(), out double thirdNum);

                    if (isFirstNumCorrect == true && isSecondNumCorrect == true && isThirdNumCorrect == true)
                    {
                        (double, double, double) inputNumbers = (firstNum, secondNum, thirdNum);                       
                        (double, double, double) outputNumbers = ChangeParameteres(inputNumbers);
                        Console.WriteLine("Три выходных параметра");
                        Console.WriteLine(outputNumbers);
                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                    }

                }

                else if (actionNum == 2)
                {
                    Console.WriteLine("Введите радиус окружности");
                    bool isRadiusCorrect = double.TryParse(Console.ReadLine(), out double radius);

                    if (isRadiusCorrect == true && radius > 0)
                    {
                        (double, double) circleOptions = GetCircleLengthAndSquare(radius);
                        Console.WriteLine("Длина окружности:" + circleOptions.Item1);
                        Console.WriteLine("Площадь круга:" + circleOptions.Item2);
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

                        (double, double, double) arrayOptions = GetMinAndMaxValueAndSum(array);
                        Console.WriteLine("Минимальный элемент:" + arrayOptions.Item1);
                        Console.WriteLine("Максимальный элемент:" + arrayOptions.Item2);
                        Console.WriteLine("Сумма всех элементов:" + arrayOptions.Item3);
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
                Console.WriteLine("Неверно введены данные");
            }

            Console.ReadLine();
        }
        static (double,double,double) ChangeParameteres((double,double,double) inputNumbers)
        {
            (double, double, double) outputNumbers = (inputNumbers.Item1 + 10, inputNumbers.Item2 + 10, inputNumbers.Item3 + 10);         
            return outputNumbers;
        }
        static (double, double) GetCircleLengthAndSquare(double  radius)
        {
            double circleLength = Math.Round(2 * Math.PI * radius, 2);
            double circleSquare = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
            (double, double) circleOptions = (circleLength,circleSquare);
            return circleOptions;
        }
        static (double,double,double) GetMinAndMaxValueAndSum(double[] array)
        {
            double minValue = double.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {

                if (minValue > array[i])
                {
                    minValue = array[i];
                }

            }

            double maxValue = double.MinValue;

            for (int i = 0; i < array.Length; i++)
            {

                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }

            }

            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            (double, double, double) arrayOptions = (minValue, maxValue, sum);
            return arrayOptions;
        }
    }
}
