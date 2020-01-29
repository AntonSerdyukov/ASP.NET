namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MonthIncome = new System.Windows.Forms.TextBox();
            this.MonthCosts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BudgetGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BudgetHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HistogramText = new System.Windows.Forms.Label();
            this.GraphText = new System.Windows.Forms.Label();
            this.InputDataButton = new System.Windows.Forms.Button();
            this.LoaderSalary = new System.Windows.Forms.TextBox();
            this.PurchaserSalary = new System.Windows.Forms.TextBox();
            this.NumOfLoaders = new System.Windows.Forms.TextBox();
            this.NumOfPurchasers = new System.Windows.Forms.TextBox();
            this.SellerSalary = new System.Windows.Forms.TextBox();
            this.NumOfSellers = new System.Windows.Forms.TextBox();
            this.AccountantSalary = new System.Windows.Forms.TextBox();
            this.NumOfAccountants = new System.Windows.Forms.TextBox();
            this.PurchasePrice = new System.Windows.Forms.TextBox();
            this.SalePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RentalFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NumOfGoods = new System.Windows.Forms.TextBox();
            this.CurrentBudget = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PercentTax = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.IncomeAndCostsTable = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.MonthProfit = new System.Windows.Forms.TextBox();
            this.ClearInputData = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.DrawGraphics = new System.Windows.Forms.Button();
            this.DeleteAllData = new System.Windows.Forms.Button();
            this.DeleteDataByDate = new System.Windows.Forms.Button();
            this.DataToDelete = new System.Windows.Forms.TextBox();
            this.InputDateText = new System.Windows.Forms.Label();
            this.DataForDelete = new System.Windows.Forms.Label();
            this.TableText = new System.Windows.Forms.Label();
            this.NumOfMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benefit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopProgramButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeAndCostsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthIncome
            // 
            this.MonthIncome.Location = new System.Drawing.Point(537, 84);
            this.MonthIncome.Name = "MonthIncome";
            this.MonthIncome.ReadOnly = true;
            this.MonthIncome.Size = new System.Drawing.Size(100, 20);
            this.MonthIncome.TabIndex = 0;
            // 
            // MonthCosts
            // 
            this.MonthCosts.Location = new System.Drawing.Point(668, 84);
            this.MonthCosts.Name = "MonthCosts";
            this.MonthCosts.ReadOnly = true;
            this.MonthCosts.Size = new System.Drawing.Size(100, 20);
            this.MonthCosts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доход за месяц";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Расход за месяц";
            // 
            // BudgetGraph
            // 
            chartArea3.Name = "ChartArea1";
            this.BudgetGraph.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BudgetGraph.Legends.Add(legend3);
            this.BudgetGraph.Location = new System.Drawing.Point(527, 364);
            this.BudgetGraph.Name = "BudgetGraph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "бел.руб";
            this.BudgetGraph.Series.Add(series3);
            this.BudgetGraph.Size = new System.Drawing.Size(300, 199);
            this.BudgetGraph.TabIndex = 4;
            this.BudgetGraph.Text = "chart1";
            this.BudgetGraph.Visible = false;
            this.BudgetGraph.Click += new System.EventHandler(this.chart1_Click);
            // 
            // BudgetHistogram
            // 
            chartArea4.Name = "ChartArea1";
            this.BudgetHistogram.ChartAreas.Add(chartArea4);
            legend4.Name = "Общий бюджет";
            this.BudgetHistogram.Legends.Add(legend4);
            this.BudgetHistogram.Location = new System.Drawing.Point(527, 170);
            this.BudgetHistogram.Name = "BudgetHistogram";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Общий бюджет";
            series4.Name = "бел.руб";
            this.BudgetHistogram.Series.Add(series4);
            this.BudgetHistogram.Size = new System.Drawing.Size(300, 171);
            this.BudgetHistogram.TabIndex = 5;
            this.BudgetHistogram.Text = "chart2";
            this.BudgetHistogram.Visible = false;
            this.BudgetHistogram.Click += new System.EventHandler(this.BudgetHistogram_Click);
            // 
            // HistogramText
            // 
            this.HistogramText.AutoSize = true;
            this.HistogramText.Location = new System.Drawing.Point(583, 151);
            this.HistogramText.Name = "HistogramText";
            this.HistogramText.Size = new System.Drawing.Size(185, 13);
            this.HistogramText.TabIndex = 6;
            this.HistogramText.Text = "Гистограмма изменения бюджета ";
            this.HistogramText.Visible = false;
            // 
            // GraphText
            // 
            this.GraphText.AutoSize = true;
            this.GraphText.Location = new System.Drawing.Point(570, 344);
            this.GraphText.Name = "GraphText";
            this.GraphText.Size = new System.Drawing.Size(155, 13);
            this.GraphText.TabIndex = 7;
            this.GraphText.Text = "График изменения бюджета ";
            this.GraphText.Visible = false;
            this.GraphText.Click += new System.EventHandler(this.label4_Click);
            // 
            // InputDataButton
            // 
            this.InputDataButton.Location = new System.Drawing.Point(140, 521);
            this.InputDataButton.Name = "InputDataButton";
            this.InputDataButton.Size = new System.Drawing.Size(75, 23);
            this.InputDataButton.TabIndex = 8;
            this.InputDataButton.Text = "Ввод";
            this.InputDataButton.UseVisualStyleBackColor = true;
            this.InputDataButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoaderSalary
            // 
            this.LoaderSalary.Location = new System.Drawing.Point(42, 221);
            this.LoaderSalary.Name = "LoaderSalary";
            this.LoaderSalary.Size = new System.Drawing.Size(100, 20);
            this.LoaderSalary.TabIndex = 9;
            this.LoaderSalary.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PurchaserSalary
            // 
            this.PurchaserSalary.Location = new System.Drawing.Point(42, 284);
            this.PurchaserSalary.Name = "PurchaserSalary";
            this.PurchaserSalary.Size = new System.Drawing.Size(100, 20);
            this.PurchaserSalary.TabIndex = 10;
            // 
            // NumOfLoaders
            // 
            this.NumOfLoaders.Location = new System.Drawing.Point(214, 221);
            this.NumOfLoaders.Name = "NumOfLoaders";
            this.NumOfLoaders.Size = new System.Drawing.Size(100, 20);
            this.NumOfLoaders.TabIndex = 11;
            // 
            // NumOfPurchasers
            // 
            this.NumOfPurchasers.Location = new System.Drawing.Point(214, 284);
            this.NumOfPurchasers.Name = "NumOfPurchasers";
            this.NumOfPurchasers.Size = new System.Drawing.Size(100, 20);
            this.NumOfPurchasers.TabIndex = 12;
            // 
            // SellerSalary
            // 
            this.SellerSalary.Location = new System.Drawing.Point(42, 344);
            this.SellerSalary.Name = "SellerSalary";
            this.SellerSalary.Size = new System.Drawing.Size(100, 20);
            this.SellerSalary.TabIndex = 13;
            // 
            // NumOfSellers
            // 
            this.NumOfSellers.Location = new System.Drawing.Point(214, 344);
            this.NumOfSellers.Name = "NumOfSellers";
            this.NumOfSellers.Size = new System.Drawing.Size(100, 20);
            this.NumOfSellers.TabIndex = 14;
            // 
            // AccountantSalary
            // 
            this.AccountantSalary.Location = new System.Drawing.Point(42, 409);
            this.AccountantSalary.Name = "AccountantSalary";
            this.AccountantSalary.Size = new System.Drawing.Size(100, 20);
            this.AccountantSalary.TabIndex = 15;
            // 
            // NumOfAccountants
            // 
            this.NumOfAccountants.Location = new System.Drawing.Point(214, 409);
            this.NumOfAccountants.Name = "NumOfAccountants";
            this.NumOfAccountants.Size = new System.Drawing.Size(100, 20);
            this.NumOfAccountants.TabIndex = 16;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.Location = new System.Drawing.Point(42, 475);
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.PurchasePrice.TabIndex = 17;
            // 
            // SalePrice
            // 
            this.SalePrice.Location = new System.Drawing.Point(214, 475);
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Size = new System.Drawing.Size(100, 20);
            this.SalePrice.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Зарплата грузчика в месяц";
            // 
            // RentalFee
            // 
            this.RentalFee.Location = new System.Drawing.Point(42, 151);
            this.RentalFee.Name = "RentalFee";
            this.RentalFee.Size = new System.Drawing.Size(100, 20);
            this.RentalFee.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Арендная плата в месяц";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Зарплата закупщика в месяц";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Зарплата продавца в месяц";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Зарплата бухгалтера в месяц";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Количество грузчиков";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Количество закупщиков";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Количество  продавцов";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(204, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Количество бухгалтеров";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 444);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Цена покупки товара";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(204, 444);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Цена продажи товара";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(390, 444);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Количество товаров";
            // 
            // NumOfGoods
            // 
            this.NumOfGoods.Location = new System.Drawing.Point(393, 475);
            this.NumOfGoods.Name = "NumOfGoods";
            this.NumOfGoods.Size = new System.Drawing.Size(100, 20);
            this.NumOfGoods.TabIndex = 32;
            // 
            // CurrentBudget
            // 
            this.CurrentBudget.Location = new System.Drawing.Point(359, 151);
            this.CurrentBudget.Name = "CurrentBudget";
            this.CurrentBudget.Size = new System.Drawing.Size(100, 20);
            this.CurrentBudget.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(365, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Текущий бюджет";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // PercentTax
            // 
            this.PercentTax.Location = new System.Drawing.Point(214, 151);
            this.PercentTax.Name = "PercentTax";
            this.PercentTax.Size = new System.Drawing.Size(100, 20);
            this.PercentTax.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(212, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Налог в процентах";
            // 
            // IncomeAndCostsTable
            // 
            this.IncomeAndCostsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeAndCostsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOfMonth,
            this.Budget,
            this.Benefit,
            this.Income,
            this.Costs});
            this.IncomeAndCostsTable.Location = new System.Drawing.Point(890, 201);
            this.IncomeAndCostsTable.Name = "IncomeAndCostsTable";
            this.IncomeAndCostsTable.Size = new System.Drawing.Size(337, 150);
            this.IncomeAndCostsTable.TabIndex = 37;
            this.IncomeAndCostsTable.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(793, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Месячная прибыль";
            // 
            // MonthProfit
            // 
            this.MonthProfit.Location = new System.Drawing.Point(796, 84);
            this.MonthProfit.Name = "MonthProfit";
            this.MonthProfit.ReadOnly = true;
            this.MonthProfit.Size = new System.Drawing.Size(100, 20);
            this.MonthProfit.TabIndex = 39;
            // 
            // ClearInputData
            // 
            this.ClearInputData.Location = new System.Drawing.Point(301, 521);
            this.ClearInputData.Name = "ClearInputData";
            this.ClearInputData.Size = new System.Drawing.Size(192, 23);
            this.ClearInputData.TabIndex = 42;
            this.ClearInputData.Text = "Очистить входные  данные";
            this.ClearInputData.UseVisualStyleBackColor = true;
            this.ClearInputData.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(369, 231);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 43;
            // 
            // DrawGraphics
            // 
            this.DrawGraphics.Location = new System.Drawing.Point(610, 120);
            this.DrawGraphics.Name = "DrawGraphics";
            this.DrawGraphics.Size = new System.Drawing.Size(254, 23);
            this.DrawGraphics.TabIndex = 44;
            this.DrawGraphics.Text = "Нарисовать гистограмму, график и таблицу";
            this.DrawGraphics.UseVisualStyleBackColor = true;
            this.DrawGraphics.Click += new System.EventHandler(this.DrawGraphics_Click);
            // 
            // DeleteAllData
            // 
            this.DeleteAllData.Location = new System.Drawing.Point(61, 21);
            this.DeleteAllData.Name = "DeleteAllData";
            this.DeleteAllData.Size = new System.Drawing.Size(172, 23);
            this.DeleteAllData.TabIndex = 45;
            this.DeleteAllData.Text = "Удалить все данные из файла";
            this.DeleteAllData.UseVisualStyleBackColor = true;
            this.DeleteAllData.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteDataByDate
            // 
            this.DeleteDataByDate.Location = new System.Drawing.Point(293, 21);
            this.DeleteDataByDate.Name = "DeleteDataByDate";
            this.DeleteDataByDate.Size = new System.Drawing.Size(200, 23);
            this.DeleteDataByDate.TabIndex = 46;
            this.DeleteDataByDate.Text = "Удаление записи из файла по дате";
            this.DeleteDataByDate.UseVisualStyleBackColor = true;
            this.DeleteDataByDate.Click += new System.EventHandler(this.DeleteDataByDate_Click);
            // 
            // DataToDelete
            // 
            this.DataToDelete.Location = new System.Drawing.Point(349, 84);
            this.DataToDelete.Name = "DataToDelete";
            this.DataToDelete.Size = new System.Drawing.Size(100, 20);
            this.DataToDelete.TabIndex = 47;
            // 
            // InputDateText
            // 
            this.InputDateText.AutoSize = true;
            this.InputDateText.Location = new System.Drawing.Point(390, 209);
            this.InputDateText.Name = "InputDateText";
            this.InputDateText.Size = new System.Drawing.Size(139, 13);
            this.InputDateText.TabIndex = 48;
            this.InputDateText.Text = "Выберите начальную дату";
            // 
            // DataForDelete
            // 
            this.DataForDelete.AutoSize = true;
            this.DataForDelete.Location = new System.Drawing.Point(328, 59);
            this.DataForDelete.Name = "DataForDelete";
            this.DataForDelete.Size = new System.Drawing.Size(145, 13);
            this.DataForDelete.TabIndex = 49;
            this.DataForDelete.Text = "Введите дату для удаления";
            // 
            // TableText
            // 
            this.TableText.AutoSize = true;
            this.TableText.Location = new System.Drawing.Point(962, 158);
            this.TableText.Name = "TableText";
            this.TableText.Size = new System.Drawing.Size(160, 13);
            this.TableText.TabIndex = 50;
            this.TableText.Text = "Таблица изменения бюджета ";
            this.TableText.Visible = false;
            // 
            // NumOfMonth
            // 
            this.NumOfMonth.HeaderText = "Дата";
            this.NumOfMonth.Name = "NumOfMonth";
            this.NumOfMonth.ReadOnly = true;
            // 
            // Budget
            // 
            this.Budget.HeaderText = "Бюджет";
            this.Budget.Name = "Budget";
            // 
            // Benefit
            // 
            this.Benefit.HeaderText = "Прибыль";
            this.Benefit.Name = "Benefit";
            // 
            // Income
            // 
            this.Income.HeaderText = "Доходы";
            this.Income.Name = "Income";
            this.Income.ReadOnly = true;
            // 
            // Costs
            // 
            this.Costs.HeaderText = "Расходы";
            this.Costs.Name = "Costs";
            this.Costs.ReadOnly = true;
            // 
            // StopProgramButton
            // 
            this.StopProgramButton.Location = new System.Drawing.Point(79, 59);
            this.StopProgramButton.Name = "StopProgramButton";
            this.StopProgramButton.Size = new System.Drawing.Size(136, 23);
            this.StopProgramButton.TabIndex = 51;
            this.StopProgramButton.Text = "Выйти из программы";
            this.StopProgramButton.UseVisualStyleBackColor = true;
            this.StopProgramButton.Click += new System.EventHandler(this.StopProgramButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 588);
            this.Controls.Add(this.StopProgramButton);
            this.Controls.Add(this.TableText);
            this.Controls.Add(this.DataForDelete);
            this.Controls.Add(this.InputDateText);
            this.Controls.Add(this.DataToDelete);
            this.Controls.Add(this.DeleteDataByDate);
            this.Controls.Add(this.DeleteAllData);
            this.Controls.Add(this.DrawGraphics);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ClearInputData);
            this.Controls.Add(this.MonthProfit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.IncomeAndCostsTable);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.PercentTax);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CurrentBudget);
            this.Controls.Add(this.NumOfGoods);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RentalFee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SalePrice);
            this.Controls.Add(this.PurchasePrice);
            this.Controls.Add(this.NumOfAccountants);
            this.Controls.Add(this.AccountantSalary);
            this.Controls.Add(this.NumOfSellers);
            this.Controls.Add(this.SellerSalary);
            this.Controls.Add(this.NumOfPurchasers);
            this.Controls.Add(this.NumOfLoaders);
            this.Controls.Add(this.PurchaserSalary);
            this.Controls.Add(this.LoaderSalary);
            this.Controls.Add(this.InputDataButton);
            this.Controls.Add(this.GraphText);
            this.Controls.Add(this.HistogramText);
            this.Controls.Add(this.BudgetHistogram);
            this.Controls.Add(this.BudgetGraph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MonthCosts);
            this.Controls.Add(this.MonthIncome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BudgetGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeAndCostsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MonthIncome;
        private System.Windows.Forms.TextBox MonthCosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart BudgetGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart BudgetHistogram;
        private System.Windows.Forms.Label HistogramText;
        private System.Windows.Forms.Label GraphText;
        private System.Windows.Forms.Button InputDataButton;
        private System.Windows.Forms.TextBox LoaderSalary;
        private System.Windows.Forms.TextBox PurchaserSalary;
        private System.Windows.Forms.TextBox NumOfLoaders;
        private System.Windows.Forms.TextBox NumOfPurchasers;
        private System.Windows.Forms.TextBox SellerSalary;
        private System.Windows.Forms.TextBox NumOfSellers;
        private System.Windows.Forms.TextBox AccountantSalary;
        private System.Windows.Forms.TextBox NumOfAccountants;
        private System.Windows.Forms.TextBox PurchasePrice;
        private System.Windows.Forms.TextBox SalePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RentalFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox NumOfGoods;
        private System.Windows.Forms.TextBox CurrentBudget;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PercentTax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView IncomeAndCostsTable;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox MonthProfit;
        private System.Windows.Forms.Button ClearInputData;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button DrawGraphics;
        private System.Windows.Forms.Button DeleteAllData;
        private System.Windows.Forms.Button DeleteDataByDate;
        private System.Windows.Forms.TextBox DataToDelete;
        private System.Windows.Forms.Label InputDateText;
        private System.Windows.Forms.Label DataForDelete;
        private System.Windows.Forms.Label TableText;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benefit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costs;
        private System.Windows.Forms.Button StopProgramButton;
    }
}

