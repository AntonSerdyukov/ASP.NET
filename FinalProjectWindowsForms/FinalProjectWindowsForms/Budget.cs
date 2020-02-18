namespace FinalProjectWindowsForms
{
    class Budget
    {
        public decimal OldBudget { get; }
        public decimal MonthProfit { get; }

        public Budget(string oldBudget,Incomes incomes,Expenses expenses)
        {
            Validator validator = new Validator();
            OldBudget =validator.ConvertToBudgetValue(oldBudget);
            MonthProfit = incomes.GetIncomes() - expenses.GetExpenses();
        }

        public decimal GetNewBudget()
        {
            return OldBudget + MonthProfit;
        }
    }
}
