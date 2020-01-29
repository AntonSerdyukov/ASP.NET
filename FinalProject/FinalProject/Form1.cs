using System;
using System.Windows.Forms;

namespace FinalProject
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            if (validator.ConvertToDecimalValue(RentalFee.Text) != -1 && validator.ConvertToDecimalValue(LoaderSalary.Text) != -1 && validator.ConvertToDecimalValue(PurchaserSalary.Text) != -1 && validator.ConvertToDecimalValue(SellerSalary.Text) != -1 && validator.ConvertToDecimalValue(AccountantSalary.Text) != -1 && validator.ConvertToIntValue(NumOfLoaders.Text) != -1 && validator.ConvertToIntValue(NumOfPurchasers.Text) != -1 && validator.ConvertToIntValue(NumOfSellers.Text) != -1 && validator.ConvertToIntValue(NumOfAccountants.Text) != -1 && validator.ConvertToDecimalValue(PurchasePrice.Text) != -1 && validator.ConvertToDecimalValue(SalePrice.Text) != -1 && validator.ConvertToIntValue(NumOfGoods.Text) != -1 && validator.ConvertToPercentValue(PercentTax.Text) != -1 && validator.IsBudgetValue(CurrentBudget.Text) == true)
            {
                PermanentCosts permanentCosts = new PermanentCosts(RentalFee.Text, LoaderSalary.Text, PurchaserSalary.Text, SellerSalary.Text, AccountantSalary.Text, NumOfLoaders.Text, NumOfPurchasers.Text, NumOfSellers.Text, NumOfAccountants.Text);
                VariableCosts variableCosts = new VariableCosts(PurchasePrice.Text, PercentTax.Text);
                Income income = new Income(SalePrice.Text);
                Profit profit = new Profit(permanentCosts, variableCosts, income, NumOfGoods.Text, PercentTax.Text);
                Budget budget = new Budget(profit, CurrentBudget.Text);
                monthCalendar1.Visible  = false;
                DateTime newDate = monthCalendar1.SelectionStart.AddDays(31);
                DataForJson data = new DataForJson(profit.GetSumIncome(), profit.GetSumCosts(), profit.GetProfit(), budget.GetCurrentBudget(), newDate);
                JsonFile jsonFile = new JsonFile();
                jsonFile.AddData(data);
                monthCalendar1.SetDate(newDate);
                MonthIncome.Text = profit.GetSumIncome().ToString();
                MonthProfit.Text = profit.GetProfit().ToString();
                MonthCosts.Text = profit.GetSumCosts().ToString();
                CurrentBudget.Text = budget.GetCurrentBudget().ToString();
                InputDateText.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверно введены данные");
            }
                     
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MonthIncome.Clear();
            MonthProfit.Clear();
            MonthCosts.Clear();
            CurrentBudget.Clear();
            RentalFee.Clear();
            AccountantSalary.Clear();
            SellerSalary.Clear();
            LoaderSalary.Clear();
            PurchaserSalary.Clear();
            NumOfAccountants.Clear();
            NumOfGoods.Clear();
            NumOfLoaders.Clear();
            NumOfPurchasers.Clear();
            NumOfSellers.Clear();
            PurchasePrice.Clear();
            SalePrice.Clear();
            PercentTax.Clear();
        }

        private void DrawGraphics_Click(object sender, EventArgs e)
        {
            JsonFile jsonFile = new JsonFile();
            HistogramText.Visible = true;
            BudgetHistogram.Visible = true;         
            BudgetHistogram.Series[0].Points.Clear();
            GraphText.Visible = true;
            BudgetGraph.Visible = true;
            BudgetGraph.Series[0].Points.Clear();
            TableText.Visible = true;
            IncomeAndCostsTable.Visible = true;
            IncomeAndCostsTable.Rows.Clear();

            for (int i = 0; i < jsonFile.FileData.Count; i++)
            {                                 
                BudgetHistogram.Series[0].Points.AddXY(jsonFile.FileData[i].Date.ToLongDateString(), jsonFile.FileData[i].CurrentBudget);
                BudgetGraph.Series[0].Points.AddXY(jsonFile.FileData[i].Date.ToLongDateString(), jsonFile.FileData[i].CurrentBudget);
                IncomeAndCostsTable.Rows.Add(jsonFile.FileData[i].Date, jsonFile.FileData[i].CurrentBudget, jsonFile.FileData[i].Profit, jsonFile.FileData[i].Income, jsonFile.FileData[i].Costs);               
            }
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JsonFile jsonFile = new JsonFile();
            jsonFile.RemoveAllData();
        }

        private void DeleteDataByDate_Click(object sender, EventArgs e)
        {
            JsonFile jsonFile = new JsonFile();

            if (DateTime.TryParse(DataToDelete.Text,out DateTime date)==true)
            {
                jsonFile.RemoveData(date);
            }
            else
            {
                MessageBox.Show("Записи с такой датой в файле нет");
            }
                                   
        }

        private void BudgetHistogram_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void StopProgramButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }

}
