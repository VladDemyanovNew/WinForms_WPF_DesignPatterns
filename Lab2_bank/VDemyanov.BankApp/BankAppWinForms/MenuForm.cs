using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDemyanov.BankApp.Persistence;

namespace VDemyanov.BankApp.BankAppWinForms
{
    public partial class Menu : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel dateInfoLabel;
        ToolStripLabel objectCountInfoLabel;
        Timer timer;
        public Menu()
        {
            InitializeComponent();

            dateInfoLabel = new ToolStripLabel();
            dateInfoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();
            objectCountInfoLabel = new ToolStripLabel();

            statusStrip1.Items.Add(dateInfoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);
            statusStrip1.Items.Add(objectCountInfoLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
            Set_ObjectCountInfoLabel();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void Set_ObjectCountInfoLabel()
        {
            AccountsRepository accounts = new AccountsRepository();
            objectCountInfoLabel.Text = "Объектов создано: " + accounts.GetAccountsLength();
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

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            string message = "BankApp v5.0 @VDemyanov";
            MessageBox.Show(
                   message,
                   "О программе",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
