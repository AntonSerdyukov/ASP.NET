namespace FinalProjectWindowsForms
{
    partial class RegistrationForm
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
            this.RegistedLogin = new System.Windows.Forms.TextBox();
            this.RegistedPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistedLogin
            // 
            this.RegistedLogin.Location = new System.Drawing.Point(336, 129);
            this.RegistedLogin.Name = "RegistedLogin";
            this.RegistedLogin.Size = new System.Drawing.Size(100, 20);
            this.RegistedLogin.TabIndex = 0;
            this.RegistedLogin.TextChanged += new System.EventHandler(this.RegistedLogin_TextChanged);
            // 
            // RegistedPassword
            // 
            this.RegistedPassword.Location = new System.Drawing.Point(336, 211);
            this.RegistedPassword.Name = "RegistedPassword";
            this.RegistedPassword.Size = new System.Drawing.Size(100, 20);
            this.RegistedPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(351, 282);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrationButton.TabIndex = 4;
            this.RegistrationButton.Text = "Регистрация";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistedPassword);
            this.Controls.Add(this.RegistedLogin);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegistedLogin;
        private System.Windows.Forms.TextBox RegistedPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegistrationButton;
    }
}