using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class StudentList : Form
    {
        public StudentList()
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
            foreach (ComboBox cb in Controls.OfType<ComboBox>())
            {
                cb.BackColor = textboxBg;
                cb.ForeColor = Color.Black;
                cb.FlatStyle = FlatStyle.Flat;
            }
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        void LoadStudents()
        {
            string connectionString = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT u.user_id AS user_id, u.username AS username, s.first_name AS first_name, s.last_name AS last_name FROM Users u JOIN Students s ON u.user_id = s.user_id",
                    con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                StudentListGrid.DataSource = dt;
                if (StudentListGrid.Columns.Contains("username"))
                {
                    StudentListGrid.Columns["username"].HeaderText = "Username";
                    StudentListGrid.Columns["username"].DisplayIndex = 0;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StudentListGrid.SelectedRows.Count > 0)
            {
                int user_id = Convert.ToInt32(StudentListGrid.SelectedRows[0].Cells[0].Value);
                string connectionString = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Students WHERE user_id=@id", con);
                    cmd1.Parameters.AddWithValue("@id", user_id);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("DELETE FROM Users WHERE user_id=@id", con);
                    cmd2.Parameters.AddWithValue("@id", user_id);
                    cmd2.ExecuteNonQuery();
                }
                LoadStudents();
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (StudentListGrid.SelectedRows.Count > 0)
            {
                int user_id = Convert.ToInt32(StudentListGrid.SelectedRows[0].Cells[0].Value);
                UpdateStudent updateForm = new UpdateStudent(user_id);
                updateForm.ShowDialog();
                LoadStudents();
            }
        }
    }
}
