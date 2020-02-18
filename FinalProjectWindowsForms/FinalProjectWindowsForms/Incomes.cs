namespace FinalProjectWindowsForms
{
    class Incomes
    {
        public decimal SaleIncomes { get; }

        public Incomes(SalesDepartment salesDepartment, AccountantDepartment accountantDepartment)
        {
            SaleIncomes = salesDepartment.GetSaleIncomes() * (1-(decimal)accountantDepartment.TaxPercent/100);
        }

        public decimal GetIncomes()
        {
            return SaleIncomes;
        }
    }
}
