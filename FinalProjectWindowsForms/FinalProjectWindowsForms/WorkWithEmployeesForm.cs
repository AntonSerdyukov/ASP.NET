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
    public partial class WorkWithEmployeesForm : Form
    {
        public WorkWithEmployeesForm()
        {
            InitializeComponent();
        }

        private void AddNewEmployeeButton_Click(object sender, EventArgs e)
        {
            Close();
            AddEmployeeForm form = new AddEmployeeForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            RemoveEmployeeForm form = new RemoveEmployeeForm();
            form.Show();
        }

        private void ChangeEmployeeData_Click(object sender, EventArgs e)
        {
            Close();
            EditEmployeeForm form = new EditEmployeeForm();
            form.Show();
        }

        private void SearchForEmployeeButton_Click(object sender, EventArgs e)
        {
            Close();
            SearchForEmployees form = new SearchForEmployees();
            form.Show();
        }

        private void WorkWithEmployeesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
