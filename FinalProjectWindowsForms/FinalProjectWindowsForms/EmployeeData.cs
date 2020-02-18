namespace FinalProjectWindowsForms
{
    class EmployeeData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal PlannedSalary { get; set; }
        public decimal RealSalary { get; set; }
        public int NumOfSkippingDays { get; set; }
        public string ProfessionName { get; set; }
        public int NumOfOverWorkingDays { get; set; }

        public EmployeeData(string name, string surname, decimal plannedSalary, decimal realSalary,int numOfSkippingDays,int numOfOverWorkingDays, string professionName)
        {
            Name = name;
            Surname = surname;
            PlannedSalary = plannedSalary;
            RealSalary = realSalary;
            NumOfSkippingDays = numOfSkippingDays;
            NumOfOverWorkingDays = numOfOverWorkingDays;
            ProfessionName = professionName;
        }

    }
}
