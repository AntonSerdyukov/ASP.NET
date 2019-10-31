using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int secondNum = int.Parse(Console.ReadLine());
            int composition = 0;
            if (secondNum > 0)
            {
                for (int i = 0; i < secondNum; i++)
                {
                    composition += firstNum;
                }
            }
            if (secondNum < 0)
            {
                for (int i = secondNum; i < 0; i++)
                {
                    composition += -firstNum;
                }
            }
            Console.WriteLine("Произведение этих чисел:"+composition);
            Console.ReadLine();
        }
    }
}
