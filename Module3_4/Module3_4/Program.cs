using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double num = double.Parse(Console.ReadLine().Replace(".", ","));
            double result = 0;
            result = GetReversedNumber(num);
            Console.WriteLine("Число в обратном порядке");
            Console.WriteLine(result);            
            Console.ReadLine();
        }
        public static double GetReversedNumber(double num)
        {
            char[] digits = num.ToString().ToCharArray();
            int digitsLength = digits.Length;
            if (num < 0)
            {
                digitsLength--;
            }
            char[] reversedDigits = new char[digitsLength];
            StringBuilder reversedNum = new StringBuilder();
            for (int i = 0; i < digitsLength; i++)
            {
                reversedDigits[i] = digits[digits.Length - 1 - i];
                reversedNum.Append(reversedDigits[i]);
            }           
            double  result = double.Parse(reversedNum.ToString());
            if (num < 0)
            {
                result *= -1;
            }            
            return result;
        }
    }
}
