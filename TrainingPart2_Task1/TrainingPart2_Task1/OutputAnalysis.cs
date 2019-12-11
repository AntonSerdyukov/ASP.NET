using System;
using System.Collections.Generic;
using WorkWithDataLibrary;

namespace TrainingPart2_Task1
{
    class OutputAnalysis
    {
        List<double> profits = new List<double>();
        DataAnalysis dataAnalysis;

        public OutputAnalysis(List<double> incomes, List<double> expenses)
        {
            dataAnalysis = new DataAnalysis(incomes, expenses);
            dataAnalysis.GetProfits();
        }

        public void OutputSumProfit()
        {
            Console.WriteLine("Суммарная прибыль");
            Console.WriteLine(dataAnalysis.GetSumProfit());
        }

        public void OutputAverageProfit()
        {
            Console.WriteLine("Средняя прибыль");
            Console.WriteLine(dataAnalysis.GetAverageProfit());
        }

        public void OutputMaxProfit()
        {
            Console.WriteLine("Максимальная прибыль");
            Console.WriteLine(dataAnalysis.GetMaxProfit());
        }

        public void OutputMinProfit()
        {
            Console.WriteLine("Минимальная прибыль");
            Console.WriteLine(dataAnalysis.GetMinProfit());
        }

        public void OutputSumIncome()
        {
            Console.WriteLine("Суммарный доход");
            Console.WriteLine(dataAnalysis.GetSumIncome());
        }

        public void OutputMaxIncome()
        {
            Console.WriteLine("Максимальный доход");
            Console.WriteLine(dataAnalysis.GetMaxIncome());
        }

        public void OutputMinIncome()
        {
            Console.WriteLine("Минимальный доход");
            Console.WriteLine(dataAnalysis.GetMinIncome());
        }

        public void OutputSumExpense()
        {
            Console.WriteLine("Суммарный расход");
            Console.WriteLine(dataAnalysis.GetSumExpense());
        }

        public void OutputMinExpense()
        {
            Console.WriteLine("Минимальный расход");
            Console.WriteLine(dataAnalysis.GetMinExpense());
        }

        public void OutputMaxExpense()
        {
            Console.WriteLine("Максимальный расход");
            Console.WriteLine(dataAnalysis.GetMaxExpense());
        }

    }
}
