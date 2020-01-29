namespace FinalProject
{

    class Budget
    {
        public decimal OldBudget { get; }
        public Profit Profit { get; }
        
        public Budget(Profit profit,string oldBudget)
        {
            Validator validator = new Validator();
            Profit = profit;
            OldBudget= validator.ConvertToBudgetValue(oldBudget);       
        }

        public decimal GetCurrentBudget()
        {
            return OldBudget+Profit.GetProfit();
        }
          
    }

}
