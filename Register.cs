using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RoleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            string role = RoleCombo.SelectedItem.ToString().ToLower();
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;

            string hashedPassword = ComputeSha256Hash(password);

            string connectionString = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmdUser = new SqlCommand("INSERT INTO Users(username, password, role) OUTPUT INSERTED.user_id VALUES(@username, @password, @role)", con);
                cmdUser.Parameters.AddWithValue("@username", username);
                cmdUser.Parameters.AddWithValue("@password", hashedPassword);
                cmdUser.Parameters.AddWithValue("@role", role);

                try
                {
                    int user_id = (int)cmdUser.ExecuteScalar();

                    if (role == "student")
                    {
                        SqlCommand cmdStudent = new SqlCommand("INSERT INTO Students(user_id, first_name, last_name) VALUES(@user_id, @first_name, @last_name)", con);
                        cmdStudent.Parameters.AddWithValue("@user_id", user_id);
                        cmdStudent.Parameters.AddWithValue("@first_name", firstName);
                        cmdStudent.Parameters.AddWithValue("@last_name", lastName);
                        cmdStudent.ExecuteNonQuery();
                    }

                    MessageBox.Show("User registered successfully.");
                    this.Close();

                    Application.OpenForms["Login"].Show();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Username already exists, please choose another.");
                    else
                        MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                    builder.Append(bytes[i].ToString("x2"));
                return builder.ToString();
            }

        }

        private void RegToLogButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
