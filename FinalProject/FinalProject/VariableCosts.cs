namespace FinalProject
{

    class VariableCosts
    {
        public decimal PurchasePrice { get; }
       
        public VariableCosts(string purchasePrice,string percentTax)
        {
            Validator validator = new Validator();           
            PurchasePrice = validator.ConvertToDecimalValue(purchasePrice);
        }
              
    }

}
