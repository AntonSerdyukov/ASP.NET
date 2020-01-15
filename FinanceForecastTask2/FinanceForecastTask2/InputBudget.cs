namespace FinanceForecastTask2
{
    class InputBudget
    {
        public decimal Budget { get; set; }

        public InputBudget(string inputBudget)
        {

            if (decimal.TryParse(inputBudget, out decimal budget) == true)
            {
                Budget = budget;
            }
            else
            {
                Budget = -1;
            }

        }

    }
}
