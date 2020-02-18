namespace FinalProjectWindowsForms
{
    class TransportDepartment
    {
        public decimal BreakDownsCosts { get; }
        public decimal TreatmentCosts { get; }
        public decimal FixCosts { get; }

        public TransportDepartment(string breakDownsCosts, string treatmentCosts, string fixCosts)
        {
            Validator validator = new Validator();
            BreakDownsCosts = validator.ConvertToDecimalValue(breakDownsCosts);
            TreatmentCosts = validator.ConvertToDecimalValue(treatmentCosts);
            FixCosts= validator.ConvertToDecimalValue(fixCosts);
        }

        public decimal GetLoadersCosts()
        {
            return BreakDownsCosts + TreatmentCosts + FixCosts;
        }
    }
}
