namespace FinalProject
{

    class Income
    {
        public decimal SalePrice { get; }
       
        public Income(string salePrice)
        {
            Validator validator = new Validator();
            SalePrice = validator.ConvertToDecimalValue(salePrice);
        }
      
    }

}
