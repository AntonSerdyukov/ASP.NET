namespace FinalProjectWindowsForms
{
    partial class ChooseActionForm
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
            this.WorkWithEmployeesButton = new System.Windows.Forms.Button();
            this.PrognoseButton = new System.Windows.Forms.Button();
            this.OutOfAccountButton = new System.Windows.Forms.Button();
            this.ChooseActionLabel = new System.Windows.Forms.Label();
            this.FinancialAccountingbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkWithEmployeesButton
            // 
            this.WorkWithEmployeesButton.Location = new System.Drawing.Point(335, 161);
            this.WorkWithEmployeesButton.Name = "WorkWithEmployeesButton";
            this.WorkWithEmployeesButton.Size = new System.Drawing.Size(155, 23);
            this.WorkWithEmployeesButton.TabIndex = 0;
            this.WorkWithEmployeesButton.Text = "Работа с сотрудниками";
            this.WorkWithEmployeesButton.UseVisualStyleBackColor = true;
            this.WorkWithEmployeesButton.Click += new System.EventHandler(this.WorkWithEmployeesButton_Click);
            // 
            // PrognoseButton
            // 
            this.PrognoseButton.Location = new System.Drawing.Point(335, 221);
            this.PrognoseButton.Name = "PrognoseButton";
            this.PrognoseButton.Size = new System.Drawing.Size(125, 23);
            this.PrognoseButton.TabIndex = 1;
            this.PrognoseButton.Text = "Прогнозирование";
            this.PrognoseButton.UseVisualStyleBackColor = true;
            this.PrognoseButton.Click += new System.EventHandler(this.PrognoseButton_Click);
            // 
            // OutOfAccountButton
            // 
            this.OutOfAccountButton.Location = new System.Drawing.Point(335, 333);
            this.OutOfAccountButton.Name = "OutOfAccountButton";
            this.OutOfAccountButton.Size = new System.Drawing.Size(125, 41);
            this.OutOfAccountButton.TabIndex = 2;
            this.OutOfAccountButton.Text = "Выход из учетной записи";
            this.OutOfAccountButton.UseVisualStyleBackColor = true;
            // 
            // ChooseActionLabel
            // 
            this.ChooseActionLabel.AutoSize = true;
            this.ChooseActionLabel.Location = new System.Drawing.Point(353, 97);
            this.ChooseActionLabel.Name = "ChooseActionLabel";
            this.ChooseActionLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseActionLabel.TabIndex = 3;
            this.ChooseActionLabel.Text = "Выберите действие";
            // 
            // FinancialAccountingbutton
            // 
            this.FinancialAccountingbutton.Location = new System.Drawing.Point(335, 277);
            this.FinancialAccountingbutton.Name = "FinancialAccountingbutton";
            this.FinancialAccountingbutton.Size = new System.Drawing.Size(125, 23);
            this.FinancialAccountingbutton.TabIndex = 4;
            this.FinancialAccountingbutton.Text = "Финансовый учет";
            this.FinancialAccountingbutton.UseVisualStyleBackColor = true;
            this.FinancialAccountingbutton.Click += new System.EventHandler(this.FinancialAccountingbutton_Click);
            // 
            // ChooseActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FinancialAccountingbutton);
            this.Controls.Add(this.ChooseActionLabel);
            this.Controls.Add(this.OutOfAccountButton);
            this.Controls.Add(this.PrognoseButton);
            this.Controls.Add(this.WorkWithEmployeesButton);
            this.Name = "ChooseActionForm";
            this.Text = "ChooseActionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WorkWithEmployeesButton;
        private System.Windows.Forms.Button PrognoseButton;
        private System.Windows.Forms.Button OutOfAccountButton;
        private System.Windows.Forms.Label ChooseActionLabel;
        private System.Windows.Forms.Button FinancialAccountingbutton;
    }
}