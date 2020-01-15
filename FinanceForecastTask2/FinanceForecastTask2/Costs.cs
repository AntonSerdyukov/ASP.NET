namespace FinanceForecastTask2
{
    class Costs
    {
        public decimal PermanentCosts { get; }
        public decimal VariableCosts { get; }
        public decimal SumCosts { get; }

        public Costs(decimal accountantSalary, decimal sellerSalary, decimal purchaserSalary, decimal loaderSalary, decimal rentalFee, decimal purchasePrice, int numOfGoods)
        {
            PermanentCosts = accountantSalary + sellerSalary + purchaserSalary + loaderSalary + rentalFee;
            VariableCosts = purchasePrice * numOfGoods;
            SumCosts = PermanentCosts + VariableCosts;
        }

    }
}
