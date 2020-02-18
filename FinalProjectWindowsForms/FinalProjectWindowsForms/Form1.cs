using System;
using System.Windows.Forms;

namespace FinalProjectWindowsForms
{
    public partial class FinancialHelperForm : Form
    {

        public FinancialHelperForm()
        {
            InitializeComponent();
        }

        private void FinancialHelperForm_Load(object sender, EventArgs e)
        {

        }

        private void InputMoneyData_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();
           
            if (validator.ConvertToDecimalValue(RentalFee.Text) != -1 && validator.ConvertToDecimalValue(LoaderPlanSalary.Text) != -1 && validator.ConvertToDecimalValue(PurchaserPlanSalary.Text) != -1 && validator.ConvertToDecimalValue(SellerPlanSalary.Text) != -1 && validator.ConvertToDecimalValue(AccountantPlanSalary.Text) != -1 && validator.ConvertToDecimalValue(PurchasePrice.Text) != -1 && validator.ConvertToDecimalValue(SalePrice.Text) != -1 && validator.ConvertToIntValue(NumOfSellingGoods.Text) != -1 && validator.ConvertToIntValue(NumOfPurchasingGoods.Text) != -1 && validator.ConvertToPercentValue(PercentOfTax.Text) != -1 && validator.IsBudgetValue(CurrentBudget.Text) == true && validator.ConvertToDecimalValue(BreakDownCosts.Text)!=-1 && validator.ConvertToDecimalValue(TreatmentCosts.Text)!=-1 && validator.ConvertToDecimalValue(FixExpenses.Text)!=-1 && validator.ConvertToDecimalValue(CurrentBudget.Text) != -1)
            {
                if (validator.ConvertToIntValue(NumOfSellingGoods.Text) <= validator.ConvertToIntValue(NumOfPurchasingGoods.Text))
                {
                    
                    FileForBudget fileForBudget = new FileForBudget();
                    IEmployeesFile empFile = new EmployeesFile();                  
                    FinancialDepartment financialDepartment = new FinancialDepartment(PurchasePrice.Text, NumOfPurchasingGoods.Text);
                    SalesDepartment salesDepartment = new SalesDepartment(NumOfSellingGoods.Text, SalePrice.Text);
                    TransportDepartment transportDepartment = new TransportDepartment(BreakDownCosts.Text, TreatmentCosts.Text, FixExpenses.Text);
                    AccountantDepartment accountantDepartment = new AccountantDepartment(empFile, SellerPlanSalary.Text, salesDepartment, financialDepartment, AccountantPlanSalary.Text, PurchaserPlanSalary.Text, LoaderPlanSalary.Text, PercentOfTax.Text);

                    if (accountantDepartment.GetNumOfAccountants() > 0 && accountantDepartment.GetNumOfLoaders() > 0 && accountantDepartment.GetNumOfPurchasers() > 0 && accountantDepartment.GetNumOfSellers() > 0)
                    {
                        Incomes incomes = new Incomes(salesDepartment, accountantDepartment);
                        DateCalendar.Visible = false;
                        DateTime newDate = DateCalendar.SelectionStart.AddDays(31);
                        DateCalendar.SetDate(newDate);
                        Expenses expenses = new Expenses(RentalFee.Text, accountantDepartment, transportDepartment, financialDepartment);
                        Budget budget = new Budget(CurrentBudget.Text, incomes, expenses);
                        BudgetData budgetData = new BudgetData(incomes.GetIncomes(), expenses.GetExpenses(), budget.MonthProfit, budget.GetNewBudget(), newDate);
                        fileForBudget.AddData(budgetData);
                        MonthIncome.Text = incomes.GetIncomes().ToString();
                        MonthCosts.Text = expenses.GetExpenses().ToString();
                        MonthProfit.Text = budget.MonthProfit.ToString();
                        CurrentBudget.Text = budget.GetNewBudget().ToString();
                        CurrentBudget.ReadOnly = false;
                        InputMonthLabel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно сотрудников");
                    }

                }
                else
                {
                    MessageBox.Show("Количество проданных товаров должно быть не больше числа закупленных");
                }
            }
            else
            {
                MessageBox.Show("Неверно введены данные");
            }
        }

        private void InputEmployeeData_Click(object sender, EventArgs e)
        {                       
            Validator validator = new Validator();

            if (ProfessionName.Text != string.Empty)
            {

                if (validator.ConvertToIntValue(NumOfSkippingDays.Text) != -1 && validator.ConvertToIntValue(NumOfOverWorkingDays.Text) != -1)
                {
                    EmployeesFile em = new EmployeesFile();
                    EmployeeData employeeData = new EmployeeData(EmployeeName.Text, EmployeeSurname.Text, 0, 0, validator.ConvertToIntValue(NumOfSkippingDays.Text), validator.ConvertToIntValue(NumOfOverWorkingDays.Text), ProfessionName.Text);

                    if (em.IsEmployeeExist(employeeData.Name,employeeData.Surname) == false)
                    {
                        em.AddData(employeeData);
                    }
                    else
                    {
                        MessageBox.Show("Такой пользователь уже существует");  
                    }

                }
                else
                {
                    MessageBox.Show("Количества пропущенных и переработанных дней должны быть целыми неотрицательными числами");
                }

            }
            else
            {
                MessageBox.Show("Не выбрана профессия");
            }

        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            EmployeesFile em = new EmployeesFile();
            em.RemoveData(EmployeeNameToDelete.Text, EmployeeSurnameToDelete.Text); 
        }

        private void RemoveAllMoneyData_Click(object sender, EventArgs e)
        {
            FileForBudget fileForBudget = new FileForBudget();
            fileForBudget.RemoveAllData(); 
        }

        private void DeleteAllEmployees_Click(object sender, EventArgs e)
        {
            EmployeesFile em = new EmployeesFile();
            em.RemoveAllData();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            EmployeesFile em = new EmployeesFile();
            Validator validator = new Validator();

            if (validator.ConvertToIntValue(EmployeeNumOfSkippingDaysEdit.Text) != -1 && validator.ConvertToIntValue(EmployeeNumOfOverWorkDaysEdit.Text) != -1)
            {
                em.EditEmployee(EmployeeNameToEdit.Text, EmployeeSurnameToEdit.Text, EmployeeNumOfSkippingDaysEdit.Text, EmployeeNumOfOverWorkDaysEdit.Text);
            }
            else
            {
                MessageBox.Show("Неверно введены данные");
            }
        
        }

        private void BreakDownExpenses_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
