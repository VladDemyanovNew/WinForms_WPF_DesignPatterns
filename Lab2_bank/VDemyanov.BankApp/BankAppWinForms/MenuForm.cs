using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VDemyanov.BankApp.BankAppWinForms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void FindAccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindAccountForm findAccountForm = new FindAccountForm();
            findAccountForm.Show();
        }
    }
}
