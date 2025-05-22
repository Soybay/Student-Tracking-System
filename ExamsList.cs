using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class ExamsList : Form
    {
        public ExamsList()
        {
            InitializeComponent();
        }

        private void ExamsList_Load(object sender, EventArgs e)
        {
            LoadExams();
        }

        void LoadExams()
        {
            string cs = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT u.username, r.exam_id, e.exam_date, r.math_score, r.science_score, r.turkish_score, r.inkilap_score, r.religion_score, r.english_score " +
                "FROM Results r " +
                "JOIN Users u ON r.user_id = u.user_id " +
                "JOIN Exams e ON r.exam_id = e.exam_id", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                ExamsListGrid.AutoGenerateColumns = true;
                ExamsListGrid.DataSource = dt;
            }
        }

        private void AddExamButton_Click(object sender, EventArgs e)
        {
            using (var f = new AddAdminExam())
            {
                f.ShowDialog();
                LoadExams();
            }
        }
    }
}