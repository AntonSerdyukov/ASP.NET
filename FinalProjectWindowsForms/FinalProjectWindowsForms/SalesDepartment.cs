namespace FinalProjectWindowsForms
{
    class SalesDepartment
    {
        public decimal SalePrice { get; }
        public int NumOfSellingGoods { get; }

        public SalesDepartment(string numOfSellingGoods, string salePrice)
        {
            Validator validator = new Validator();
            SalePrice = validator.ConvertToDecimalValue(salePrice);
            NumOfSellingGoods = validator.ConvertToIntValue(numOfSellingGoods);
            
        }

        public decimal GetSaleIncomes()
        {
            return NumOfSellingGoods * SalePrice;
        }
    }
}
