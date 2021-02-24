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

namespace VDemyanov.BankApp.BankAppWinForms
{
    public partial class SearchResultsForm : Form
    {
        private List<Account> results;
        public SearchResultsForm(List<Account> results)
        {
            InitializeComponent();
            this.results = results;
            foreach (var item in results)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ToString();
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void SerarchResultsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
