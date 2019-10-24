using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел Фибоначчи");
            int numAmount = int.Parse(Console.ReadLine());         
            if (numAmount > 1)
            {
                int[] fibonachiNumbers = new int[numAmount];
                fibonachiNumbers[0] = 0;
                fibonachiNumbers[1] = 1;
                for (int i = 2; i < numAmount; i++)
                {
                    fibonachiNumbers[i] = fibonachiNumbers[i - 1] + fibonachiNumbers[i - 2];
                }
                Console.WriteLine("Первые {0} чисел Фиббоначи",numAmount);
                for (int i = 0; i < numAmount; i++)
                {
                    Console.WriteLine(fibonachiNumbers[i]);
                }
            }
            else if (numAmount==1)
            {
                Console.WriteLine("Первое  число Фиббоначи:0");
            }
            else
            {
                Console.WriteLine("Неправильно введены данные");
            }          
            Console.ReadLine();
        }         
    }
}
