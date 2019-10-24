using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уравнение x^3-16=0");
            Console.WriteLine("Введите начало и конец отрезка, в котором находится решение уравнения x^3-16=0");
            Console.WriteLine("Начало отрезка ");
            double beginPoint = double.Parse(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Конец отрезка ");
            double endPoint = double.Parse(Console.ReadLine().Replace(".", ","));
            double accuracy = 0.001;
            double segmentLength = endPoint - beginPoint;
            double averagePoint = (beginPoint + endPoint) / 2;
            if (Math.Sign(Func(beginPoint)) == Math.Sign((Func(endPoint))))
            {
                Console.WriteLine("Нет решений на данном отрезке");
            }
            else
            {
                while (Math.Abs(Func(averagePoint)) > accuracy)
                {
                    segmentLength /= 2;
                    averagePoint = beginPoint + segmentLength;
                    if (Math.Sign(Func(beginPoint)) == Math.Sign((Func(averagePoint))))
                    {
                        beginPoint = averagePoint;
                    }
                }
                Console.WriteLine("Результат с точностью до {0}: x={1}", accuracy, averagePoint);
            }
            Console.ReadLine();
        }
        private static double Func(double x)
        {
            return x * x * x - 16;
        }   
    }
}
