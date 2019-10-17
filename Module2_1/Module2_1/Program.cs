using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество компаний в стране");
            int companiesAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент налога");
            double percentTax = double.Parse(Console.ReadLine());
            double companyProfit = 500;
            double sumTax = companyProfit * percentTax/100 * companiesAmount;
            Console.WriteLine("Суммарный налог:"+sumTax);
            Console.ReadLine();
        }
    }
}
