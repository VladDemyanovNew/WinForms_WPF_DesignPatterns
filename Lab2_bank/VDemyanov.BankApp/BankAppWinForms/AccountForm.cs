using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            // подключение репозиторию с данными
            AccountsRepository accountsRepository = new AccountsRepository();

            string accountNumber = (accountsRepository.GetAccountsLength() + 1) + "k";
            string accountType = this.AccountTypeButton.Text;
            DateTime openingDate = this.OpeningDateButton.Value;
            // Owner
            string name = this.userNameField.Text;
            string lastName = this.userLastNameField.Text;
            string middleName = this.userMiddleNameField.Text;
            DateTime birthday = this.BirthdayButton.Value;
            string passportData = this.passportDataField.Text;

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
                accountNumber,
                accountType,
                0,
                openingDate,
                InternetBunking,
                Alert,
                new Owner(
                    name,
                    lastName,
                    middleName,
                    birthday,
                    passportData
                    )
                );

            var results = new List<ValidationResult>();
            var contextAccount = new ValidationContext(account);
            var contextOwner = new ValidationContext(account.owner);

            bool res1 = tryValidateObject(account, contextAccount, results);
            bool res2 = tryValidateObject(account.owner, contextOwner, results);

            if (res1 && res2)
            {
                accountsRepository.AddAccount(account);

                this.Hide();
                SuccessForm successForm = new SuccessForm();
                successForm.Show();
            }     
        }

        private bool tryValidateObject(object obj, ValidationContext validationContext, ICollection<ValidationResult> validationResults)
        {
            if (!Validator.TryValidateObject(obj, validationContext, validationResults, true))
            {
                string warning = validationResults.First().ErrorMessage;
                MessageBox.Show(
                    warning,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return false;
            }
            return true;
        }
    }
}
