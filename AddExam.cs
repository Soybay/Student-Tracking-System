using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class AddExam : Form
    {

        int user_id;
        public AddExam(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddExam_Load(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int math = int.Parse(MathBox.Text);
            int science = int.Parse(ScienceBox.Text);
            int turkish = int.Parse(TurkishBox.Text);
            int history = int.Parse(HistoryBox.Text);
            int religion = int.Parse(ReligionBox.Text);
            int english = int.Parse(EnglishBox.Text);
            DateTime examDate = ExamDate.Value;

            string connectionString = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand insertExam = new SqlCommand("INSERT INTO Exams(exam_date) OUTPUT INSERTED.exam_id VALUES(@date)", con);
                insertExam.Parameters.AddWithValue("@date", examDate);
                int examId = (int)insertExam.ExecuteScalar();

                SqlCommand insertResult = new SqlCommand("INSERT INTO Results(user_id, exam_id, math_score, science_score, turkish_score, inkilap_score, religion_score, english_score) " +
                                                         "VALUES(@user, @exam, @math, @science, @turkish, @history, @religion, @english)", con);
                insertResult.Parameters.AddWithValue("@user", user_id);
                insertResult.Parameters.AddWithValue("@exam", examId);
                insertResult.Parameters.AddWithValue("@math", math);
                insertResult.Parameters.AddWithValue("@science", science);
                insertResult.Parameters.AddWithValue("@turkish", turkish);
                insertResult.Parameters.AddWithValue("@history", history);
                insertResult.Parameters.AddWithValue("@religion", religion);
                insertResult.Parameters.AddWithValue("@english", english);
                insertResult.ExecuteNonQuery();

                MessageBox.Show("Exam added successfully.");
                this.Close();
            }
        }

    }
}
