using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Student_Tracking_System
{
    public partial class ExamsList : Form
    {
        public ExamsList()
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

        private void ExamsList_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.studentTrackerDataSet1.Users);
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

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (UsernameCombo.SelectedValue == null) return;
            int userId = Convert.ToInt32(UsernameCombo.SelectedValue);
            DataTable dt = new DataTable();
            string cs = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(cs))
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT r.exam_id, e.exam_date, r.math_score, r.science_score, r.turkish_score, r.inkilap_score, r.religion_score, r.english_score " +
                "FROM Results r JOIN Exams e ON r.exam_id = e.exam_id " +
                "WHERE r.user_id = @user_id", con))
            {
                da.SelectCommand.Parameters.AddWithValue("@user_id", userId);
                da.Fill(dt);
            }
            if (dt.Rows.Count == 0) return;
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"{UsernameCombo.Text}_ExamHistory.pdf" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    PdfPTable pdfTable = new PdfPTable(dt.Columns.Count) { WidthPercentage = 100 };
                    foreach (DataColumn col in dt.Columns)
                        pdfTable.AddCell(new Phrase(col.ColumnName));
                    foreach (DataRow row in dt.Rows)
                        foreach (var cell in row.ItemArray)
                            pdfTable.AddCell(new Phrase(cell.ToString()));
                    doc.Add(pdfTable);
                    doc.Close();
                }
            }
        }
    }
}
