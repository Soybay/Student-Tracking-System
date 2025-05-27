namespace Student_Tracking_System
{
    partial class ExamsList
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
            this.ExamsListGrid = new System.Windows.Forms.DataGridView();
            this.AddExamButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.UsernameCombo = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTrackerDataSet1 = new Student_Tracking_System.StudentTrackerDataSet1();
            this.usersTableAdapter = new Student_Tracking_System.StudentTrackerDataSet1TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ExamsListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExamsListGrid
            // 
            this.ExamsListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamsListGrid.Location = new System.Drawing.Point(0, 130);
            this.ExamsListGrid.Name = "ExamsListGrid";
            this.ExamsListGrid.RowHeadersWidth = 51;
            this.ExamsListGrid.RowTemplate.Height = 24;
            this.ExamsListGrid.Size = new System.Drawing.Size(800, 319);
            this.ExamsListGrid.TabIndex = 0;
            // 
            // AddExamButton
            // 
            this.AddExamButton.Location = new System.Drawing.Point(517, 84);
            this.AddExamButton.Name = "AddExamButton";
            this.AddExamButton.Size = new System.Drawing.Size(113, 40);
            this.AddExamButton.TabIndex = 1;
            this.AddExamButton.Text = "Add Exam";
            this.AddExamButton.UseVisualStyleBackColor = true;
            this.AddExamButton.Click += new System.EventHandler(this.AddExamButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(675, 84);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(113, 40);
            this.PrintButton.TabIndex = 2;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // UsernameCombo
            // 
            this.UsernameCombo.DataSource = this.usersBindingSource;
            this.UsernameCombo.DisplayMember = "username";
            this.UsernameCombo.FormattingEnabled = true;
            this.UsernameCombo.Location = new System.Drawing.Point(671, 46);
            this.UsernameCombo.Name = "UsernameCombo";
            this.UsernameCombo.Size = new System.Drawing.Size(121, 24);
            this.UsernameCombo.TabIndex = 3;
            this.UsernameCombo.ValueMember = "user_id";
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
            // ExamsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsernameCombo);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.AddExamButton);
            this.Controls.Add(this.ExamsListGrid);
            this.Name = "ExamsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExamsList";
            this.Load += new System.EventHandler(this.ExamsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamsListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamsListGrid;
        private System.Windows.Forms.Button AddExamButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ComboBox UsernameCombo;
        private StudentTrackerDataSet1 studentTrackerDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private StudentTrackerDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
    }
}