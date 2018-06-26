namespace Assignment2
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnMultiple = new System.Windows.Forms.Button();
            this.Btn1ByX = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnMean = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.LabelEqu = new System.Windows.Forms.TextBox();
            this.ViewHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.AcceptsReturn = true;
            this.NumberTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.NumberTextBox.Enabled = false;
            this.NumberTextBox.Location = new System.Drawing.Point(13, 17);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(224, 20);
            this.NumberTextBox.TabIndex = 0;
            this.NumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BackBtn
            // 
            this.BackBtn.ForeColor = System.Drawing.Color.Red;
            this.BackBtn.Location = new System.Drawing.Point(13, 44);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(76, 32);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.ForeColor = System.Drawing.Color.Red;
            this.ClearBtn.Location = new System.Drawing.Point(95, 44);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(96, 32);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn7.Location = new System.Drawing.Point(13, 82);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(40, 41);
            this.Btn7.TabIndex = 3;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn8.Location = new System.Drawing.Point(59, 82);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(40, 41);
            this.Btn8.TabIndex = 4;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn9.Location = new System.Drawing.Point(105, 82);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(40, 41);
            this.Btn9.TabIndex = 5;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivision.ForeColor = System.Drawing.Color.Red;
            this.BtnDivision.Location = new System.Drawing.Point(151, 82);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(40, 41);
            this.BtnDivision.TabIndex = 6;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSqrt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSqrt.Location = new System.Drawing.Point(197, 82);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(40, 41);
            this.BtnSqrt.TabIndex = 7;
            this.BtnSqrt.Text = "sqrt";
            this.BtnSqrt.UseVisualStyleBackColor = true;
            this.BtnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn4.Location = new System.Drawing.Point(12, 129);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(40, 41);
            this.Btn4.TabIndex = 8;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn5.Location = new System.Drawing.Point(59, 129);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(40, 41);
            this.Btn5.TabIndex = 9;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn6.Location = new System.Drawing.Point(105, 129);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(40, 41);
            this.Btn6.TabIndex = 10;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // BtnMultiple
            // 
            this.BtnMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiple.ForeColor = System.Drawing.Color.Red;
            this.BtnMultiple.Location = new System.Drawing.Point(151, 129);
            this.BtnMultiple.Name = "BtnMultiple";
            this.BtnMultiple.Size = new System.Drawing.Size(40, 41);
            this.BtnMultiple.TabIndex = 11;
            this.BtnMultiple.Text = "*";
            this.BtnMultiple.UseVisualStyleBackColor = true;
            this.BtnMultiple.Click += new System.EventHandler(this.BtnMultiple_Click);
            // 
            // Btn1ByX
            // 
            this.Btn1ByX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1ByX.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn1ByX.Location = new System.Drawing.Point(197, 129);
            this.Btn1ByX.Name = "Btn1ByX";
            this.Btn1ByX.Size = new System.Drawing.Size(40, 41);
            this.Btn1ByX.TabIndex = 12;
            this.Btn1ByX.Text = "1/X";
            this.Btn1ByX.UseVisualStyleBackColor = true;
            this.Btn1ByX.Click += new System.EventHandler(this.Btn1ByX_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn1.Location = new System.Drawing.Point(13, 176);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(40, 41);
            this.Btn1.TabIndex = 13;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn2.Location = new System.Drawing.Point(59, 176);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(40, 41);
            this.Btn2.TabIndex = 14;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn3.Location = new System.Drawing.Point(105, 176);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(40, 41);
            this.Btn3.TabIndex = 15;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.ForeColor = System.Drawing.Color.Red;
            this.BtnMinus.Location = new System.Drawing.Point(151, 176);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(40, 41);
            this.BtnMinus.TabIndex = 16;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btn0.Location = new System.Drawing.Point(13, 223);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(40, 41);
            this.Btn0.TabIndex = 17;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnMean
            // 
            this.BtnMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMean.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnMean.Location = new System.Drawing.Point(59, 222);
            this.BtnMean.Name = "BtnMean";
            this.BtnMean.Size = new System.Drawing.Size(40, 41);
            this.BtnMean.TabIndex = 18;
            this.BtnMean.Text = "+/-";
            this.BtnMean.UseVisualStyleBackColor = true;
            this.BtnMean.Click += new System.EventHandler(this.BtnMean_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPoint.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnPoint.Location = new System.Drawing.Point(105, 222);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(40, 41);
            this.BtnPoint.TabIndex = 19;
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.ForeColor = System.Drawing.Color.Red;
            this.BtnPlus.Location = new System.Drawing.Point(151, 223);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(40, 41);
            this.BtnPlus.TabIndex = 20;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.ForeColor = System.Drawing.Color.Red;
            this.BtnEquals.Location = new System.Drawing.Point(197, 176);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(40, 87);
            this.BtnEquals.TabIndex = 1;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.ForeColor = System.Drawing.Color.Red;
            this.BtnCE.Location = new System.Drawing.Point(197, 43);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(40, 32);
            this.BtnCE.TabIndex = 21;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = true;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // LabelEqu
            // 
            this.LabelEqu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LabelEqu.Cursor = System.Windows.Forms.Cursors.No;
            this.LabelEqu.Enabled = false;
            this.LabelEqu.Font = new System.Drawing.Font("Lucida Sans", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEqu.Location = new System.Drawing.Point(149, 4);
            this.LabelEqu.Name = "LabelEqu";
            this.LabelEqu.ReadOnly = true;
            this.LabelEqu.Size = new System.Drawing.Size(86, 10);
            this.LabelEqu.TabIndex = 22;
            this.LabelEqu.TabStop = false;
            this.LabelEqu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ViewHistory
            // 
            this.ViewHistory.AutoSize = true;
            this.ViewHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewHistory.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewHistory.Location = new System.Drawing.Point(12, 2);
            this.ViewHistory.Name = "ViewHistory";
            this.ViewHistory.Size = new System.Drawing.Size(58, 14);
            this.ViewHistory.TabIndex = 23;
            this.ViewHistory.Text = "View History";
            this.ViewHistory.Click += new System.EventHandler(this.ViewHistory_Click);
            // 
            // Calculator
            // 
            this.AcceptButton = this.BtnEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(249, 271);
            this.Controls.Add(this.ViewHistory);
            this.Controls.Add(this.LabelEqu);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.BtnMean);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn1ByX);
            this.Controls.Add(this.BtnMultiple);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button BtnMultiple;
        private System.Windows.Forms.Button Btn1ByX;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnMean;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.TextBox LabelEqu;
        private System.Windows.Forms.Label ViewHistory;
    }
}

