namespace Assignment2
{
    partial class ViewHistory
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
            this.ViewHistoryListBox = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.HistroyClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewHistoryListBox
            // 
            this.ViewHistoryListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ViewHistoryListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewHistoryListBox.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewHistoryListBox.FormattingEnabled = true;
            this.ViewHistoryListBox.HorizontalScrollbar = true;
            this.ViewHistoryListBox.ItemHeight = 14;
            this.ViewHistoryListBox.Location = new System.Drawing.Point(1, 1);
            this.ViewHistoryListBox.Name = "ViewHistoryListBox";
            this.ViewHistoryListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ViewHistoryListBox.Size = new System.Drawing.Size(166, 182);
            this.ViewHistoryListBox.TabIndex = 0;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 189);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 24);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Back";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // HistroyClearBtn
            // 
            this.HistroyClearBtn.BackColor = System.Drawing.Color.Transparent;
            this.HistroyClearBtn.FlatAppearance.BorderSize = 0;
            this.HistroyClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistroyClearBtn.Location = new System.Drawing.Point(93, 189);
            this.HistroyClearBtn.Name = "HistroyClearBtn";
            this.HistroyClearBtn.Size = new System.Drawing.Size(63, 23);
            this.HistroyClearBtn.TabIndex = 1;
            this.HistroyClearBtn.Text = "Clear All";
            this.HistroyClearBtn.UseVisualStyleBackColor = false;
            this.HistroyClearBtn.Click += new System.EventHandler(this.HistroyClearBtn_Click);
            // 
            // ViewHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 218);
            this.ControlBox = false;
            this.Controls.Add(this.HistroyClearBtn);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ViewHistoryListBox);
            this.Name = "ViewHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ViewHistoryListBox;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button HistroyClearBtn;
    }
}