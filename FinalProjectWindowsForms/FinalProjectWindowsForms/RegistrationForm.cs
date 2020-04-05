using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectWindowsForms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

            
                   
        
        }

        private void RegistedLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            FileForUsers fileForUsers = new FileForUsers();
            UserData registedUser = new UserData(RegistedLogin.Text, RegistedPassword.Text);

            if (fileForUsers.IsUserExist(RegistedLogin.Text, RegistedPassword.Text))
            {
                MessageBox.Show("Пользователь существует");
            }
            else
            {
                fileForUsers.AddData(registedUser);
                Form ActionForm = new ChooseActionForm();
                ActionForm.Show();
            }


            
        }
    }
}
