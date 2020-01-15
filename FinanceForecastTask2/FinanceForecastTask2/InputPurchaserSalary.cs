namespace FinanceForecastTask2
{
    class InputPurchaserSalary
    {
        public decimal PurchaserSalary { get; }

        public InputPurchaserSalary(string inputPurchaserSalary)
        {

            if (decimal.TryParse(inputPurchaserSalary, out decimal purchaserSalary) == true)
            {
                PurchaserSalary = purchaserSalary;
            }
            else
            {
                PurchaserSalary = -1;
            }

        }

    }
}
