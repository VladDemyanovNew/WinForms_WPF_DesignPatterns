
namespace VDemyanov.BankApp.BankAppWinForms
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.InternetBankingButtonYes = new System.Windows.Forms.RadioButton();
            this.InternetBankingButtonNo = new System.Windows.Forms.RadioButton();
            this.OpeningDateButton = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountTypeButton = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.AlertYesButton = new System.Windows.Forms.RadioButton();
            this.AlertNoButton = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userLastNameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.passportDataField = new System.Windows.Forms.TextBox();
            this.userMiddleNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BirthdayButton = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(151, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 535);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 435);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.backToMenuButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CreateAccountButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 375);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(489, 60);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(67)))), ((int)(((byte)(227)))));
            this.backToMenuButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenuButton.ForeColor = System.Drawing.Color.White;
            this.backToMenuButton.Location = new System.Drawing.Point(3, 3);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(238, 54);
            this.backToMenuButton.TabIndex = 0;
            this.backToMenuButton.Text = "назад";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(67)))), ((int)(((byte)(227)))));
            this.CreateAccountButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAccountButton.ForeColor = System.Drawing.Color.White;
            this.CreateAccountButton.Location = new System.Drawing.Point(247, 3);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(239, 54);
            this.CreateAccountButton.TabIndex = 1;
            this.CreateAccountButton.Text = "создать";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(489, 208);
            this.panel5.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(233)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.OpeningDateButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.AccountTypeButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(489, 208);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.InternetBankingButtonYes, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.InternetBankingButtonNo, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(247, 159);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(239, 46);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // InternetBankingButtonYes
            // 
            this.InternetBankingButtonYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InternetBankingButtonYes.AutoSize = true;
            this.InternetBankingButtonYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InternetBankingButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InternetBankingButtonYes.Location = new System.Drawing.Point(33, 11);
            this.InternetBankingButtonYes.Name = "InternetBankingButtonYes";
            this.InternetBankingButtonYes.Size = new System.Drawing.Size(53, 24);
            this.InternetBankingButtonYes.TabIndex = 9;
            this.InternetBankingButtonYes.TabStop = true;
            this.InternetBankingButtonYes.Text = "Да";
            this.InternetBankingButtonYes.UseVisualStyleBackColor = true;
            // 
            // InternetBankingButtonNo
            // 
            this.InternetBankingButtonNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InternetBankingButtonNo.AutoSize = true;
            this.InternetBankingButtonNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InternetBankingButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InternetBankingButtonNo.Location = new System.Drawing.Point(147, 11);
            this.InternetBankingButtonNo.Name = "InternetBankingButtonNo";
            this.InternetBankingButtonNo.Size = new System.Drawing.Size(63, 24);
            this.InternetBankingButtonNo.TabIndex = 8;
            this.InternetBankingButtonNo.TabStop = true;
            this.InternetBankingButtonNo.Text = "Нет";
            this.InternetBankingButtonNo.UseVisualStyleBackColor = true;
            // 
            // OpeningDateButton
            // 
            this.OpeningDateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OpeningDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpeningDateButton.Location = new System.Drawing.Point(268, 64);
            this.OpeningDateButton.Name = "OpeningDateButton";
            this.OpeningDateButton.Size = new System.Drawing.Size(196, 27);
            this.OpeningDateButton.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип вклада";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "Дата открытия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 52);
            this.label5.TabIndex = 2;
            this.label5.Text = "СМС оповещение";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 52);
            this.label6.TabIndex = 3;
            this.label6.Text = "Интернет-банкинг";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountTypeButton
            // 
            this.AccountTypeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountTypeButton.FormattingEnabled = true;
            this.AccountTypeButton.Items.AddRange(new object[] {
            "тест1",
            "тест2",
            "тест3",
            "тест4"});
            this.AccountTypeButton.Location = new System.Drawing.Point(268, 12);
            this.AccountTypeButton.Name = "AccountTypeButton";
            this.AccountTypeButton.Size = new System.Drawing.Size(196, 28);
            this.AccountTypeButton.TabIndex = 6;
            this.AccountTypeButton.Text = "тест1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.AlertYesButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.AlertNoButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(247, 107);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(239, 46);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // AlertYesButton
            // 
            this.AlertYesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlertYesButton.AutoSize = true;
            this.AlertYesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlertYesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlertYesButton.Location = new System.Drawing.Point(33, 11);
            this.AlertYesButton.Name = "AlertYesButton";
            this.AlertYesButton.Size = new System.Drawing.Size(53, 24);
            this.AlertYesButton.TabIndex = 9;
            this.AlertYesButton.TabStop = true;
            this.AlertYesButton.Text = "Да";
            this.AlertYesButton.UseVisualStyleBackColor = true;
            // 
            // AlertNoButton
            // 
            this.AlertNoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlertNoButton.AutoSize = true;
            this.AlertNoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlertNoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlertNoButton.Location = new System.Drawing.Point(147, 11);
            this.AlertNoButton.Name = "AlertNoButton";
            this.AlertNoButton.Size = new System.Drawing.Size(63, 24);
            this.AlertNoButton.TabIndex = 8;
            this.AlertNoButton.TabStop = true;
            this.AlertNoButton.Text = "Нет";
            this.AlertNoButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 167);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.userLastNameField, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userNameField, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.passportDataField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.userMiddleNameField, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BirthdayButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userLastNameField
            // 
            this.userLastNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLastNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLastNameField.Location = new System.Drawing.Point(268, 10);
            this.userLastNameField.Multiline = true;
            this.userLastNameField.Name = "userLastNameField";
            this.userLastNameField.Size = new System.Drawing.Size(196, 36);
            this.userLastNameField.TabIndex = 0;
            this.userLastNameField.Enter += new System.EventHandler(this.userLastNameField_Enter);
            this.userLastNameField.Leave += new System.EventHandler(this.userLastNameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.Location = new System.Drawing.Point(18, 10);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(207, 36);
            this.userNameField.TabIndex = 5;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // passportDataField
            // 
            this.passportDataField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passportDataField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportDataField.Location = new System.Drawing.Point(268, 67);
            this.passportDataField.Multiline = true;
            this.passportDataField.Name = "passportDataField";
            this.passportDataField.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.passportDataField.Size = new System.Drawing.Size(196, 36);
            this.passportDataField.TabIndex = 2;
            this.passportDataField.Enter += new System.EventHandler(this.passportDataField_Enter);
            this.passportDataField.Leave += new System.EventHandler(this.passportDataField_Leave);
            // 
            // userMiddleNameField
            // 
            this.userMiddleNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userMiddleNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userMiddleNameField.Location = new System.Drawing.Point(18, 67);
            this.userMiddleNameField.Multiline = true;
            this.userMiddleNameField.Name = "userMiddleNameField";
            this.userMiddleNameField.Size = new System.Drawing.Size(207, 36);
            this.userMiddleNameField.TabIndex = 6;
            this.userMiddleNameField.Enter += new System.EventHandler(this.userMiddleNameField_Enter);
            this.userMiddleNameField.Leave += new System.EventHandler(this.userMiddleNameField_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(238, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата рождения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BirthdayButton
            // 
            this.BirthdayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BirthdayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayButton.Location = new System.Drawing.Point(268, 127);
            this.BirthdayButton.Name = "BirthdayButton";
            this.BirthdayButton.Size = new System.Drawing.Size(196, 27);
            this.BirthdayButton.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(67)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание счёта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(796, 716);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox userMiddleNameField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.TextBox passportDataField;
        private System.Windows.Forms.TextBox userLastNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BirthdayButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AccountTypeButton;
        private System.Windows.Forms.DateTimePicker OpeningDateButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton AlertYesButton;
        private System.Windows.Forms.RadioButton AlertNoButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.RadioButton InternetBankingButtonYes;
        private System.Windows.Forms.RadioButton InternetBankingButtonNo;
    }
}