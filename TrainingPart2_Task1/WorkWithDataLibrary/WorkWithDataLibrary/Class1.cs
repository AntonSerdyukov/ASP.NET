using System.Collections.Generic;
using System.Linq;


namespace WorkWithDataLibrary
{

    public class DataAnalysis
    {
        List<double> profits = new List<double>();
        List<double> incomes;
        List<double> expenses;

        public DataAnalysis(List<double> incomes, List<double> expenses)
        {
            this.incomes = incomes;
            this.expenses = expenses;
        }

        public List<double> GetProfits()
        {

            for (int i = 0; i < incomes.Count; i++)
            {
                profits.Add(incomes[i] - expenses[i]);
            }

            return profits;
        }

        public double GetSumProfit()
        {
            return profits.Sum();
        }

        public double GetAverageProfit()
        {
            return profits.Sum() / profits.Count;
        }

        public double GetMaxProfit()
        {
            return profits.Max();
        }

        public double GetMinProfit()
        {
            return profits.Min();
        }

        public double GetMaxIncome()
        {
            return incomes.Max();
        }

        public double GetMinIncome()
        {
            return incomes.Min();
        }

        public double GetSumIncome()
        {
            return incomes.Sum();
        }

        public double GetMaxExpense()
        {
            return expenses.Max();
        }

        public double GetMinExpense()
        {
            return expenses.Min();
        }

        public double GetSumExpense()
        {
            return expenses.Sum();
        }

    }

    public class DataForGraphic
    {
        List<double> dataList = new List<double>();

        public DataForGraphic(List<double> dataList)
        {
            this.dataList = dataList;
        }

        public string[,] GetDataForGraphic()
        {
            double verticalScaleDivision = (dataList.Max() - dataList.Min()) / dataList.Count;
            string[,] arrayForDrawing = new string[dataList.Count, dataList.Count];

            for (int i = 0; i < dataList.Count; i++)
            {

                for (int j = 0; j < dataList.Count; j++)
                {

                    if (dataList[j] <= dataList.Max() - verticalScaleDivision * i && dataList[j] >= dataList.Max() - verticalScaleDivision * (i+1))
                    {
                        arrayForDrawing[i, j] = "* ";
                    }
                    else
                    {

                        if (arrayForDrawing[i, j] != "* ")
                        {
                            arrayForDrawing[i, j] = "  ";
                        }

                    }

                }

            }

            return arrayForDrawing;
        }
    }

    public class DataForDiagram
    {
        List<double> dataList = new List<double>();

        public DataForDiagram(List<double> dataList)
        {
            this.dataList = dataList;
        }

        public string[,] GetDataForDiagram()
        {
            double verticalScaleDivision = (dataList.Max() - dataList.Min()) / (dataList.Count);
            string[,] arrayForDrawing = new string[dataList.Count, dataList.Count];

            for (int i = 0; i < dataList.Count; i++)
            {

                for (int j = 0; j < dataList.Count; j++)
                {

                    if (dataList[j] <= dataList.Max() - verticalScaleDivision * i && dataList[j] >= dataList.Max() - verticalScaleDivision * (i+1))
                    {
                        arrayForDrawing[i, j] = "* ";

                        for (int k = i; k < dataList.Count; k++)
                        {
                            arrayForDrawing[k, j] = "* ";
                        }

                    }
                    else
                    {
                        if (arrayForDrawing[i, j] != "* ")
                        {
                            arrayForDrawing[i, j] = "  ";
                        }

                    }

                }

            }

            return arrayForDrawing;
        }

    }
}

        

