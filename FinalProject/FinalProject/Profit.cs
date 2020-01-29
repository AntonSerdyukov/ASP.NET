namespace FinalProject
{

    class Profit
    {
        public int NumOfGoods { get; }
        public decimal PercentTax { get; }
        public  VariableCosts VariableCosts { get; }
        public PermanentCosts PermanentCosts { get; }
        public Income IncomeOfOneGood { get; }

        public Profit(PermanentCosts permanentCosts, VariableCosts variableCosts, Income incomeOfOneGood, string numOfGoods,string percentTaxText)
        {
            PercentTax =  decimal.Parse(percentTaxText);
            Validator validator = new Validator();
            PermanentCosts = permanentCosts;
            VariableCosts = variableCosts;
            IncomeOfOneGood = incomeOfOneGood;
            NumOfGoods = validator.ConvertToIntValue(numOfGoods);
        }

        public decimal GetSumCosts()
        {
            return VariableCosts.PurchasePrice * NumOfGoods+ PermanentCosts.GetPermanentCosts();
        }

        public decimal GetSumIncome()
        {
            return IncomeOfOneGood.SalePrice * NumOfGoods*(1-PercentTax/100);
        }

        public decimal GetProfit()
        {
            return GetSumIncome()-GetSumCosts();
        }
    
    }

}
