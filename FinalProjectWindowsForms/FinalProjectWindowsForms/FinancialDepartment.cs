namespace FinalProjectWindowsForms
{
    class FinancialDepartment
    {
        public decimal PurchasePrice { get; }
        public int NumOfPurchasingGoods { get; }

        public FinancialDepartment(string purchasePrice, string numOfPurchasingGoods)
        {
            Validator validator = new Validator();
            PurchasePrice = validator.ConvertToDecimalValue(purchasePrice);
            NumOfPurchasingGoods = validator.ConvertToIntValue(numOfPurchasingGoods);
        }

        public decimal GetPurchaseCosts()
        {
            return PurchasePrice * NumOfPurchasingGoods;
        }
    }
}
