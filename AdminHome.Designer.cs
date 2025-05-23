namespace Student_Tracking_System
{
    partial class AdminHome
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
            this.components = new System.ComponentModel.Container();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.StudentsButton = new System.Windows.Forms.Button();
            this.ExamsButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.PerformanceGraphicButton = new System.Windows.Forms.Button();
            this.UsernameCombo = new System.Windows.Forms.ComboBox();
            this.studentTrackerDataSet1 = new Student_Tracking_System.StudentTrackerDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Student_Tracking_System.StudentTrackerDataSet1TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WelcomeLabel.Location = new System.Drawing.Point(326, 51);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(95, 25);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // StudentsButton
            // 
            this.StudentsButton.Location = new System.Drawing.Point(169, 133);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(132, 64);
            this.StudentsButton.TabIndex = 1;
            this.StudentsButton.Text = "Students List";
            this.StudentsButton.UseVisualStyleBackColor = true;
            this.StudentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // ExamsButton
            // 
            this.ExamsButton.Location = new System.Drawing.Point(475, 133);
            this.ExamsButton.Name = "ExamsButton";
            this.ExamsButton.Size = new System.Drawing.Size(132, 64);
            this.ExamsButton.TabIndex = 2;
            this.ExamsButton.Text = "Exams List";
            this.ExamsButton.UseVisualStyleBackColor = true;
            this.ExamsButton.Click += new System.EventHandler(this.ExamsButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(653, 383);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(135, 55);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // PerformanceGraphicButton
            // 
            this.PerformanceGraphicButton.Location = new System.Drawing.Point(315, 319);
            this.PerformanceGraphicButton.Name = "PerformanceGraphicButton";
            this.PerformanceGraphicButton.Size = new System.Drawing.Size(132, 64);
            this.PerformanceGraphicButton.TabIndex = 4;
            this.PerformanceGraphicButton.Text = "Performance Graphics";
            this.PerformanceGraphicButton.UseVisualStyleBackColor = true;
            this.PerformanceGraphicButton.Click += new System.EventHandler(this.PerformanceGraphicButton_Click);
            // 
            // UsernameCombo
            // 
            this.UsernameCombo.DataSource = this.usersBindingSource;
            this.UsernameCombo.DisplayMember = "username";
            this.UsernameCombo.FormattingEnabled = true;
            this.UsernameCombo.Location = new System.Drawing.Point(320, 277);
            this.UsernameCombo.Name = "UsernameCombo";
            this.UsernameCombo.Size = new System.Drawing.Size(121, 24);
            this.UsernameCombo.TabIndex = 5;
            this.UsernameCombo.ValueMember = "user_id";
            // 
            // studentTrackerDataSet1
            // 
            this.studentTrackerDataSet1.DataSetName = "StudentTrackerDataSet1";
            this.studentTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.studentTrackerDataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsernameCombo);
            this.Controls.Add(this.PerformanceGraphicButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ExamsButton);
            this.Controls.Add(this.StudentsButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button ExamsButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button PerformanceGraphicButton;
        private System.Windows.Forms.ComboBox UsernameCombo;
        private StudentTrackerDataSet1 studentTrackerDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private StudentTrackerDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
    }
}