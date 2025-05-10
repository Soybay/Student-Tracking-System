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
            this.ExamHistoryButton.Location = new System.Drawing.Point(471, 150);
            this.ExamHistoryButton.Name = "ExamHistoryButton";
            this.ExamHistoryButton.Size = new System.Drawing.Size(132, 64);
            this.ExamHistoryButton.TabIndex = 4;
            this.ExamHistoryButton.Text = "Exam History";
            this.ExamHistoryButton.UseVisualStyleBackColor = true;
            // 
            // AddExamButton
            // 
            this.AddExamButton.Location = new System.Drawing.Point(165, 150);
            this.AddExamButton.Name = "AddExamButton";
            this.AddExamButton.Size = new System.Drawing.Size(132, 64);
            this.AddExamButton.TabIndex = 3;
            this.AddExamButton.Text = "Add Exam";
            this.AddExamButton.UseVisualStyleBackColor = true;
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
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ExamHistoryButton);
            this.Controls.Add(this.AddExamButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ExamHistoryButton;
        private System.Windows.Forms.Button AddExamButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}