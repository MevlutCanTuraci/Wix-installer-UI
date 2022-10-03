using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WinApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Actions(object sender, EventArgs e)
        {
            if (sender == btnDate)
            {
                MessageBox.Show(monthCalendar1.SelectionRange.Start.ToString());
            }

            else
            {
                this.Text = "Version " + Application.ProductVersion;
            }

        }

    }
}