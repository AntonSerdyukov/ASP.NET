namespace FinanceForecastTask2
{
    class InputSalePrice
    {
        public decimal SalePrice { get; }

        public InputSalePrice(string inputSalePrice)
        {

            if (decimal.TryParse(inputSalePrice, out decimal salePrice) == true)
            {
                SalePrice = salePrice;
            }
            else
            {
                SalePrice = -1;
            }

        }

    }
}
