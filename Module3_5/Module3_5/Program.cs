using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число");
            string num = Console.ReadLine();
            Console.WriteLine("Введите цифру,которую нужно удалить из числа");
            string digit =Console.ReadLine();
            StringBuilder newNum = new StringBuilder();
            if (int.Parse(digit) >=0 && int.Parse(digit) <= 9 && int.Parse(num) > 0)
            {
                for (int i=0;i<num.Length; i++)
                {
                    if (num[i].ToString() != digit)
                    {
                        newNum.Append(num[i]);                       
                    }
                }
                int result = int.Parse(newNum.ToString());
                Console.WriteLine("Число без всех {0} равно",digit);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Неверно введены данные");
            }            
            Console.ReadLine();          
        }
    }
}
