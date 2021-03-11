
namespace VDemyanov.BankApp.BankAppWinForms
{
    partial class FindAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindAccountForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFind = new System.Windows.Forms.Button();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sortCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.regulButton = new System.Windows.Forms.RadioButton();
            this.balanceButton = new System.Windows.Forms.RadioButton();
            this.accTypeButton = new System.Windows.Forms.RadioButton();
            this.accNumButton = new System.Windows.Forms.RadioButton();
            this.fullNameButton = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(155, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 535);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonFind);
            this.panel3.Controls.Add(this.backToMenuButton);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 435);
            this.panel3.TabIndex = 1;
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.Location = new System.Drawing.Point(347, 373);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(124, 50);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(67)))), ((int)(((byte)(227)))));
            this.backToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenuButton.ForeColor = System.Drawing.Color.White;
            this.backToMenuButton.Location = new System.Drawing.Point(17, 373);
            this.backToMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(124, 50);
            this.backToMenuButton.TabIndex = 7;
            this.backToMenuButton.Text = "Назад";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(50, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(394, 172);
            this.panel5.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(28, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 129);
            this.textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.sortCheckbox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.regulButton);
            this.panel4.Controls.Add(this.balanceButton);
            this.panel4.Controls.Add(this.accTypeButton);
            this.panel4.Controls.Add(this.accNumButton);
            this.panel4.Controls.Add(this.fullNameButton);
            this.panel4.Location = new System.Drawing.Point(50, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 148);
            this.panel4.TabIndex = 4;
            // 
            // sortCheckbox
            // 
            this.sortCheckbox.AutoSize = true;
            this.sortCheckbox.Location = new System.Drawing.Point(234, 110);
            this.sortCheckbox.Name = "sortCheckbox";
            this.sortCheckbox.Size = new System.Drawing.Size(108, 21);
            this.sortCheckbox.TabIndex = 0;
            this.sortCheckbox.Text = "Сортировка";
            this.sortCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выбор категории";
            // 
            // regulButton
            // 
            this.regulButton.AutoSize = true;
            this.regulButton.Location = new System.Drawing.Point(28, 110);
            this.regulButton.Name = "regulButton";
            this.regulButton.Size = new System.Drawing.Size(174, 21);
            this.regulButton.TabIndex = 4;
            this.regulButton.TabStop = true;
            this.regulButton.Text = "Вхождение подстроки";
            this.regulButton.UseVisualStyleBackColor = true;
            // 
            // balanceButton
            // 
            this.balanceButton.AutoSize = true;
            this.balanceButton.Location = new System.Drawing.Point(234, 83);
            this.balanceButton.Name = "balanceButton";
            this.balanceButton.Size = new System.Drawing.Size(77, 21);
            this.balanceButton.TabIndex = 3;
            this.balanceButton.TabStop = true;
            this.balanceButton.Text = "Баланс";
            this.balanceButton.UseVisualStyleBackColor = true;
            // 
            // accTypeButton
            // 
            this.accTypeButton.AutoSize = true;
            this.accTypeButton.Location = new System.Drawing.Point(234, 56);
            this.accTypeButton.Name = "accTypeButton";
            this.accTypeButton.Size = new System.Drawing.Size(96, 21);
            this.accTypeButton.TabIndex = 2;
            this.accTypeButton.TabStop = true;
            this.accTypeButton.Text = "Тип счёта";
            this.accTypeButton.UseVisualStyleBackColor = true;
            // 
            // accNumButton
            // 
            this.accNumButton.AutoSize = true;
            this.accNumButton.Location = new System.Drawing.Point(28, 56);
            this.accNumButton.Name = "accNumButton";
            this.accNumButton.Size = new System.Drawing.Size(114, 21);
            this.accNumButton.TabIndex = 1;
            this.accNumButton.TabStop = true;
            this.accNumButton.Text = "Номер счёта";
            this.accNumButton.UseVisualStyleBackColor = true;
            // 
            // fullNameButton
            // 
            this.fullNameButton.AutoSize = true;
            this.fullNameButton.Location = new System.Drawing.Point(28, 83);
            this.fullNameButton.Name = "fullNameButton";
            this.fullNameButton.Size = new System.Drawing.Size(63, 21);
            this.fullNameButton.TabIndex = 0;
            this.fullNameButton.TabStop = true;
            this.fullNameButton.Text = "ФИО";
            this.fullNameButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(67)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки поиска";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(21)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(796, 716);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FindAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowAccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindAccountForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton regulButton;
        private System.Windows.Forms.RadioButton balanceButton;
        private System.Windows.Forms.RadioButton accTypeButton;
        private System.Windows.Forms.RadioButton accNumButton;
        private System.Windows.Forms.RadioButton fullNameButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox sortCheckbox;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button backToMenuButton;
    }
}