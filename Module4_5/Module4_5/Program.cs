using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_5
{
    class Program
    {
        enum MathOperation
        {
            Add=1,
            Subtract,
            Multiply,
            Divide
        }
        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:1-определение кол-ва дней в месяце,2-арифметические операции");
            bool isActionNumCorrect = int.TryParse(Console.ReadLine(),out int actionNum);

            if (isActionNumCorrect == true)
            {

                if (actionNum == 1)
                {
                    Console.WriteLine("Введите номер месяца");
                    bool isNumMonthCorrect = int.TryParse(Console.ReadLine(),out int numMonth);

                    if (isNumMonthCorrect == true && numMonth > 0 && numMonth < 13)
                    {
                        Month month = (Month)numMonth;
                        int daysInMonth = GetNumOfDaysByMonth(month);
                        Console.WriteLine("Результат:{0} дней в месяце {1} ", daysInMonth, month);                                               
                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                    }

                }

                else if (actionNum == 2)
                {
                    Console.WriteLine("Введите номер операции:1-сложение,2-вычитание,3-умножение,4-деление");
                    bool isOperationNumCorrect = int.TryParse(Console.ReadLine(),out int operationNum);

                    if (isOperationNumCorrect == true && operationNum > 0 && operationNum < 5)
                    {
                        Console.WriteLine("Введите 1-ое число");
                        bool isFirstNumCorrect = double.TryParse(Console.ReadLine(),out double firstNum);
                        Console.WriteLine("Введите 2-ое число");
                        bool isSecondNumCorrect = double.TryParse(Console.ReadLine(),out double secondNum);

                        if (isFirstNumCorrect == true && isSecondNumCorrect == true)
                        {
                            MathOperation mathOperation = (MathOperation) operationNum;
                            
                            if (secondNum != 0 || operationNum != 4)
                            {
                                double result = Calculate(firstNum, secondNum, mathOperation);
                                Console.WriteLine("Результат операции {0}:{1}", mathOperation, result);
                            }

                            else
                            {
                                Console.WriteLine("На 0 делить нельзя");
                            }

                        }

                        else
                        {
                            Console.WriteLine("Неверно введены данные");
                        }

                    }

                    else
                    {
                        Console.WriteLine("Неверно введены данные");
                    }

                }

                else
                {
                    Console.WriteLine("Неверно введены данные");
                }

            }

            else
            {
                Console.WriteLine("Неверно введены данные");
            }

            Console.ReadLine();
        }
        static int GetNumOfDaysByMonth(Month month)
        {

            if (month == Month.January)
            {
                return 31;
            }

            else if (month == Month.February)
            {
                return 28;
            }

            else if (month == Month.March)
            {
                return 31;
            }

            else if (month == Month.April)
            {
                return 30;
            }

            else if (month == Month.May)
            {
                return 31;
            }

            else if (month == Month.June)
            {
                return 30;
            }

            else if (month == Month.July)
            {
                return 31;
            }

            else if (month == Month.August)
            {
                return 31;
            }

            else if (month == Month.September)
            {
                return 30;
            }

            else if (month == Month.October)
            {
                return 31;
            }

            else if (month == Month.November)
            {
                return 30;
            }

            else if (month == Month.December)
            {
                return 31;
            }

            return 0;
        }
        static double Calculate(double firstNum,double secondNum,MathOperation operation)
        {

            if (operation == MathOperation.Add)
            {
                return firstNum + secondNum;                
            }

            else if (operation == MathOperation.Subtract)
            {
                return firstNum - secondNum;
            }

            else if (operation == MathOperation.Multiply)
            {
                return firstNum * secondNum;
            }

            else if (operation == MathOperation.Divide)
            {                
                return firstNum / secondNum;                                          
            }

            return 0;   
        }  
    }
}

    

