namespace Student_Tracking_System
{
    partial class StudentList
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
            this.StudentListGrid = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTrackerDataSet1 = new Student_Tracking_System.StudentTrackerDataSet1();
            this.studentsTableAdapter = new Student_Tracking_System.StudentTrackerDataSet1TableAdapters.StudentsTableAdapter();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKResultsuserid403A8C7DBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new Student_Tracking_System.StudentTrackerDataSet1TableAdapters.ResultsTableAdapter();
            this.studentTrackerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKResultsuserid403A8C7DBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentListGrid
            // 
            this.StudentListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListGrid.Location = new System.Drawing.Point(2, 166);
            this.StudentListGrid.Name = "StudentListGrid";
            this.StudentListGrid.RowHeadersWidth = 51;
            this.StudentListGrid.RowTemplate.Height = 24;
            this.StudentListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentListGrid.Size = new System.Drawing.Size(797, 284);
            this.StudentListGrid.TabIndex = 0;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentTrackerDataSet1;
            // 
            // studentTrackerDataSet1
            // 
            this.studentTrackerDataSet1.DataSetName = "StudentTrackerDataSet1";
            this.studentTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(494, 56);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(122, 46);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete Selected";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(325, 56);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(122, 46);
            this.AddStudentButton.TabIndex = 3;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(2, 114);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(122, 46);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh Student List";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(666, 56);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(122, 46);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update Selected";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataMember = "Students";
            this.studentsBindingSource1.DataSource = this.studentTrackerDataSet1;
            // 
            // fKResultsuserid403A8C7DBindingSource
            // 
            this.fKResultsuserid403A8C7DBindingSource.DataMember = "FK__Results__user_id__403A8C7D";
            this.fKResultsuserid403A8C7DBindingSource.DataSource = this.studentsBindingSource;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // studentTrackerDataSet1BindingSource
            // 
            this.studentTrackerDataSet1BindingSource.DataSource = this.studentTrackerDataSet1;
            this.studentTrackerDataSet1BindingSource.Position = 0;
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "Students";
            this.studentsBindingSource2.DataSource = this.studentTrackerDataSet1BindingSource;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.StudentListGrid);
            this.Name = "StudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKResultsuserid403A8C7DBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentListGrid;
        private StudentTrackerDataSet1 studentTrackerDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentTrackerDataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
        private System.Windows.Forms.BindingSource fKResultsuserid403A8C7DBindingSource;
        private StudentTrackerDataSet1TableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
        private System.Windows.Forms.BindingSource studentTrackerDataSet1BindingSource;
    }
}