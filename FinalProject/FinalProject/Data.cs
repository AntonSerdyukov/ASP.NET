using System;

namespace FinalProject
{

    class DataForJson
    {
        public decimal Income { get; set; }
        public decimal Costs { get; set; }
        public decimal Profit { get; set; }
        public decimal CurrentBudget { get; set; }
        public DateTime Date { get; set; }

        public DataForJson(decimal income,decimal costs,decimal profit,decimal currentBudget,DateTime date)
        {
            Income = income;
            Costs = costs;
            Profit = profit;
            CurrentBudget = currentBudget;
            Date = date;
        }

    }

}
