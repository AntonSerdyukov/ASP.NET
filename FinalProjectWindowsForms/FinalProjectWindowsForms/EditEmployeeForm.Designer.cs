namespace FinalProjectWindowsForms
{
    partial class EditEmployeeForm
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Profession = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.TextBox();
            this.newSurname = new System.Windows.Forms.TextBox();
            this.NewProfession = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EditButton1 = new System.Windows.Forms.Button();
            this.CloseButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(39, 149);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 0;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(182, 149);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 20);
            this.Surname.TabIndex = 1;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // Profession
            // 
            this.Profession.FormattingEnabled = true;
            this.Profession.Location = new System.Drawing.Point(336, 148);
            this.Profession.Name = "Profession";
            this.Profession.Size = new System.Drawing.Size(121, 21);
            this.Profession.TabIndex = 2;
            this.Profession.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Профессия";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Заменить";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "на";
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(38, 265);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(100, 20);
            this.NewName.TabIndex = 8;
            // 
            // newSurname
            // 
            this.newSurname.Location = new System.Drawing.Point(173, 265);
            this.newSurname.Name = "newSurname";
            this.newSurname.Size = new System.Drawing.Size(100, 20);
            this.newSurname.TabIndex = 9;
            // 
            // NewProfession
            // 
            this.NewProfession.FormattingEnabled = true;
            this.NewProfession.Items.AddRange(new object[] {
            "Бухгалтер",
            "Грузчик",
            "Закупщик",
            "Продавец"});
            this.NewProfession.Location = new System.Drawing.Point(336, 264);
            this.NewProfession.Name = "NewProfession";
            this.NewProfession.Size = new System.Drawing.Size(121, 21);
            this.NewProfession.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Профессия";
            // 
            // EditButton1
            // 
            this.EditButton1.Location = new System.Drawing.Point(207, 343);
            this.EditButton1.Name = "EditButton1";
            this.EditButton1.Size = new System.Drawing.Size(75, 23);
            this.EditButton1.TabIndex = 14;
            this.EditButton1.Text = "Заменить";
            this.EditButton1.UseVisualStyleBackColor = true;
            this.EditButton1.Click += new System.EventHandler(this.EditButton1_Click);
            // 
            // CloseButton1
            // 
            this.CloseButton1.Location = new System.Drawing.Point(336, 343);
            this.CloseButton1.Name = "CloseButton1";
            this.CloseButton1.Size = new System.Drawing.Size(75, 23);
            this.CloseButton1.TabIndex = 15;
            this.CloseButton1.Text = "Закрыть";
            this.CloseButton1.UseVisualStyleBackColor = true;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton1);
            this.Controls.Add(this.EditButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NewProfession);
            this.Controls.Add(this.newSurname);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Profession);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
          //  this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.ComboBox Profession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.TextBox newSurname;
        private System.Windows.Forms.ComboBox NewProfession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EditButton1;
        private System.Windows.Forms.Button CloseButton1;
    }
}