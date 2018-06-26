﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class ViewHistory : Form
    {
        // Using addHistory Method To Add Items To Our HistoryListBox.
        public string addHistory
        {
            get { return null; }
            set { ViewHistoryListBox.Items.Add(value); }
        }

        public ViewHistory()
        {
            InitializeComponent();
        }

        // Back Button ClickEvent.
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Hiding This Form.
            this.Hide();
        }

        private void HistroyClearBtn_Click(object sender, EventArgs e)
        {
            // Clear All History.
            ViewHistoryListBox.Items.Clear();
        }
    }
}
