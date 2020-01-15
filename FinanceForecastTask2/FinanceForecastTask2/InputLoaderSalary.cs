namespace FinanceForecastTask2
{
    class InputLoaderSalary
    {
        public decimal LoaderSalary { get; }

        public InputLoaderSalary(string inputLoaderSalary)
        {

            if (decimal.TryParse(inputLoaderSalary, out decimal loaderSalary) == true)
            {
                LoaderSalary = loaderSalary;
            }
            else
            {
                LoaderSalary = -1;
            }

        }

    }
}
