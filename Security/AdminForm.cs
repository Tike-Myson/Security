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
    public partial class AdminForm : Form
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
        public AdminForm()
        {
            InitializeComponent();
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Security security = new Security();
            security.ShowDialog();
            Close();
        }

        private void ShowAutoParkButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Datatable datatable = new Datatable();
            datatable.AdminPanelLabel.Text = "Autopark Table";
            OpenConnection(ConnectionString);
            DataTable table = GetData(connect, "Autopark");
            CloseConnection();
            datatable.dgv.DataSource = table;
            datatable.ShowDialog();
            Close();
        }

        private static DataTable GetData(SqlConnection connect, string tableName)
        {
            DataTable table = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlQuery = "SELECT * FROM " + tableName;
            SqlCommand cmd = new SqlCommand(sqlQuery, connect);
            sqlDataAdapter.SelectCommand = cmd;
            _ = sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            return null;
        }

        private void ShowBodyguardsButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Datatable datatable = new Datatable();
            datatable.AdminPanelLabel.Text = "Bodyguards Table";
            OpenConnection(ConnectionString);
            DataTable table = GetData(connect, "Bodyduards");
            CloseConnection();
            datatable.dgv.DataSource = table;
            datatable.ShowDialog();
            Close();
        }

        private void ShowClientsButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Datatable datatable = new Datatable();
            datatable.AdminPanelLabel.Text = "Clients Table";
            OpenConnection(ConnectionString);
            DataTable table = GetData(connect, "Clients");
            CloseConnection();
            datatable.dgv.DataSource = table;
            datatable.ShowDialog();
            Close();
        }

        private void ShowDirectionButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Datatable datatable = new Datatable();
            datatable.AdminPanelLabel.Text = "Directions Table";
            OpenConnection(ConnectionString);
            DataTable table = GetData(connect, "Direction");
            CloseConnection();
            datatable.dgv.DataSource = table;
            datatable.ShowDialog();
            Close();
        }

        private void ShowObjectsButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Datatable datatable = new Datatable();
            datatable.AdminPanelLabel.Text = "Objects Table";
            OpenConnection(ConnectionString);
            DataTable table = GetData(connect, "Object_Security");
            CloseConnection();
            datatable.dgv.DataSource = table;
            datatable.ShowDialog();
            Close();
        }
    }
}
