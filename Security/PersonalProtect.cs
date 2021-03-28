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
    public partial class PersonalProtect : Form
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
        public PersonalProtect()
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

        private void SubmitRequestButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string gender = GenderBox.Text;
            string height = HeightTextBox.Text;
            string weight = WeightTextBox.Text;
            string phone = PhoneTextBox.Text;
            string bloodType = GroupOfBlood.Text;
            string priority = PersonalPriorityComboBox.Text;
            string address = AddressTextBox.Text;

            if (name.Length == 0 || surname.Length == 0 || gender.Length == 0 || height.Length == 0 || weight.Length == 0 || phone.Length == 0 || bloodType.Length == 0 || priority.Length == 0 || address.Length == 0)
            {
                var msg = MessageBox.Show("Please, fill all boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                OpenConnection(ConnectionString);
                int result = InsertRequest(connect, name, surname, gender, height, weight, phone, bloodType, priority, address);
                CloseConnection();
                if (result == 1)
                {
                    var msg = MessageBox.Show("Data added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NameTextBox.Text = "";
                    SurnameTextBox.Text = "";
                    GenderBox.Text = "";
                    HeightTextBox.Text = "";
                    WeightTextBox.Text = "";
                    PhoneTextBox.Text = "";
                    GroupOfBlood.Text = "";
                    PersonalPriorityComboBox.Text = "";
                    AddressTextBox.Text = "";
                }
                else if (result == 0)
                {
                    var msg = MessageBox.Show("Data don't added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static int InsertRequest(SqlConnection connect, string name, string surname, string gender, string height, string weight, string phone, string bloodType, string priority, string address)
        {
            //SQL OPERATOR
            string sql = string.Format("INSERT INTO Clients" + "(name, surname, gender, height, weight, blood_type, priority, address, phone_number) VALUES (@name, @surname, @gender, @height, @weight, @blood_type, @priority, @address, @phone_number)");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@height", height);
                cmd.Parameters.AddWithValue("@weight", weight);
                cmd.Parameters.AddWithValue("@blood_type", bloodType);
                cmd.Parameters.AddWithValue("@priority", priority);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone_number", phone);
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
}
