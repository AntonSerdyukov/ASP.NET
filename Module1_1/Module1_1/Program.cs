using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение переменной b");
            int b = int.Parse(Console.ReadLine());
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine("Результат:a={0},b={1}",a,b);
            Console.ReadLine();
        }
    }
}
