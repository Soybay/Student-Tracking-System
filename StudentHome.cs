using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class StudentHome : Form
    {
        int user_id;

        public StudentHome(int user_id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ApplyTheme();
            this.user_id = user_id;
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void AddExamButton_Click(object sender, EventArgs e)
        {
            AddExam addExam = new AddExam(user_id);
            addExam.ShowDialog();
        }

        private void ExamHistoryButton_Click(object sender, EventArgs e)
        {
            ExamHistory historypage = new ExamHistory(user_id);
            historypage.ShowDialog();
        }

        private void PerformanceGraphicButton_Click(object sender, EventArgs e)
        {
            PerformanceGraphic performanceGraphic = new PerformanceGraphic(user_id);
            performanceGraphic.ShowDialog();
        }
    }
}
