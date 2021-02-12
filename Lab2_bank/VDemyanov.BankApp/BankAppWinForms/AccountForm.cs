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
using VDemyanov.BankApp.Domain.Persons;
using VDemyanov.BankApp.Persistence;

namespace VDemyanov.BankApp.BankAppWinForms
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            userNameField.Text = Settings.UserNameField;
            userLastNameField.Text = Settings.UserLastNameField;
            userMiddleNameField.Text = Settings.UserMiddleNameField;
            passportDataField.Text = Settings.PassportDataField;

            userNameField.ForeColor = Color.Gray;
            userLastNameField.ForeColor = Color.Gray;
            userMiddleNameField.ForeColor = Color.Gray;
            passportDataField.ForeColor = Color.Gray;
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == Settings.UserNameField)
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }                
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.ForeColor = Color.Gray;
                userNameField.Text = Settings.UserNameField;
            }                
        }

        private void userLastNameField_Enter(object sender, EventArgs e)
        {
            if (userLastNameField.Text == Settings.UserLastNameField)
            {
                userLastNameField.Text = "";
                userLastNameField.ForeColor = Color.Black;
            }
        }

        private void userLastNameField_Leave(object sender, EventArgs e)
        {
            if (userLastNameField.Text == "")
            {
                userLastNameField.ForeColor = Color.Gray;
                userLastNameField.Text = Settings.UserLastNameField;
            }
        }

        private void userMiddleNameField_Enter(object sender, EventArgs e)
        {
            if (userMiddleNameField.Text == Settings.UserMiddleNameField)
            {
                userMiddleNameField.Text = "";
                userMiddleNameField.ForeColor = Color.Black;
            }
        }

        private void userMiddleNameField_Leave(object sender, EventArgs e)
        {
            if (userMiddleNameField.Text == "")
            {
                userMiddleNameField.ForeColor = Color.Gray;
                userMiddleNameField.Text = Settings.UserMiddleNameField;
            }
        }

        private void passportDataField_Enter(object sender, EventArgs e)
        {
            if (passportDataField.Text == Settings.PassportDataField)
            {
                passportDataField.Text = "";
                passportDataField.ForeColor = Color.Black;
            }
        }

        private void passportDataField_Leave(object sender, EventArgs e)
        {
            if (passportDataField.Text == "")
            {
                passportDataField.ForeColor = Color.Gray;
                passportDataField.Text = Settings.PassportDataField;
            }
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            bool InternetBunking = false;
            if (this.InternetBankingButtonYes.Checked)
                InternetBunking = true;
            else if (this.InternetBankingButtonNo.Checked)
                InternetBunking = false;
            
            bool Alert = false;
            if (this.AlertYesButton.Checked)
                Alert = true;
            else if (this.AlertNoButton.Checked)
                Alert = false;

            Account account = new Account(
                "k2120",
                this.AccountTypeButton.Text,
                123,
                DateTime.Now,
                InternetBunking,
                Alert,
                new Owner(
                    "Vlad",
                    "Demyanov",
                    "Ruslanovich",
                    DateTime.Now,
                    "dfgdfg"
                    )
                );
            AccountsRepository accountsRepository = new AccountsRepository();
            accountsRepository.AddAccount(account);
        }
    }
}
