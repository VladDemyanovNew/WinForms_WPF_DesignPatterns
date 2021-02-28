using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDemyanov.BankApp.BankAppWinForms.Settings;
using VDemyanov.BankApp.Persistence;

namespace VDemyanov.BankApp.BankAppWinForms
{
    public partial class Menu : Form
    {
        public InterfaceSettings InterfaceMode { get; set; }

        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel dateInfoLabel;
        ToolStripLabel objectCountInfoLabel;
        Timer timer;
        public Menu()
        {
            InitializeComponent();
            
            //---begin  строка сотояний
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
            //---end  строка сотояний

            //---begin  загрузка темы
            LaunchInterfaceSettings(
                System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))),
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(51))))),
                System.Drawing.Color.White,
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51))))),
                System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51))))),
                System.Drawing.Color.White
                );
            //---end  загрузка темы
        }

        /// <summary>
        /// Загрузка настроек интерфейса
        /// </summary>
        private void LaunchInterfaceSettings(
            System.Drawing.Color MenuBackColor,
            System.Drawing.Color ButtonBackColor,
            System.Drawing.Color ButtonPanelBackColor,
            System.Drawing.Color FooterBackColor,
            System.Drawing.Color HeaderBackColor,
            System.Drawing.Color ForeColor
            )
        {
            this.InterfaceMode = InterfaceSettings.getInstance(
                MenuBackColor,
                ButtonBackColor,
                ButtonPanelBackColor,
                FooterBackColor,
                HeaderBackColor,
                ForeColor
                );
        }

        /// <summary>
        /// Установка настроек интерфейса
        /// </summary>
        private void InstallInterfaceSettings()
        {
            this.BackColor = InterfaceMode.MenuBackColor;
            this.aboutButton.BackColor = InterfaceMode.ButtonBackColor;
            this.button2.BackColor = InterfaceMode.ButtonBackColor;
            this.button1.BackColor = InterfaceMode.ButtonBackColor;
            this.panel3.BackColor = InterfaceMode.ButtonPanelBackColor;
            this.panel2.BackColor = InterfaceMode.HeaderBackColor;
            this.statusStrip1.BackColor = InterfaceMode.FooterBackColor;
            this.label1.ForeColor = InterfaceMode.ForeColor;
            this.button2.ForeColor = InterfaceMode.ForeColor;
            this.button1.ForeColor = InterfaceMode.ForeColor;
            this.aboutButton.ForeColor = InterfaceMode.ForeColor;
        }

        /// <summary>
        /// Обработчик для события timer.Tick
        /// </summary>
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

        /// <summary>
        /// Установка настроек интерфейса
        /// </summary>
        private void IntallButton_Click(object sender, EventArgs e)
        {
            InstallInterfaceSettings();
        }
    }
}
