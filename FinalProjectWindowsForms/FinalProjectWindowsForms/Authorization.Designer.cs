namespace FinalProjectWindowsForms
{
    partial class Authorization
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.InputUserData = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(320, 175);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(320, 261);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            // 
            // InputUserData
            // 
            this.InputUserData.Location = new System.Drawing.Point(320, 317);
            this.InputUserData.Name = "InputUserData";
            this.InputUserData.Size = new System.Drawing.Size(90, 23);
            this.InputUserData.TabIndex = 2;
            this.InputUserData.Text = "Войти";
            this.InputUserData.UseVisualStyleBackColor = true;
            this.InputUserData.Click += new System.EventHandler(this.InputUserData_Click);
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(320, 367);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(90, 23);
            this.Registration.TabIndex = 3;
            this.Registration.Text = "Регистрация";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.InputUserData);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button InputUserData;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}