using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой возраст");
            int age = int.Parse(Console.ReadLine());
            if (age % 2 == 0 && age > 18)
            {
                Console.WriteLine("Поздравляем вас с 18-летием");
            }
            else if (age % 2 == 1 && age > 13 && age < 18)
            {
                Console.WriteLine("Поздравляем вас с переходом в старшую школу");
            }
            else
            {
                Console.WriteLine("Пока вас не с чем поздравить");
            }
            Console.ReadLine();
        }
    }
}
