using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Введите первое число");
            bool firstCheck = double.TryParse(Console.ReadLine().Replace(".",","),out double firstNum);
            Console.WriteLine("Введите второе число");           
            bool secondCheck = double.TryParse(Console.ReadLine().Replace(".",","),out double secondNum);
            if (firstCheck==true && secondCheck == true)
            {
                double temp = secondNum;
                secondNum = firstNum;
                firstNum=temp;
                Console.WriteLine("Значение первого числа:{0}",firstNum);
                Console.WriteLine("Значение второго числа:{0}", secondNum);
            }
            else
            {               
                Console.WriteLine("Неправильно введены данные");
            }
            Console.ReadLine();
        }
    }
}
