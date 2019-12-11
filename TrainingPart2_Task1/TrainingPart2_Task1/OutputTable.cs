using System;
using System.Collections.Generic;


namespace TrainingPart2_Task1
{
    class OutputTable
    {
        List<double> incomesList = new List<double>();
        List<double> expensesList = new List<double>();

        public OutputTable(List<double> incomesList, List<double> expensesList)
        {
            this.incomesList = incomesList;
            this.expensesList = expensesList;
        }

        public void DrawTable()
        {
            Console.WriteLine("Доход \tРасход");

            for (int i = 0; i < incomesList.Count; i++)
            {
                Console.WriteLine(incomesList[i] + "\t" + expensesList[i]);
            }

        }

    }
}
