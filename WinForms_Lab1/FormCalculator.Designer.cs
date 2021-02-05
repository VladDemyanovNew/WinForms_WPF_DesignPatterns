namespace VDemyanov.WinFormsLab1.WinForms
{
    partial class FormCalculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button28 = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.buttonSq = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonDegreeX = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonCtg = new System.Windows.Forms.Button();
            this.buttonTg = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonSqrtX = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Display, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button28, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonSum, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.button24, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.button23, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button22, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonSub, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.button19, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button18, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button17, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonSq, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonMul, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.button14, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button13, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button12, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonDegreeX, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonDiv, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonSqrt, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonCtg, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonTg, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCos, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSin, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSqrtX, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonComma, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonCalculate, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.button8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonC, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonDelete, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 385);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.Location = new System.Drawing.Point(161, 323);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(73, 59);
            this.button28.TabIndex = 27;
            this.button28.Text = "0";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.Button22_Click);
            // 
            // buttonSum
            // 
            this.buttonSum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSum.Location = new System.Drawing.Point(319, 259);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(76, 58);
            this.buttonSum.TabIndex = 24;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = false;
            this.buttonSum.Click += new System.EventHandler(this.ButtonSum_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.Location = new System.Drawing.Point(240, 259);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(73, 58);
            this.button24.TabIndex = 23;
            this.button24.Text = "3";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.Button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.Location = new System.Drawing.Point(161, 259);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(73, 58);
            this.button23.TabIndex = 22;
            this.button23.Text = "2";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.Button22_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.Location = new System.Drawing.Point(82, 259);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(73, 58);
            this.button22.TabIndex = 21;
            this.button22.Text = "1";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Button22_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSub.Location = new System.Drawing.Point(319, 195);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(76, 58);
            this.buttonSub.TabIndex = 19;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.ButtonSub_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(240, 195);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(73, 58);
            this.button19.TabIndex = 18;
            this.button19.Text = "6";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Button22_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(161, 195);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 58);
            this.button18.TabIndex = 17;
            this.button18.Text = "5";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Button22_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(82, 195);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(73, 58);
            this.button17.TabIndex = 16;
            this.button17.Text = "4";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Button22_Click);
            // 
            // buttonSq
            // 
            this.buttonSq.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSq.Location = new System.Drawing.Point(3, 195);
            this.buttonSq.Name = "buttonSq";
            this.buttonSq.Size = new System.Drawing.Size(73, 58);
            this.buttonSq.TabIndex = 15;
            this.buttonSq.Text = "sq";
            this.buttonSq.UseVisualStyleBackColor = false;
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMul.Location = new System.Drawing.Point(319, 131);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(76, 58);
            this.buttonMul.TabIndex = 14;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.ButtonMul_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(240, 131);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 58);
            this.button14.TabIndex = 13;
            this.button14.Text = "9";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Button22_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(161, 131);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 58);
            this.button13.TabIndex = 12;
            this.button13.Text = "8";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Button22_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(82, 131);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(73, 58);
            this.button12.TabIndex = 11;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Button22_Click);
            // 
            // buttonDegreeX
            // 
            this.buttonDegreeX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDegreeX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDegreeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDegreeX.Location = new System.Drawing.Point(3, 131);
            this.buttonDegreeX.Name = "buttonDegreeX";
            this.buttonDegreeX.Size = new System.Drawing.Size(73, 58);
            this.buttonDegreeX.TabIndex = 10;
            this.buttonDegreeX.Text = "degreeX";
            this.buttonDegreeX.UseVisualStyleBackColor = false;
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Location = new System.Drawing.Point(319, 67);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(76, 58);
            this.buttonDiv.TabIndex = 9;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSqrt.Location = new System.Drawing.Point(3, 67);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(73, 58);
            this.buttonSqrt.TabIndex = 5;
            this.buttonSqrt.Text = "sqrt";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            // 
            // buttonCtg
            // 
            this.buttonCtg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCtg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCtg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCtg.Location = new System.Drawing.Point(319, 3);
            this.buttonCtg.Name = "buttonCtg";
            this.buttonCtg.Size = new System.Drawing.Size(76, 58);
            this.buttonCtg.TabIndex = 4;
            this.buttonCtg.Text = "ctg";
            this.buttonCtg.UseVisualStyleBackColor = false;
            this.buttonCtg.Click += new System.EventHandler(this.ButtonCtg_Click);
            // 
            // buttonTg
            // 
            this.buttonTg.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTg.Location = new System.Drawing.Point(240, 3);
            this.buttonTg.Name = "buttonTg";
            this.buttonTg.Size = new System.Drawing.Size(73, 58);
            this.buttonTg.TabIndex = 3;
            this.buttonTg.Text = "tg";
            this.buttonTg.UseVisualStyleBackColor = false;
            this.buttonTg.Click += new System.EventHandler(this.ButtonTg_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCos.Location = new System.Drawing.Point(161, 3);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(73, 58);
            this.buttonCos.TabIndex = 2;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSin.Location = new System.Drawing.Point(82, 3);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(73, 58);
            this.buttonSin.TabIndex = 1;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // buttonSqrtX
            // 
            this.buttonSqrtX.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSqrtX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSqrtX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSqrtX.Location = new System.Drawing.Point(3, 3);
            this.buttonSqrtX.Name = "buttonSqrtX";
            this.buttonSqrtX.Size = new System.Drawing.Size(73, 58);
            this.buttonSqrtX.TabIndex = 0;
            this.buttonSqrtX.Text = "sqrtX";
            this.buttonSqrtX.UseVisualStyleBackColor = false;
            // 
            // buttonComma
            // 
            this.buttonComma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComma.Location = new System.Drawing.Point(82, 323);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(73, 59);
            this.buttonComma.TabIndex = 28;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = false;
            this.buttonComma.Click += new System.EventHandler(this.ButtonComma_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonCalculate, 2);
            this.buttonCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Location = new System.Drawing.Point(240, 323);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(155, 59);
            this.buttonCalculate.TabIndex = 29;
            this.buttonCalculate.Text = "=";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(3, 259);
            this.button8.Name = "button8";
            this.tableLayoutPanel2.SetRowSpan(this.button8, 2);
            this.button8.Size = new System.Drawing.Size(73, 123);
            this.button8.TabIndex = 30;
            this.button8.Text = "MRC";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Location = new System.Drawing.Point(82, 67);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(73, 58);
            this.buttonC.TabIndex = 8;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonDelete, 2);
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(161, 67);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 58);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Display
            // 
            this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Display.BackColor = System.Drawing.Color.LightCyan;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Display.Location = new System.Drawing.Point(3, 3);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Display.Size = new System.Drawing.Size(398, 62);
            this.Display.TabIndex = 0;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button buttonSq;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button buttonDegreeX;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonCtg;
        private System.Windows.Forms.Button buttonTg;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonSqrtX;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonDelete;
    }
}

