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
    public partial class SearchForEmployees : Form
    {
        public SearchForEmployees()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            EmployeesFile em = new EmployeesFile();
            var employees = em.SearchForData(Name.Text, Surname.Text);
        }
    }
}
