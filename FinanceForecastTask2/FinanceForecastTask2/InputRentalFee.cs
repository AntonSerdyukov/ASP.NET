namespace FinanceForecastTask2
{
    class InputRentalFee
    {
        public decimal RentalFee { get; }

        public InputRentalFee(string inputRentalFee)
        {

            if (decimal.TryParse(inputRentalFee, out decimal rentalFee) == true)
            {
                RentalFee = rentalFee;
            }
            else
            {
                RentalFee = -1;
            }

        }

    }
}
