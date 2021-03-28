using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Security
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            About.ActiveForm.Hide();
            Security security = new Security();
            security.ShowDialog();
            Close();
        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            EnterAdmin enterAdmin = new EnterAdmin();
            enterAdmin.ShowDialog();
            Close();
        }
    }
}
