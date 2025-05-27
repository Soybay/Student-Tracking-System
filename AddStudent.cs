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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ApplyTheme();
        }

        void ApplyTheme()
        {
            Color primary = Properties.Settings.Default.PrimaryColor;
            Color accent = Properties.Settings.Default.AccentColor;
            Color textboxBg = Properties.Settings.Default.TextboxBackColor;
            BackColor = primary;
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.BackColor = primary;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = textboxBg;
                btn.MouseEnter += (s, e) => btn.BackColor = accent;
                btn.MouseLeave += (s, e) => btn.BackColor = primary;
            }
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                tb.BackColor = textboxBg;
                tb.ForeColor = Color.Black;
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;
            string role = "student";
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
                    SqlCommand cmdStudent = new SqlCommand("INSERT INTO Students(user_id, first_name, last_name) VALUES(@user_id, @first_name, @last_name)", con);
                    cmdStudent.Parameters.AddWithValue("@user_id", user_id);
                    cmdStudent.Parameters.AddWithValue("@first_name", firstName);
                    cmdStudent.Parameters.AddWithValue("@last_name", lastName);
                    cmdStudent.ExecuteNonQuery();
                    MessageBox.Show("Student added successfully.");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Username already exists.");
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
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}
