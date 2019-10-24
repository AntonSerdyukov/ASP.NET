using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            int numAmount = int.Parse(Console.ReadLine());
            if (numAmount > 0)
            {
                int[] evenNumbers = new int[numAmount];
                for (int i = 0; i < evenNumbers.Length; i++)
                {
                    evenNumbers[i] = (i + 1) * 2;
                }
                Console.WriteLine("Первые {0} натуральных четных чисел", numAmount);
                for (int i = 0; i < evenNumbers.Length; i++)
                {
                    Console.WriteLine(evenNumbers[i]);
                }
            }
            else
            {
                Console.WriteLine("Неправильно введены данные");
            }
            Console.ReadLine();
        }
    }
}
