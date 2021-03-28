using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Security
{
    public partial class Datatable : Form
    {
        public Datatable()
        {
            InitializeComponent();
        }

        private void BackToAdminFormButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            Close();
        }
    }
}
