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
    public partial class RemoveEmployeeForm : Form
    {
        public RemoveEmployeeForm()
        {
            InitializeComponent();
        }

        private void RemoveButton1_Click(object sender, EventArgs e)
        {
            EmployeesFile em = new EmployeesFile();
            if (em.IsEmployeeExist(Name.Text, Surname.Text))
            {
                em.RemoveData(Name.Text, Surname.Text);
            }
            else
            {
                MessageBox.Show("Сотрудник не найден");
            }
          
            Name.Clear();
            Surname.Clear();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new WorkWithEmployeesForm();
            form.Show();
        }
    }
}
