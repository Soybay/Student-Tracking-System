namespace Student_Tracking_System
{
    partial class AddAdminExam
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
            this.UsernameCombo = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTrackerDataSet1 = new Student_Tracking_System.StudentTrackerDataSet1();
            this.usersTableAdapter = new Student_Tracking_System.StudentTrackerDataSet1TableAdapters.UsersTableAdapter();
            this.DateLabel = new System.Windows.Forms.Label();
            this.ExamDate = new System.Windows.Forms.DateTimePicker();
            this.EnglishQLabel = new System.Windows.Forms.Label();
            this.EnglishBox = new System.Windows.Forms.TextBox();
            this.EnglishLabel = new System.Windows.Forms.Label();
            this.ReligionQBox = new System.Windows.Forms.Label();
            this.ReligionBox = new System.Windows.Forms.TextBox();
            this.ReligionLabel = new System.Windows.Forms.Label();
            this.HistoryQLabel = new System.Windows.Forms.Label();
            this.HistoryBox = new System.Windows.Forms.TextBox();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.TurkishQLabel = new System.Windows.Forms.Label();
            this.TurkishBox = new System.Windows.Forms.TextBox();
            this.TurkishLabel = new System.Windows.Forms.Label();
            this.ScienceQLabel = new System.Windows.Forms.Label();
            this.ScienceBox = new System.Windows.Forms.TextBox();
            this.ScienceLabel = new System.Windows.Forms.Label();
            this.MathQLabel = new System.Windows.Forms.Label();
            this.MathBox = new System.Windows.Forms.TextBox();
            this.MathLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SubmitExamButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameCombo
            // 
            this.UsernameCombo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "username", true));
            this.UsernameCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameCombo.FormattingEnabled = true;
            this.UsernameCombo.Location = new System.Drawing.Point(156, 55);
            this.UsernameCombo.Name = "UsernameCombo";
            this.UsernameCombo.Size = new System.Drawing.Size(196, 28);
            this.UsernameCombo.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.studentTrackerDataSet1;
            // 
            // studentTrackerDataSet1
            // 
            this.studentTrackerDataSet1.DataSetName = "StudentTrackerDataSet1";
            this.studentTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DateLabel.Location = new System.Drawing.Point(406, 53);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(64, 25);
            this.DateLabel.TabIndex = 40;
            this.DateLabel.Text = "Date :";
            // 
            // ExamDate
            // 
            this.ExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExamDate.Location = new System.Drawing.Point(487, 53);
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Size = new System.Drawing.Size(200, 30);
            this.ExamDate.TabIndex = 39;
            // 
            // EnglishQLabel
            // 
            this.EnglishQLabel.AutoSize = true;
            this.EnglishQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnglishQLabel.Location = new System.Drawing.Point(656, 295);
            this.EnglishQLabel.Name = "EnglishQLabel";
            this.EnglishQLabel.Size = new System.Drawing.Size(40, 25);
            this.EnglishQLabel.TabIndex = 38;
            this.EnglishQLabel.Text = "/10";
            // 
            // EnglishBox
            // 
            this.EnglishBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnglishBox.Location = new System.Drawing.Point(617, 290);
            this.EnglishBox.Name = "EnglishBox";
            this.EnglishBox.Size = new System.Drawing.Size(33, 30);
            this.EnglishBox.TabIndex = 37;
            // 
            // EnglishLabel
            // 
            this.EnglishLabel.AutoSize = true;
            this.EnglishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EnglishLabel.Location = new System.Drawing.Point(519, 295);
            this.EnglishLabel.Name = "EnglishLabel";
            this.EnglishLabel.Size = new System.Drawing.Size(87, 25);
            this.EnglishLabel.TabIndex = 36;
            this.EnglishLabel.Text = "English :";
            // 
            // ReligionQBox
            // 
            this.ReligionQBox.AutoSize = true;
            this.ReligionQBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReligionQBox.Location = new System.Drawing.Point(656, 222);
            this.ReligionQBox.Name = "ReligionQBox";
            this.ReligionQBox.Size = new System.Drawing.Size(40, 25);
            this.ReligionQBox.TabIndex = 35;
            this.ReligionQBox.Text = "/10";
            // 
            // ReligionBox
            // 
            this.ReligionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReligionBox.Location = new System.Drawing.Point(617, 217);
            this.ReligionBox.Name = "ReligionBox";
            this.ReligionBox.Size = new System.Drawing.Size(33, 30);
            this.ReligionBox.TabIndex = 34;
            // 
            // ReligionLabel
            // 
            this.ReligionLabel.AutoSize = true;
            this.ReligionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReligionLabel.Location = new System.Drawing.Point(514, 222);
            this.ReligionLabel.Name = "ReligionLabel";
            this.ReligionLabel.Size = new System.Drawing.Size(92, 25);
            this.ReligionLabel.TabIndex = 33;
            this.ReligionLabel.Text = "Religion :";
            // 
            // HistoryQLabel
            // 
            this.HistoryQLabel.AutoSize = true;
            this.HistoryQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HistoryQLabel.Location = new System.Drawing.Point(647, 150);
            this.HistoryQLabel.Name = "HistoryQLabel";
            this.HistoryQLabel.Size = new System.Drawing.Size(40, 25);
            this.HistoryQLabel.TabIndex = 32;
            this.HistoryQLabel.Text = "/10";
            // 
            // HistoryBox
            // 
            this.HistoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HistoryBox.Location = new System.Drawing.Point(608, 145);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(33, 30);
            this.HistoryBox.TabIndex = 31;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HistoryLabel.Location = new System.Drawing.Point(514, 150);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(83, 25);
            this.HistoryLabel.TabIndex = 30;
            this.HistoryLabel.Text = "History :";
            // 
            // TurkishQLabel
            // 
            this.TurkishQLabel.AutoSize = true;
            this.TurkishQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurkishQLabel.Location = new System.Drawing.Point(244, 295);
            this.TurkishQLabel.Name = "TurkishQLabel";
            this.TurkishQLabel.Size = new System.Drawing.Size(40, 25);
            this.TurkishQLabel.TabIndex = 29;
            this.TurkishQLabel.Text = "/20";
            // 
            // TurkishBox
            // 
            this.TurkishBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurkishBox.Location = new System.Drawing.Point(205, 290);
            this.TurkishBox.Name = "TurkishBox";
            this.TurkishBox.Size = new System.Drawing.Size(33, 30);
            this.TurkishBox.TabIndex = 28;
            // 
            // TurkishLabel
            // 
            this.TurkishLabel.AutoSize = true;
            this.TurkishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TurkishLabel.Location = new System.Drawing.Point(111, 295);
            this.TurkishLabel.Name = "TurkishLabel";
            this.TurkishLabel.Size = new System.Drawing.Size(88, 25);
            this.TurkishLabel.TabIndex = 27;
            this.TurkishLabel.Text = "Turkish :";
            // 
            // ScienceQLabel
            // 
            this.ScienceQLabel.AutoSize = true;
            this.ScienceQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScienceQLabel.Location = new System.Drawing.Point(244, 222);
            this.ScienceQLabel.Name = "ScienceQLabel";
            this.ScienceQLabel.Size = new System.Drawing.Size(40, 25);
            this.ScienceQLabel.TabIndex = 26;
            this.ScienceQLabel.Text = "/20";
            // 
            // ScienceBox
            // 
            this.ScienceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScienceBox.Location = new System.Drawing.Point(205, 217);
            this.ScienceBox.Name = "ScienceBox";
            this.ScienceBox.Size = new System.Drawing.Size(33, 30);
            this.ScienceBox.TabIndex = 25;
            // 
            // ScienceLabel
            // 
            this.ScienceLabel.AutoSize = true;
            this.ScienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScienceLabel.Location = new System.Drawing.Point(105, 222);
            this.ScienceLabel.Name = "ScienceLabel";
            this.ScienceLabel.Size = new System.Drawing.Size(94, 25);
            this.ScienceLabel.TabIndex = 24;
            this.ScienceLabel.Text = "Science :";
            // 
            // MathQLabel
            // 
            this.MathQLabel.AutoSize = true;
            this.MathQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MathQLabel.Location = new System.Drawing.Point(244, 150);
            this.MathQLabel.Name = "MathQLabel";
            this.MathQLabel.Size = new System.Drawing.Size(40, 25);
            this.MathQLabel.TabIndex = 23;
            this.MathQLabel.Text = "/20";
            // 
            // MathBox
            // 
            this.MathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MathBox.Location = new System.Drawing.Point(205, 145);
            this.MathBox.Name = "MathBox";
            this.MathBox.Size = new System.Drawing.Size(33, 30);
            this.MathBox.TabIndex = 22;
            // 
            // MathLabel
            // 
            this.MathLabel.AutoSize = true;
            this.MathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MathLabel.Location = new System.Drawing.Point(71, 150);
            this.MathLabel.Name = "MathLabel";
            this.MathLabel.Size = new System.Drawing.Size(134, 25);
            this.MathLabel.TabIndex = 21;
            this.MathLabel.Text = "Mathematics :";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UsernameLabel.Location = new System.Drawing.Point(16, 58);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(113, 25);
            this.UsernameLabel.TabIndex = 41;
            this.UsernameLabel.Text = "Username :";
            // 
            // SubmitExamButton
            // 
            this.SubmitExamButton.Location = new System.Drawing.Point(314, 352);
            this.SubmitExamButton.Name = "SubmitExamButton";
            this.SubmitExamButton.Size = new System.Drawing.Size(183, 48);
            this.SubmitExamButton.TabIndex = 42;
            this.SubmitExamButton.Text = "Submit Exam";
            this.SubmitExamButton.UseVisualStyleBackColor = true;
            this.SubmitExamButton.Click += new System.EventHandler(this.SubmitExamButton_Click);
            // 
            // AddAdminExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitExamButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ExamDate);
            this.Controls.Add(this.EnglishQLabel);
            this.Controls.Add(this.EnglishBox);
            this.Controls.Add(this.EnglishLabel);
            this.Controls.Add(this.ReligionQBox);
            this.Controls.Add(this.ReligionBox);
            this.Controls.Add(this.ReligionLabel);
            this.Controls.Add(this.HistoryQLabel);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.TurkishQLabel);
            this.Controls.Add(this.TurkishBox);
            this.Controls.Add(this.TurkishLabel);
            this.Controls.Add(this.ScienceQLabel);
            this.Controls.Add(this.ScienceBox);
            this.Controls.Add(this.ScienceLabel);
            this.Controls.Add(this.MathQLabel);
            this.Controls.Add(this.MathBox);
            this.Controls.Add(this.MathLabel);
            this.Controls.Add(this.UsernameCombo);
            this.Name = "AddAdminExam";
            this.Text = "AddAdminExam";
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UsernameCombo;
        private StudentTrackerDataSet1 studentTrackerDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private StudentTrackerDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker ExamDate;
        private System.Windows.Forms.Label EnglishQLabel;
        private System.Windows.Forms.TextBox EnglishBox;
        private System.Windows.Forms.Label EnglishLabel;
        private System.Windows.Forms.Label ReligionQBox;
        private System.Windows.Forms.TextBox ReligionBox;
        private System.Windows.Forms.Label ReligionLabel;
        private System.Windows.Forms.Label HistoryQLabel;
        private System.Windows.Forms.TextBox HistoryBox;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label TurkishQLabel;
        private System.Windows.Forms.TextBox TurkishBox;
        private System.Windows.Forms.Label TurkishLabel;
        private System.Windows.Forms.Label ScienceQLabel;
        private System.Windows.Forms.TextBox ScienceBox;
        private System.Windows.Forms.Label ScienceLabel;
        private System.Windows.Forms.Label MathQLabel;
        private System.Windows.Forms.TextBox MathBox;
        private System.Windows.Forms.Label MathLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button SubmitExamButton;
    }
}