using System;
using System.Collections.Generic;


namespace TrainingPart2_Task1
{
    class ExpensesOutput
    {
        List<double> expensesList;

        public ExpensesOutput(List<double> expensesList)
        {
            this.expensesList = expensesList;
        }

        public void Output()
        {
            Console.WriteLine("Расходы");

            foreach (double expense in expensesList)
            {
                Console.WriteLine(expense);
            }

        }

    }
}
