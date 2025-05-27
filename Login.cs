using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ApplyTheme();
        }

        void ApplyTheme()
        {
            var primary = Properties.Settings.Default.PrimaryColor;
            var accent = Properties.Settings.Default.AccentColor;
            var textboxBg = Properties.Settings.Default.TextboxBackColor;
            BackColor = primary;
            foreach (var btn in Controls.OfType<Button>())
            {
                btn.BackColor = primary;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = textboxBg;
                btn.MouseEnter += (s, e) => btn.BackColor = accent;
                btn.MouseLeave += (s, e) => btn.BackColor = primary;
            }
            foreach (var tb in Controls.OfType<TextBox>())
            {
                tb.BackColor = textboxBg;
                tb.ForeColor = Color.Black;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var register = new Register();
            register.Show();
            Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = UsernameBox.Text;
            var password = PasswordBox.Text;
            var hashedPassword = ComputeSha256Hash(password);
            var cs = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (var con = new SqlConnection(cs))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT user_id, role FROM Users WHERE username=@username AND password=@password", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var user_id = Convert.ToInt32(reader["user_id"]);
                    var role = reader["role"].ToString();
                    if (role == "admin")
                        new AdminHome().Show();
                    else
                        new StudentHome(user_id).Show();
                    Hide();
                }
                else
                    MessageBox.Show("Incorrect username or password!");
            }
        }

        public static string ComputeSha256Hash(string rawData)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                var sb = new StringBuilder();
                foreach (var b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
