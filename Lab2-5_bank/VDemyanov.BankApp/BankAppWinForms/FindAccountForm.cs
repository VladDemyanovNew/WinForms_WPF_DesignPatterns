using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDemyanov.BankApp.Domain;
using VDemyanov.BankApp.Persistence;
using VDemyanov.BankApp.Persistence.Enum;

namespace VDemyanov.BankApp.BankAppWinForms
{
    public partial class FindAccountForm : Form
    {
        public FindAccountForm()
        {
            InitializeComponent();
        }

        private void FindAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            AccountsRepository accountsRepository = new AccountsRepository();
            List<Account> results = new List<Account>();
            if (accNumButton.Checked)
            {
                results = accountsRepository.SearchByOptions(SearchOptions.AccountNumber, textBox1.Text);
            }
            else if (fullNameButton.Checked)
            {
                results = accountsRepository.SearchByOptions(SearchOptions.FullName, textBox1.Text);
            }
            else if (regulButton.Checked)
            {
                results = accountsRepository.SearchByOptions(SearchOptions.RegExpr, textBox1.Text);
            }
            else if (accTypeButton.Checked)
            {
                results = accountsRepository.SearchByOptions(SearchOptions.AccountType, textBox1.Text);
            }
            else if (balanceButton.Checked)
            {
                string[] rangeConvert = textBox1.Text.Split('-');
                results = accountsRepository.SearchByOptions(SearchOptions.Balance, "", Convert.ToInt32(rangeConvert[0]), Convert.ToInt32(rangeConvert[1]));
            }

            if (sortCheckbox.Checked)
                results = AccountsRepository.SortByAccountTypeAndOpeningDate(results);

            this.Hide();
            SearchResultsForm searchResultsForm = new SearchResultsForm(results);
            searchResultsForm.Show();
        }
    }
}
