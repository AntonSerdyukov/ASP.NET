namespace FinalProjectWindowsForms
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeSurname = new System.Windows.Forms.TextBox();
            this.Profession = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputEmployeeButton = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.PlannedSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeName
            // 
            this.EmployeeName.Location = new System.Drawing.Point(120, 121);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(100, 20);
            this.EmployeeName.TabIndex = 0;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Location = new System.Drawing.Point(263, 121);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.Size = new System.Drawing.Size(100, 20);
            this.EmployeeSurname.TabIndex = 1;
            this.EmployeeSurname.Text = " ";
            // 
            // Profession
            // 
            this.Profession.FormattingEnabled = true;
            this.Profession.Items.AddRange(new object[] {
            "Бухгалтер",
            "Продавец",
            "Закупщик",
            "Грузчик"});
            this.Profession.Location = new System.Drawing.Point(406, 120);
            this.Profession.Name = "Profession";
            this.Profession.Size = new System.Drawing.Size(90, 21);
            this.Profession.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Профессия";
            // 
            // InputEmployeeButton
            // 
            this.InputEmployeeButton.Location = new System.Drawing.Point(250, 210);
            this.InputEmployeeButton.Name = "InputEmployeeButton";
            this.InputEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.InputEmployeeButton.TabIndex = 6;
            this.InputEmployeeButton.Text = "Ввод";
            this.InputEmployeeButton.UseVisualStyleBackColor = true;
            this.InputEmployeeButton.Click += new System.EventHandler(this.InputEmployeeButton_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(363, 214);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(75, 23);
            this.CloseForm.TabIndex = 7;
            this.CloseForm.Text = "Закрыть";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // PlannedSalary
            // 
            this.PlannedSalary.Location = new System.Drawing.Point(577, 120);
            this.PlannedSalary.Name = "PlannedSalary";
            this.PlannedSalary.Size = new System.Drawing.Size(100, 20);
            this.PlannedSalary.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Плановая зарплата";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlannedSalary);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.InputEmployeeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Profession);
            this.Controls.Add(this.EmployeeSurname);
            this.Controls.Add(this.EmployeeName);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox EmployeeSurname;
        private System.Windows.Forms.ComboBox Profession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InputEmployeeButton;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.TextBox PlannedSalary;
        private System.Windows.Forms.Label label4;
    }
}