namespace Student_Tracking_System
{
    partial class StudentHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ExamHistoryButton = new System.Windows.Forms.Button();
            this.AddExamButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.studentTrackerDataSet1 = new Student_Tracking_System.StudentTrackerDataSet1();
            this.PerformanceGraphicButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WelcomeLabel.Location = new System.Drawing.Point(335, 58);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(95, 25);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // ExamHistoryButton
            // 
            this.ExamHistoryButton.Location = new System.Drawing.Point(315, 150);
            this.ExamHistoryButton.Name = "ExamHistoryButton";
            this.ExamHistoryButton.Size = new System.Drawing.Size(132, 64);
            this.ExamHistoryButton.TabIndex = 4;
            this.ExamHistoryButton.Text = "Exam History";
            this.ExamHistoryButton.UseVisualStyleBackColor = true;
            this.ExamHistoryButton.Click += new System.EventHandler(this.ExamHistoryButton_Click);
            // 
            // AddExamButton
            // 
            this.AddExamButton.Location = new System.Drawing.Point(165, 150);
            this.AddExamButton.Name = "AddExamButton";
            this.AddExamButton.Size = new System.Drawing.Size(132, 64);
            this.AddExamButton.TabIndex = 3;
            this.AddExamButton.Text = "Add Exam";
            this.AddExamButton.UseVisualStyleBackColor = true;
            this.AddExamButton.Click += new System.EventHandler(this.AddExamButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(653, 383);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(135, 55);
            this.LogOutButton.TabIndex = 5;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // studentTrackerDataSet1
            // 
            this.studentTrackerDataSet1.DataSetName = "StudentTrackerDataSet1";
            this.studentTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PerformanceGraphicButton
            // 
            this.PerformanceGraphicButton.Location = new System.Drawing.Point(466, 150);
            this.PerformanceGraphicButton.Name = "PerformanceGraphicButton";
            this.PerformanceGraphicButton.Size = new System.Drawing.Size(132, 64);
            this.PerformanceGraphicButton.TabIndex = 6;
            this.PerformanceGraphicButton.Text = "Performance Graphic";
            this.PerformanceGraphicButton.UseVisualStyleBackColor = true;
            this.PerformanceGraphicButton.Click += new System.EventHandler(this.PerformanceGraphicButton_Click);
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerformanceGraphicButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ExamHistoryButton);
            this.Controls.Add(this.AddExamButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ExamHistoryButton;
        private System.Windows.Forms.Button AddExamButton;
        private System.Windows.Forms.Button LogOutButton;
        private StudentTrackerDataSet1 studentTrackerDataSet1;
        private System.Windows.Forms.Button PerformanceGraphicButton;
    }
}