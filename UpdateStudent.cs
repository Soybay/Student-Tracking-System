using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class UpdateStudent : Form
    {
        int userId;

        public UpdateStudent(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();
            string firstName = FirstNameBox.Text.Trim();
            string lastName = LastNameBox.Text.Trim();

            string connectionString = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                if (!string.IsNullOrWhiteSpace(username))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET username=@username WHERE user_id=@id", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }

                if (!string.IsNullOrWhiteSpace(password))
                {
                    string hashedPassword = ComputeSha256Hash(password);
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET password=@password WHERE user_id=@id", con);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }

                if (!string.IsNullOrWhiteSpace(firstName))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Students SET first_name=@first WHERE user_id=@id", con);
                    cmd.Parameters.AddWithValue("@first", firstName);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }

                if (!string.IsNullOrWhiteSpace(lastName))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Students SET last_name=@last WHERE user_id=@id", con);
                    cmd.Parameters.AddWithValue("@last", lastName);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Update completed.");
                this.Close();
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
    }
}
