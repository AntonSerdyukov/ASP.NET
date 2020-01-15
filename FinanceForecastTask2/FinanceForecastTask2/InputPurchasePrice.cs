namespace FinanceForecastTask2
{
    class InputPurchasePrice
    {
        public decimal PurchasePrice { get; }

        public InputPurchasePrice(string inputPurchasePrice)
        {

            if (decimal.TryParse(inputPurchasePrice, out decimal purchasePrice) == true)
            {
                PurchasePrice = purchasePrice;
            }
            else
            {
                PurchasePrice = -1;
            }

        }

    }
}
