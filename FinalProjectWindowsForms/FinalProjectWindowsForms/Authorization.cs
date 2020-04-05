using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace FinalProjectWindowsForms
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void InputUserData_Click(object sender, EventArgs e)
        {
            FileForUsers fileForUsers = new FileForUsers();
            if (fileForUsers.IsUserExist(Login.Text, Password.Text) == true)
            {
                Form ActionForm = new ChooseActionForm();
                ActionForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль или логин");
            }
            
            // отображаем Form2
            //   this.Hide(); // скрываем Form1 (this - текущая форма)
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Form RegistForm = new RegistrationForm();
            RegistForm.Show();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
