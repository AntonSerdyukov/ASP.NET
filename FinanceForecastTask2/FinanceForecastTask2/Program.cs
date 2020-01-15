using System;

namespace FinanceForecastTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            InputBudget inputBudget;

            do
            {
                Console.WriteLine("Введите бюджет");
                inputBudget = new InputBudget(Console.ReadLine());
            }
            while (inputBudget.Budget <= 0);

            InputRentalFee inputRentalFee;

            do
            {
                Console.WriteLine("Введите арендную плату");
                inputRentalFee = new InputRentalFee(Console.ReadLine());
            }
            while (inputRentalFee.RentalFee <= 0);

            InputLoaderSalary inputLoaderSalary;

            do
            {
                Console.WriteLine("Введите зарплату грузчика");
                inputLoaderSalary = new InputLoaderSalary(Console.ReadLine());
            }
            while (inputLoaderSalary.LoaderSalary <= 0);

            InputPurchaserSalary inputPurchaserSalary;

            do
            {
                Console.WriteLine("Введите зарплату закупщика");
                inputPurchaserSalary = new InputPurchaserSalary(Console.ReadLine());
            }
            while (inputPurchaserSalary.PurchaserSalary <= 0);

            InputSellerSalary inputSellerSalary;

            do
            {
                Console.WriteLine("Введите зарплату продавца");
                inputSellerSalary = new InputSellerSalary(Console.ReadLine());
            }
            while (inputSellerSalary.SellerSalary <= 0);

            InputAccountantSalary inputAccountantSalary;

            do
            {
                Console.WriteLine("Введите зарплату бухгалтера");
                inputAccountantSalary = new InputAccountantSalary(Console.ReadLine());
            }
            while (inputAccountantSalary.AccountantSalary <= 0);

            Month month = new Month();
            month.NumOfMonth = 0;

            do
            {
                month.NumOfMonth++;
                InputNumOfGoods inputNumOfGoods;

                do
                {
                    Console.WriteLine($"Введите число закупленных товаров на {month.NumOfMonth}-й месяц");
                    inputNumOfGoods = new InputNumOfGoods(Console.ReadLine());
                }
                while (inputNumOfGoods.NumOfGoods <= 0);

                InputPurchasePrice inputPurchasePrice;

                do
                {
                    Console.WriteLine($"Введите цену покупки товара на {month.NumOfMonth}-й месяц");
                    inputPurchasePrice = new InputPurchasePrice(Console.ReadLine());
                }
                while (inputPurchasePrice.PurchasePrice <= 0);

                InputSalePrice inputSalePrice;

                do
                {
                    Console.WriteLine($"Введите цену продажи товара на {month.NumOfMonth}-й месяц");
                    inputSalePrice = new InputSalePrice(Console.ReadLine());
                }
                while (inputSalePrice.SalePrice <= 0);

                Costs costs = new Costs(inputAccountantSalary.AccountantSalary, inputSellerSalary.SellerSalary, inputPurchaserSalary.PurchaserSalary, inputLoaderSalary.LoaderSalary, inputRentalFee.RentalFee, inputPurchasePrice.PurchasePrice, inputNumOfGoods.NumOfGoods);
                Console.WriteLine($"Постоянные расходы {month.NumOfMonth}-го месяца");
                Console.WriteLine(costs.PermanentCosts);
                Console.WriteLine($"Временные расходы {month.NumOfMonth}-го месяца");
                Console.WriteLine(costs.VariableCosts);
                Console.WriteLine($"Суммарные расходы {month.NumOfMonth}-го месяца");
                Console.WriteLine(costs.SumCosts);
                SaleIncome saleIncome = new SaleIncome(inputSalePrice.SalePrice, inputNumOfGoods.NumOfGoods);
                Console.WriteLine($"Доход {month.NumOfMonth}-го месяца");
                Console.WriteLine(saleIncome.SalesIncome);
                MonthGeneralIncome monthGeneralIncome = new MonthGeneralIncome(saleIncome.SalesIncome, costs.SumCosts, inputBudget.Budget);
                Console.WriteLine($"Месячная прибыль {month.NumOfMonth}-го месяца");
                Console.WriteLine(monthGeneralIncome.GeneralIncome);
                Console.WriteLine($"Баланс после {month.NumOfMonth}-го месяца");
                Console.WriteLine(monthGeneralIncome.Balance);
                inputBudget.Budget = monthGeneralIncome.Balance;
                Console.WriteLine("Введите 1, если хотите продолжить прогноз");
            }
            while (Console.ReadLine() == "1");

        }
    }
}
