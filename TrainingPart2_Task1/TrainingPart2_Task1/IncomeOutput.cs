using System;
using System.Collections.Generic;


namespace TrainingPart2_Task1
{
    class IncomeOutput
    {
        List<double> incomesList;

        public IncomeOutput(List<double> incomesList)
        {
            this.incomesList = incomesList;
        }

        public void Output()
        {
            Console.WriteLine("Доходы c учетом налога");

            foreach (double income in incomesList)
            {
                Console.WriteLine(income);
            }

        }

    }
}
