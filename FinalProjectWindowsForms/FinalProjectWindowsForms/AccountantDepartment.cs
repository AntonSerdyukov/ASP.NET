using System;
using System.Collections.Generic;

namespace FinalProjectWindowsForms
{
    class AccountantDepartment
    {
        public double PercentOfSales { get; }
        public decimal SellerPlannedSalary { get; }   
        public decimal AccountantPlannedSalary { get; }
        public decimal PurchaserPlannedSalary { get; }
        public decimal LoaderPlannedSalary { get; }
        public double TaxPercent { get; }
        public List<EmployeeData> EmployeesData { get; } 
        public EmployeeData EmpData { get; }
        public decimal SumOfSalaries { get; }
        public EmployeesFile EmpFile { get; }

        public AccountantDepartment(IEmployeesFile empFile,string sellerSalary, SalesDepartment salesDepartment,FinancialDepartment financialDepartment, string accountantSalary, string purchaserSalary, string loaderSalary, string taxPercent)
        { 
            EmpFile =(EmployeesFile) empFile;
            EmployeesData = empFile.FileData; 
            Validator validator = new Validator();
            PercentOfSales = salesDepartment.NumOfSellingGoods/financialDepartment.NumOfPurchasingGoods;
            SellerPlannedSalary = validator.ConvertToDecimalValue(sellerSalary);
            AccountantPlannedSalary = validator.ConvertToIntValue(accountantSalary);
            LoaderPlannedSalary = validator.ConvertToIntValue(loaderSalary);
            PurchaserPlannedSalary = validator.ConvertToDecimalValue(purchaserSalary);
            TaxPercent = validator.ConvertToPercentValue(taxPercent);
            SumOfSalaries = GetSumOfSalaries(GetRealSalaries(GetPlannedSalaries(EmployeesData))); 
        }

        public List<EmployeeData> GetPlannedSalaries(List<EmployeeData> employeesData)
        {
            for (int i = 0; i < employeesData.Count; i++)
            {
                
                switch (employeesData[i].ProfessionName)
                {
                    case "Продавец":
                        employeesData[i].PlannedSalary = SellerPlannedSalary;
                        break;
                    case "Бухгалтер":
                        employeesData[i].PlannedSalary = AccountantPlannedSalary;
                        break;
                    case "Грузчик":
                        employeesData[i].PlannedSalary = LoaderPlannedSalary;
                        break;
                    case "Закупщик":
                        employeesData[i].PlannedSalary = PurchaserPlannedSalary;
                         break;
                }
                
             EmpFile.EditEmployeeByPlanSalary(employeesData[i], employeesData[i].PlannedSalary);
            }

            return employeesData;
        }

        public List<EmployeeData> GetRealSalaries(List<EmployeeData> employeesData)
        { 
            for (int i = 0; i < employeesData.Count; i++)
            {
                employeesData[i].RealSalary = Math.Round(employeesData[i].PlannedSalary+ employeesData[i].PlannedSalary * (employeesData[i].NumOfOverWorkingDays -employeesData[i].NumOfSkippingDays) / 31,2);

                if (employeesData[i].ProfessionName == "Продавец")
                {

                    if (PercentOfSales > 0.95)
                    {
                        employeesData[i].RealSalary +=Math.Round( (decimal)0.05 * employeesData[i].RealSalary,2);

                    }
                    else if (PercentOfSales < 0.85)
                    {
                        employeesData[i].RealSalary -= Math.Round((decimal)0.15 * employeesData[i].RealSalary,2);
                    }
                    else if (PercentOfSales < 0.7)
                    {
                        employeesData[i].RealSalary -= Math.Round((decimal)0.25 * employeesData[i].RealSalary,2);
                    }

                }

                EmpFile.EditEmployeeByRealSalary(employeesData[i], employeesData[i].RealSalary);
            }

            return employeesData;
        }

        public  decimal GetSumOfSalaries(List<EmployeeData> employeesData)
        {
            decimal sum = 0;

            for (int i = 0; i < employeesData.Count; i++)
            {
                sum += employeesData[i].RealSalary;
            }

            return sum;
        }
        
        public int GetNumOfAccountants()
        {
            int accountantsNum=0;

            foreach(EmployeeData empData in EmployeesData)
            {

                if (empData.ProfessionName == "Бухгалтер")
                {
                    accountantsNum++;
                }

            }

            return accountantsNum;

        }

        public int GetNumOfPurchasers()
        {
            int purchasersNum = 0;

            foreach (EmployeeData empData in EmployeesData)
            {

                if (empData.ProfessionName == "Закупщик")
                {
                    purchasersNum++;
                }

            }

            return purchasersNum;
        }

        public int GetNumOfSellers()
        {
            int sellersNum = 0;

            foreach (EmployeeData empData in EmployeesData)
            {

                if (empData.ProfessionName == "Продавец")
                {
                    sellersNum++;
                }

            }

            return sellersNum;
        }

        public int GetNumOfLoaders()
        {
            int loadersNum = 0;

            foreach (EmployeeData empData in EmployeesData)
            {

                if (empData.ProfessionName == "Грузчик")
                {
                    loadersNum++;
                }

            }

            return loadersNum;
        }

    }
}
