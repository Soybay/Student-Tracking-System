using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class AddAdminExam : Form
    {
        public AddAdminExam()
        {
            InitializeComponent();
            LoadUsernames();
        }

        void LoadUsernames()
        {
            string cs = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (var con = new SqlConnection(cs))
            using (var da = new SqlDataAdapter("SELECT user_id, username FROM Users WHERE role='student'", con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                UsernameCombo.DisplayMember = "username";
                UsernameCombo.ValueMember = "user_id";
                UsernameCombo.DataSource = dt;
            }
        }

        private void SubmitExamButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(UsernameCombo.SelectedValue);
            DateTime examDate = ExamDate.Value;
            int math = int.Parse(MathBox.Text);
            int science = int.Parse(ScienceBox.Text);
            int turkish = int.Parse(TurkishBox.Text);
            int history = int.Parse(HistoryBox.Text);
            int religion = int.Parse(ReligionBox.Text);
            int english = int.Parse(EnglishBox.Text);

            string cs = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (var con = new SqlConnection(cs))
            {
                con.Open();
                using (var cmdExam = new SqlCommand(
                    "INSERT INTO Exams(exam_date) OUTPUT INSERTED.exam_id VALUES(@date)", con))
                {
                    cmdExam.Parameters.AddWithValue("@date", examDate);
                    int examId = (int)cmdExam.ExecuteScalar();
                    using (var cmdRes = new SqlCommand(
                        "INSERT INTO Results(user_id, exam_id, math_score, science_score, turkish_score, inkilap_score, religion_score, english_score) " +
                        "VALUES(@user, @exam, @math, @science, @turkish, @history, @religion, @english)", con))
                    {
                        cmdRes.Parameters.AddWithValue("@user", userId);
                        cmdRes.Parameters.AddWithValue("@exam", examId);
                        cmdRes.Parameters.AddWithValue("@math", math);
                        cmdRes.Parameters.AddWithValue("@science", science);
                        cmdRes.Parameters.AddWithValue("@turkish", turkish);
                        cmdRes.Parameters.AddWithValue("@history", history);
                        cmdRes.Parameters.AddWithValue("@religion", religion);
                        cmdRes.Parameters.AddWithValue("@english", english);
                        cmdRes.ExecuteNonQuery();
                    }
                }
            }
            Close();
        }
    }
}
