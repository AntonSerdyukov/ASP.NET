namespace FinalProjectWindowsForms
{
    class Expenses
    {
        public decimal RentalFee { get; }
        public decimal AdditionalCosts { get; }
        public decimal CostsForSalaries { get; }

        public Expenses(string rentalFee, AccountantDepartment accountantDepartment, TransportDepartment transportDepartment, FinancialDepartment financialDepartment)
        {
            Validator validator = new Validator();
            RentalFee = validator.ConvertToDecimalValue(rentalFee);          
            CostsForSalaries = accountantDepartment.SumOfSalaries;
            AdditionalCosts = transportDepartment.GetLoadersCosts() + financialDepartment.GetPurchaseCosts();
        }

        public decimal GetExpenses()
        {
            return RentalFee +CostsForSalaries  + AdditionalCosts;
        }
    }
}
