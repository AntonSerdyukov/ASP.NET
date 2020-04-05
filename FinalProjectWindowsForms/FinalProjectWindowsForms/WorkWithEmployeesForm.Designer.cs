namespace FinalProjectWindowsForms
{
    partial class WorkWithEmployeesForm
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
            this.AddNewEmployeeButton = new System.Windows.Forms.Button();
            this.ChangeEmployeeData = new System.Windows.Forms.Button();
            this.SearchForEmployeeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewEmployeeButton
            // 
            this.AddNewEmployeeButton.Location = new System.Drawing.Point(331, 59);
            this.AddNewEmployeeButton.Name = "AddNewEmployeeButton";
            this.AddNewEmployeeButton.Size = new System.Drawing.Size(157, 45);
            this.AddNewEmployeeButton.TabIndex = 0;
            this.AddNewEmployeeButton.Text = "Добавление нового сотрудника";
            this.AddNewEmployeeButton.UseVisualStyleBackColor = true;
            this.AddNewEmployeeButton.Click += new System.EventHandler(this.AddNewEmployeeButton_Click);
            // 
            // ChangeEmployeeData
            // 
            this.ChangeEmployeeData.Location = new System.Drawing.Point(322, 203);
            this.ChangeEmployeeData.Name = "ChangeEmployeeData";
            this.ChangeEmployeeData.Size = new System.Drawing.Size(157, 45);
            this.ChangeEmployeeData.TabIndex = 1;
            this.ChangeEmployeeData.Text = "Изменение данных о сотруднике";
            this.ChangeEmployeeData.UseVisualStyleBackColor = true;
            this.ChangeEmployeeData.Click += new System.EventHandler(this.ChangeEmployeeData_Click);
            // 
            // SearchForEmployeeButton
            // 
            this.SearchForEmployeeButton.Location = new System.Drawing.Point(322, 276);
            this.SearchForEmployeeButton.Name = "SearchForEmployeeButton";
            this.SearchForEmployeeButton.Size = new System.Drawing.Size(157, 45);
            this.SearchForEmployeeButton.TabIndex = 2;
            this.SearchForEmployeeButton.Text = "Поиск сотрудника";
            this.SearchForEmployeeButton.UseVisualStyleBackColor = true;
            this.SearchForEmployeeButton.Click += new System.EventHandler(this.SearchForEmployeeButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удаление  сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorkWithEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchForEmployeeButton);
            this.Controls.Add(this.ChangeEmployeeData);
            this.Controls.Add(this.AddNewEmployeeButton);
            this.Name = "WorkWithEmployeesForm";
            this.Text = "WorkWithEmployeesForm";
            this.Load += new System.EventHandler(this.WorkWithEmployeesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewEmployeeButton;
        private System.Windows.Forms.Button ChangeEmployeeData;
        private System.Windows.Forms.Button SearchForEmployeeButton;
        private System.Windows.Forms.Button button1;
    }
}