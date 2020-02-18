using System;

namespace FinalProjectWindowsForms
{
    class BudgetData
    {
        public decimal Income { get; set; }
        public decimal Costs { get; set; }
        public decimal Profit { get; set; }     
        public decimal CurrentBudget { get; set; }
        public DateTime Date { get; set; }

        public BudgetData(decimal income, decimal costs, decimal profit,decimal currentBudget, DateTime date)
        {
            Income = income;
            Costs = costs;
            Profit = profit; 
            CurrentBudget = currentBudget;
            Date = date;
        }

    }
}
