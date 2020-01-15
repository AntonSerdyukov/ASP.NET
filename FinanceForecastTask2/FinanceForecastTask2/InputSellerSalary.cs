namespace FinanceForecastTask2
{
    class InputSellerSalary
    {
        public decimal SellerSalary { get; }

        public InputSellerSalary(string inputSellerSalary)
        {

            if (decimal.TryParse(inputSellerSalary, out decimal sellerSalary) == true)
            {
                SellerSalary = sellerSalary;
            }
            else
            {
                SellerSalary = -1;
            }

        }

    }
}
