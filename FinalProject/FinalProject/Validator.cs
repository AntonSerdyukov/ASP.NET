namespace FinalProject
{

    class Validator
    {

        public decimal ConvertToDecimalValue(string value)
        {

            if (decimal.TryParse(value.Replace(".", ","), out decimal decimalValue)==true && decimalValue > 0)
            {
                return decimalValue;
            }
            else
            {
                return -1;
            }

        }

        public int ConvertToIntValue(string value)
        {

            if (int.TryParse(value, out int intValue) == true && intValue > 0)
            {
                return intValue;
            }
            else
            {
                return -1;
            }

        }

        public decimal ConvertToPercentValue(string value)
        {

            if (decimal.TryParse(value.Replace(".", ","), out decimal percentValue) == true && percentValue > 0 && percentValue < 100)
            {
                return percentValue;
            }
            else
            {
                return -1;
            }

        }

        public decimal ConvertToBudgetValue(string value)
        {

            if (decimal.TryParse(value.Replace(".", ","), out decimal budgetValue) == true)
            {
                return budgetValue;
            }
            else
            {
                return decimal.MinValue;
            }

        }

        public bool IsBudgetValue(string value)
        {

            if (decimal.TryParse(value.Replace(".", ","), out decimal budgetValue)==true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
