using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк квадратного массива");
            int rowAmount = int.Parse(Console.ReadLine());
            if (rowAmount > 0)
            {
                int[,] array = new int[rowAmount, rowAmount];
                int initialColumn = 0;
                int finalColumn = rowAmount - 1;
                int initialRow = 0;
                int finalRow = rowAmount - 1;
                int num = 1;
                while (num <= rowAmount * rowAmount)
                {
                    for (int columnNumber = initialColumn; columnNumber <= finalColumn; columnNumber++)
                    {
                        array[initialRow, columnNumber] = num;
                        num++;
                    }
                    initialRow++;
                    for (int rowNumber = initialRow; rowNumber <= finalRow; rowNumber++)
                    {
                        array[rowNumber, finalColumn] = num;
                        num++;
                    }
                    finalColumn--;
                    for (int columnNumber = finalColumn; columnNumber >= initialColumn; columnNumber--)
                    {
                        array[finalRow, columnNumber] = num;
                        num++;
                    }
                    finalRow--;
                    for (int rowNumber = finalRow; rowNumber >= initialRow; rowNumber--)
                    {
                        array[rowNumber, initialColumn] = num;
                        num++;
                    }
                    initialColumn++;
                }
                for (int rowNumber = 0; rowNumber < rowAmount; rowNumber++)
                {
                    for (int columnNumber = 0; columnNumber < rowAmount; columnNumber++)
                    {
                        Console.Write("{0}\t", array[rowNumber, columnNumber]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Неверно введены данные");
            }
            Console.ReadLine();
        }
    }
}
