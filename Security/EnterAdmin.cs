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
    public partial class EnterAdmin : Form
    {
        private SqlConnection connect = null;
        string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\asanx\Desktop\Курсовые\Ногай М\Security\Security\Security.mdf;Integrated Security = True";
        public void OpenConnection(string connectionString)
        {
            connect = new SqlConnection(connectionString);
            connect.Open();
        }

        public void CloseConnection()
        {
            connect.Close();
        }
        public EnterAdmin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginField = LoginTextBox.Text;
            String passField = PasswordTextBox.Text;
            byte[] data = System.Text.Encoding.ASCII.GetBytes(passField);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            OpenConnection(ConnectionString);
            int res = AuthAdmin(connect, loginField, hash);
            CloseConnection();

            if (res == 1)
            {
                ActiveForm.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
                Close();
            } else if (res == 0)
            {
                DialogResult msg = MessageBox.Show("Invalid password or login\nPlease, try again or return to the main menu", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (msg == DialogResult.Yes)
                {
                    ActiveForm.Hide();
                    EnterAdmin enterAdmin = new EnterAdmin();
                    enterAdmin.ShowDialog();
                    Close();
                } else if (msg == DialogResult.No)
                {
                    ActiveForm.Hide();
                    Security security = new Security();
                    security.ShowDialog();
                    Close();
                }
            }
        }

        private static int AuthAdmin(SqlConnection connect, string login, string pass)
        {
            DataTable table = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlQuery = "SELECT * FROM Admins WHERE login = @login AND password = @password";
            SqlCommand cmd = new SqlCommand(sqlQuery, connect);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@password", pass);
            sqlDataAdapter.SelectCommand = cmd;
            _ = sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return 1;
            }
            return 0;

        }
    }
}
