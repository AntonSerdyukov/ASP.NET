using System;
using System.Collections.Generic;


namespace TrainingPart2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> incomes = new List<double>();
            List<double> expenses = new List<double>();
            NumOfPairsInput numOfPairsInput = new NumOfPairsInput();
            int numOfPairs = numOfPairsInput.InputNumOfPairs();
            IncomeInput incomeInput = new IncomeInput(incomes);
            ExpensesInput expensesInput = new ExpensesInput(expenses);

            for (int i = 0; i < numOfPairs; i++)
            {
                incomeInput.Input();
                expensesInput.Input();
            }

            Console.WriteLine("Вывод данных");
            IncomeOutput incomeOutput = new IncomeOutput(incomeInput.Incomes);
            incomeOutput.Output();
            ExpensesOutput expensesOutput = new ExpensesOutput(expensesInput.Expenses);
            expensesOutput.Output();
            Console.WriteLine("Анализ данных");
            OutputAnalysis outputAnalysis = new OutputAnalysis(incomeInput.Incomes, expensesInput.Expenses);
            outputAnalysis.OutputSumIncome();
            outputAnalysis.OutputSumExpense();
            outputAnalysis.OutputSumProfit();
            outputAnalysis.OutputAverageProfit();
            outputAnalysis.OutputMaxProfit();
            outputAnalysis.OutputMinProfit();
            outputAnalysis.OutputMaxIncome();
            outputAnalysis.OutputMinIncome();
            outputAnalysis.OutputMaxExpense();
            outputAnalysis.OutputMinExpense();
            Console.WriteLine("Таблица");
            OutputTable outputTable = new OutputTable(incomeInput.Incomes, expensesInput.Expenses);
            outputTable.DrawTable();
            Console.WriteLine("Точечный график доходов");
            OutputGraphic outputIncomeGraphic = new OutputGraphic(incomeInput.Incomes);
            outputIncomeGraphic.DrawGraphic();
            Console.WriteLine("Точечный график расходов");
            OutputGraphic outputExpensesGraphic = new OutputGraphic(expensesInput.Expenses);
            outputExpensesGraphic.DrawGraphic();
            Console.WriteLine("Столбчатая диаграмма доходов");
            OutputDiagram outputIncomeDiagram = new OutputDiagram(incomeInput.Incomes);
            outputIncomeDiagram.DrawDiagram();
            Console.WriteLine("Столбчатая диаграмма расходов");
            OutputDiagram outputExpensesDiagram = new OutputDiagram(expensesInput.Expenses);
            outputExpensesDiagram.DrawDiagram();
            Console.ReadLine();
        }
    }
}
