using System;
using System.Collections.Generic;


namespace TrainingPart2_Task1
{
    class ExpensesInput
    {
        List<double> expenses;

        public ExpensesInput(List<double> expenses)
        {
            this.expenses = expenses;
        }

        public void Input()
        {           
            Console.WriteLine("Введите расход");
            bool isExpenseCorrect = double.TryParse(Console.ReadLine().Replace(".", ","), out double inputExpense);

            if (isExpenseCorrect == true && inputExpense >= 0)
            {
                expenses.Add(inputExpense);
            }
            else
            {
                Console.WriteLine("Неверно введены данные");
                Input();
            }

        }

        public List<double> Expenses
        {

            get
            {
                return expenses;
            }

        }

    }
}
