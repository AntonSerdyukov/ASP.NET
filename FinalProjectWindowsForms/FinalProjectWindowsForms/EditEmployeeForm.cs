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
    public partial class EditEmployeeForm : Form
    {
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EditButton1_Click(object sender, EventArgs e)
        {
            EmployeesFile em = new EmployeesFile();
            Validator validator = new Validator();

            if (NewName.Text != string.Empty && newSurname.Text != string.Empty && NewProfession.Text != string.Empty)
            {
                em.EditEmployeeInformation(Name.Text, Surname.Text, Profession.Text, NewName.Text, newSurname.Text, NewProfession.Text);
            }
            else
            {
                MessageBox.Show("Неверно выбраны данные");
            }

        }
    }
}
