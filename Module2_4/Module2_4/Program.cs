using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_4
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер фигуры:1-правильный треугольник, 2-правильный четырехугольник,3-круг");
            int figureNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер действия:1-найти периметр, 2-найти площадь");
            int actionNum = int.Parse(Console.ReadLine());
            if (figureNum == 1)
            {
                Console.WriteLine("Введите длину стороны треугольника");
                double triangleSide = double.Parse(Console.ReadLine());
                if (actionNum == 1)
                {
                    double trianglePerimeter = GetTrianglePerimeter(triangleSide);
                    Console.WriteLine("Периметр треугольника равен {0}",trianglePerimeter);
                    double tetragonSquare = GetTetragonSquare(GetTetragonSideFromPerimeter(trianglePerimeter));
                    Console.WriteLine("Площадь четырехугольника при таком периметре равна {0}", tetragonSquare);
                    double  circleSquare = GetCircleSquare(GetRadiusFromPerimeter(trianglePerimeter));
                    Console.WriteLine("Площадь круга при таком периметре равна {0}", circleSquare);
                }
                else if (actionNum == 2)
                {
                    double triangleSquare = GetTriangleSquare(triangleSide);
                    Console.WriteLine("Площадь треугольника равна {0}", triangleSquare);
                    double tetragonPerimeter= GetTetragonPerimeter(GetTetragonSideFromSquare(triangleSquare));
                    Console.WriteLine("Периметр четырехугольника при такой площади равен {0}", tetragonPerimeter);
                    double circlePerimeter =GetCirclePerimeter(GetRadiusFromSquare(triangleSquare));
                    Console.WriteLine("Периметр круга при такой площади равен {0}", circlePerimeter);
                }
                else
                {
                    Console.WriteLine("Некорректный номер операции");
                }
            }
            else if (figureNum == 2)
            {
                Console.WriteLine("Введите длину стороны четырехугольника");
                double tetragonSide = double.Parse(Console.ReadLine());
                if (actionNum == 1)
                {
                    double tetragonPerimeter = GetTetragonPerimeter(tetragonSide);
                    Console.WriteLine("Периметр четырехугольника равен {0}", tetragonPerimeter);
                    double triangleSquare = GetTriangleSquare(GetTriangleSideFromPerimeter(tetragonPerimeter));
                    Console.WriteLine("Площадь треугольника при таком периметре равна {0}", triangleSquare);
                    double circleSquare = GetCircleSquare(GetRadiusFromPerimeter(tetragonPerimeter));
                    Console.WriteLine("Площадь круга при таком периметре равна {0}", circleSquare);
                }
                else if (actionNum == 2)
                {
                    double tetragonSquare = GetTetragonSquare(tetragonSide);
                    Console.WriteLine("Площадь четырехугольника равна {0}", tetragonSquare);
                    double trianglePerimeter = GetTrianglePerimeter(GetTriangleSideFromSquare(tetragonSquare));
                    Console.WriteLine("Периметр треугольника при такой площади равен {0}", trianglePerimeter);
                    double circlePerimeter = GetCirclePerimeter(GetRadiusFromSquare(tetragonSquare));
                    Console.WriteLine("Периметр круга при такой площади равен {0}", circlePerimeter);
                }
                else
                {
                    Console.WriteLine("Некорректный номер операции");
                }
            }
            else if (figureNum == 3)
            {
                Console.WriteLine("Введите радиус круга");
                double radius = double.Parse(Console.ReadLine());
                if (actionNum == 1)
                {
                    double circlePerimeter = GetCirclePerimeter(radius);
                    Console.WriteLine("Периметр круга равен {0}", circlePerimeter);
                    double triangleSquare = GetTriangleSquare(GetTriangleSideFromPerimeter(circlePerimeter));
                    Console.WriteLine("Площадь треугольника при таком периметре равна {0}", triangleSquare);
                    double tetragonSquare = GetTetragonSquare(GetTetragonSideFromPerimeter(circlePerimeter));
                    Console.WriteLine("Площадь четырехугольника при таком периметре равна {0}", tetragonSquare);
                }
                else if (actionNum == 2)
                {
                    double circleSquare = GetCircleSquare(radius);
                    Console.WriteLine("Площадь круга равна {0}", circleSquare);
                    double trianglePerimeter = GetTrianglePerimeter(GetTriangleSideFromSquare(circleSquare));
                    Console.WriteLine("Периметр треугольника при такой площади равен {0}", trianglePerimeter);
                    double tetragonPerimeter = GetTetragonPerimeter(GetTetragonSideFromSquare(circleSquare));
                    Console.WriteLine("Периметр четырехугольника при такой площади равен {0}", tetragonPerimeter);
                }
                else
                {
                    Console.WriteLine("Некорректный номер операции");
                }
            }
            else
            {
                Console.WriteLine("Некорректный номер фигуры");
            }
            
            Console.ReadLine();
        }
        static double GetTrianglePerimeter(double triangleSide)
        {
            return triangleSide * 3;
        }
        static double GetTetragonPerimeter(double tetragonSide)
        {
            return tetragonSide * 4;
        }
        static double GetCirclePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static double GetTriangleSquare(double triangleSide)
        {
            return Math.Pow(triangleSide, 2) * Math.Pow(3, 0.5) / 4;
        }
        static double GetTetragonSquare(double tetragonSide)
        {
            return Math.Pow(tetragonSide, 2);
        }
        static double GetCircleSquare(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static double GetRadiusFromPerimeter(double perimeter)
        {
            return perimeter / (Math.PI * 2);
        }
        static double GetRadiusFromSquare(double square)
        {
            return Math.Sqrt(square / Math.PI);
        }
        static double GetTetragonSideFromPerimeter(double perimeter)
        {
            return perimeter / 4;
        }
        static double GetTetragonSideFromSquare(double square)
        {
            return Math.Sqrt(square);
        }
        static double GetTriangleSideFromPerimeter(double perimeter)
        {
            return perimeter / 3;
        }
        static double GetTriangleSideFromSquare(double square)
        {
            return Math.Sqrt(4 * square / Math.Sqrt(3));
        }
    }
}
