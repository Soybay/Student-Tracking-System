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
    public partial class StudentHome : Form
    {
        int user_id;
        
        public StudentHome(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
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
