namespace FinanceForecastTask2
{
    class MonthGeneralIncome
    {
        public decimal GeneralIncome { get; }
        public decimal Balance { get; }

        public MonthGeneralIncome(decimal income, decimal costs, decimal budget)
        {
            GeneralIncome = income - costs;
            Balance = budget + GeneralIncome;
        }

    }
}
