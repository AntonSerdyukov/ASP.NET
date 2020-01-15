namespace FinanceForecastTask2
{
    class InputAccountantSalary
    {
        public decimal AccountantSalary { get; }

        public InputAccountantSalary(string inputAccountantSalary)
        {

            if (decimal.TryParse(inputAccountantSalary, out decimal accountantSalary) == true)
            {
                AccountantSalary = accountantSalary;
            }
            else
            {
                AccountantSalary = -1;
            }

        }

    }
}
