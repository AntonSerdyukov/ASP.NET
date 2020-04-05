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
    public partial class ChooseActionForm : Form
    {
        public ChooseActionForm()
        {
            InitializeComponent();
        }

        private void PrognoseButton_Click(object sender, EventArgs e)
        {
            Form ActionForm = new PrognoseForm();
            ActionForm.Show();
        }

        private void FinancialAccountingbutton_Click(object sender, EventArgs e)
        {
            Form ActionForm = new FinancialHelperForm();
            ActionForm.Show();
        }

        private void WorkWithEmployeesButton_Click(object sender, EventArgs e)
        {
            Close();
            WorkWithEmployeesForm form = new WorkWithEmployeesForm();
            form.Show();
        }
    }
}
