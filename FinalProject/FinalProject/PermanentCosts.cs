namespace FinalProject
{

    class PermanentCosts
    {
        public decimal RentalFee { get;  }
        public decimal LoaderSalary { get; }
        public decimal PurchaserSalary { get; }
        public decimal SellerSalary { get; }
        public decimal AccountantSalary { get; }       
        public int NumOfLoaders { get; }
        public int NumOfPurchasers { get; }
        public int NumOfSellers { get; }
        public int NumOfAccountants { get; }   
            
        public PermanentCosts(string rentalFee, string loaderSalary, string purchaserSalary, string sellerSalary,string accountantSalary,string numOfLoaders, string numOfPurchasers, string numOfSellers, string numOfAccountants)
        {
            Validator validator = new Validator();            
            RentalFee = validator.ConvertToDecimalValue(rentalFee);
            LoaderSalary = validator.ConvertToDecimalValue(loaderSalary);
            PurchaserSalary = validator.ConvertToDecimalValue(purchaserSalary);
            SellerSalary = validator.ConvertToDecimalValue(sellerSalary);
            AccountantSalary = validator.ConvertToDecimalValue(accountantSalary);         
            NumOfLoaders = validator.ConvertToIntValue(numOfLoaders);
            NumOfPurchasers = validator.ConvertToIntValue(numOfPurchasers);
            NumOfSellers = validator.ConvertToIntValue(numOfSellers);
            NumOfAccountants = validator.ConvertToIntValue(numOfAccountants);                       
        }
              
        public decimal GetPermanentCosts()
        {
            return RentalFee + LoaderSalary * NumOfLoaders + PurchaserSalary * NumOfPurchasers + SellerSalary * NumOfSellers + AccountantSalary * NumOfAccountants;
        }
        
    }

}
