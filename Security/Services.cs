using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Security
{
    public partial class Services : Form
    {
        
        string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\asanx\Desktop\Курсовые\Ногай М\Security\Security\Security.mdf;Integrated Security = True";
        SqlConnection sqlConnection;
        public Services()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(ConnectionString);
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            Services.ActiveForm.Hide();
            Security security = new Security();
            security.ShowDialog();
            Close();
        }

        private void ExecutiveProtectionButton_Click(object sender, EventArgs e)
        {
            Services.ActiveForm.Hide();
            PersonalProtect personalProtect = new PersonalProtect();
            personalProtect.ShowDialog();
            Close();
        }

        private void InternationalProtectionButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            PersonalProtect personalProtect = new PersonalProtect();
            personalProtect.ShowDialog();
            Close();
        }

        private void ObjectSecurityButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            ObjectProtect objectProtect = new ObjectProtect();
            objectProtect.ShowDialog();
            Close();
        }
    }
}
