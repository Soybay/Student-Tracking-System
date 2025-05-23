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
            // TODO: This line of code loads data into the 'studentTrackerDataSet1.Users' table. You can move, or remove it, as needed.
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
