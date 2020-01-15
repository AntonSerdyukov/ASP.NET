namespace FinanceForecastTask2
{
    class SaleIncome
    {
        public decimal SalesIncome { get; }

        public SaleIncome(decimal salesIncome, int numOfGoods)
        {
            SalesIncome = salesIncome * numOfGoods;
        }

    }
}
