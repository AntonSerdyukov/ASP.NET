using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Уравнение  x^3-16=0");
            Console.WriteLine("Введите начало отрезка");
            bool isBeginPointCorrect = double.TryParse(Console.ReadLine(),out double beginPoint);
            Console.WriteLine("Введите конец отрезка");
            bool isEndPointCorrect = double.TryParse(Console.ReadLine(),out double endPoint);

            if (isBeginPointCorrect == true && isEndPointCorrect == true)
            {
                double accuracy = 0.001;

                if (Math.Sign(Func(beginPoint)) == Math.Sign(Func(endPoint)))
                {
                    Console.WriteLine("Нет корней на данном отрезке");
                }

                else
                {
                    double result = GetRoot(beginPoint, endPoint, accuracy);
                    Console.WriteLine("Решение данного уравнения: x={0}", result);
                }

            }

            else
            {
                Console.WriteLine("Неверно введены данные");
            }

            Console.ReadLine();
        }
        static double GetRoot(double beginPoint, double endPoint, double accuracy)
        {          
            double averagePoint = (beginPoint + endPoint)/2;

            if (Math.Abs(Func(averagePoint)) <= accuracy)
            {
                return averagePoint;
            }

            else
            {

                if (Math.Sign(Func(beginPoint)) == Math.Sign(Func(averagePoint)))
                {
                    return GetRoot(averagePoint, endPoint, accuracy);
                }

                else
                {
                    return GetRoot(beginPoint, averagePoint, accuracy);
                }

            }

        }
        static double Func(double x)
        {
            return Math.Pow(x,3)-16;
        }
    }
}
