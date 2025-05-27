using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Tracking_System
{
    public partial class AdminHome : Form
    {
        public AdminHome()
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList();
            studentList.ShowDialog();
        }

        private void ExamsButton_Click(object sender, EventArgs e)
        {
            ExamsList examsList = new ExamsList();
            examsList.ShowDialog();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.studentTrackerDataSet1.Users);
        }

        private void PerformanceGraphicButton_Click(object sender, EventArgs e)
        {
            if (UsernameCombo.SelectedValue != null)
            {
                int userId = Convert.ToInt32(UsernameCombo.SelectedValue);
                PerformanceGraphic chartForm = new PerformanceGraphic(userId);
                chartForm.ShowDialog();
            }
        }
    }
}
