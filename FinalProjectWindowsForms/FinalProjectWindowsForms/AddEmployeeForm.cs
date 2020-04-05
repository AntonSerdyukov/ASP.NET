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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
            Form form = new WorkWithEmployeesForm();
            form.Show();
        }

        private void InputEmployeeButton_Click(object sender, EventArgs e)
        {
            Validator validator = new Validator();

            if (Profession.Text != string.Empty && EmployeeName.Text!=string.Empty && EmployeeSurname.Text!=string.Empty && PlannedSalary.Text != string.Empty && validator.ConvertToDecimalValue(PlannedSalary.Text)!=-1)
            {
                EmployeesFile em = new EmployeesFile();
                EmployeeData employeeData = new EmployeeData(EmployeeName.Text, EmployeeSurname.Text, validator.ConvertToDecimalValue(PlannedSalary.Text), 0, 0, 0, Profession.Text);

                if (em.IsEmployeeExist(employeeData.Name, employeeData.Surname) == false)
                {
                    em.AddData(employeeData);
                    
                }
                else
                {
                    MessageBox.Show("Такой сотрудник уже существует");
                }

                Profession.Text = string.Empty;
                EmployeeName.Clear();
                EmployeeSurname.Clear();
                PlannedSalary.Clear();

            }
            else
            {
                MessageBox.Show("Выбраны не все данные");
            }

        }
    }
}
