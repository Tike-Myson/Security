using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Security
{
    public partial class Security : Form
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

        public Security()
        {
            InitializeComponent();
        }

        private void Security_Load(object sender, EventArgs e)
        {

        }

        private void ContactUsButton_Click(object sender, EventArgs e)
        {
            Security.ActiveForm.Hide();
            About about = new About();
            about.ShowDialog();
            Close();
        }

        private void MainMenuLabel_Click(object sender, EventArgs e)
        {
            Security.ActiveForm.Hide();
            Services services = new Services();
            services.ShowDialog();
            Close();
        }

        private void SubmitRequestButton_Click(object sender, EventArgs e)
        {
            string nameRequest = NameTextBox.Text;
            string surnameRequest = SurnameTextBox.Text;
            string phoneRequest = PhoneTextBox.Text;
            string message = MessageTextBox.Text;

            if (NameTextBox.Text.Length == 0 || SurnameTextBox.Text.Length == 0 || PhoneTextBox.Text.Length == 0)
            {
                var msg = MessageBox.Show("Please, fill all boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                OpenConnection(ConnectionString);
                int result = InsertRequest(connect, nameRequest, surnameRequest, phoneRequest, message);
                CloseConnection();

                if (result == 1)
                {
                    var msg = MessageBox.Show("Data added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NameTextBox.Text = "";
                    SurnameTextBox.Text = "";
                    PhoneTextBox.Text = "";
                    MessageTextBox.Text = "";
                }
                else if (result == 0)
                {
                    var msg = MessageBox.Show("Data don't added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static int InsertRequest(SqlConnection connect, string name, string surname, string phone, string message)
        {
            //SQL OPERATOR
            string sql = string.Format("INSERT INTO Request" + "(name, surname, phone, message) VALUES (@name, @surname, @phone, @message)");
            using (SqlCommand cmd = new SqlCommand(sql, connect))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@message", message);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    return 1;
                } else
                {
                    return 0;
                }
            }
        }
    }
}
