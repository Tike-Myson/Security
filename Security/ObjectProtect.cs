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
    public partial class ObjectProtect : Form
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
        public ObjectProtect()
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

        private void ObjectProtect_Load(object sender, EventArgs e)
        {

        }

        private void SubmitRequestButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string objectName = ObjectNameTextBox.Text;
            string area = AreaTextBox.Text;
            string priority = PriorityObjectComboBox.Text;
            string address = AddressTextBox.Text;

            if (name.Length == 0 || surname.Length == 0 || objectName.Length == 0 || area.Length == 0 || priority.Length == 0 || address.Length == 0)
            {
                var msg = MessageBox.Show("Please, fill all boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                OpenConnection(ConnectionString);
                int result = InsertRequest(connect, name, surname, objectName, area, priority, address);
                CloseConnection();
                if (result == 0)
                {
                        DialogResult msg = MessageBox.Show("User not found\nDo you want to create this user?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (msg == DialogResult.Yes)
                        {
                            ActiveForm.Hide();
                            PersonalProtect personalProtect = new PersonalProtect();
                            personalProtect.NameTextBox.Text = name;
                            personalProtect.SurnameTextBox.Text = surname;
                            personalProtect.ShowDialog();
                            Close();
                        }
                        else if (msg == DialogResult.No)
                        {
                            ActiveForm.Hide();
                            Security security = new Security();
                            security.ShowDialog();
                            Close();
                        }
                } else
                {
                    var msg = MessageBox.Show("Data added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NameTextBox.Text = "";
                    SurnameTextBox.Text = "";
                    ObjectNameTextBox.Text = "";
                    AreaTextBox.Text = "";
                    PriorityObjectComboBox.Text = "";
                    AddressTextBox.Text = "";
                }
            }
        }

        private static int InsertRequest(SqlConnection connect, string name, string surname, string objectName, string area, string priority, string address)
        {
            int id = GetClientID(connect, name, surname);
            Debug.WriteLine(id);
            if (id == 0)
            {
                return 0;
            } else
            {
                //SQL OPERATOR
                string sql = string.Format("INSERT INTO Object_Security" + "(id_client, name_object, address, area, priority) VALUES (@id_client, @name_object, @address, @area, @priority)");
                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.Parameters.AddWithValue("@id_client", id);
                    cmd.Parameters.AddWithValue("@name_object", objectName);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@area", area);
                    cmd.Parameters.AddWithValue("@priority", priority);
                    
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        private static int GetClientID(SqlConnection connect, string name, string surname)
        {
            int id = 0;
            DataTable table = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlQuery = "SELECT * FROM Clients WHERE name = @name AND surname = @surname";
            SqlCommand cmd = new SqlCommand(sqlQuery, connect);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            sqlDataAdapter.SelectCommand = cmd;
            _ = sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    id = Int32.Parse(row["id_client"].ToString());
                }
            }
            return id;
        }
    }
}
