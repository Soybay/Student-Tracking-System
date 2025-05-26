namespace Student_Tracking_System
{
    partial class ExamHistory
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
            this.ResultsGrid = new System.Windows.Forms.DataGridView();
            this.examidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exam_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sciencescoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turkishscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inkilapscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religionscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishscoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTrackerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTrackerDataSet1 = new Student_Tracking_System.StudentTrackerDataSet1();
            this.resultsTableAdapter = new Student_Tracking_System.StudentTrackerDataSet1TableAdapters.ResultsTableAdapter();
            this.PrintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsGrid
            // 
            this.ResultsGrid.AutoGenerateColumns = false;
            this.ResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examidDataGridViewTextBoxColumn,
            this.exam_date,
            this.mathscoreDataGridViewTextBoxColumn,
            this.sciencescoreDataGridViewTextBoxColumn,
            this.turkishscoreDataGridViewTextBoxColumn,
            this.inkilapscoreDataGridViewTextBoxColumn,
            this.religionscoreDataGridViewTextBoxColumn,
            this.englishscoreDataGridViewTextBoxColumn});
            this.ResultsGrid.DataSource = this.resultsBindingSource;
            this.ResultsGrid.Location = new System.Drawing.Point(1, 129);
            this.ResultsGrid.Name = "ResultsGrid";
            this.ResultsGrid.RowHeadersWidth = 51;
            this.ResultsGrid.RowTemplate.Height = 24;
            this.ResultsGrid.Size = new System.Drawing.Size(799, 319);
            this.ResultsGrid.TabIndex = 0;
            // 
            // examidDataGridViewTextBoxColumn
            // 
            this.examidDataGridViewTextBoxColumn.DataPropertyName = "exam_id";
            this.examidDataGridViewTextBoxColumn.HeaderText = "exam_id";
            this.examidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examidDataGridViewTextBoxColumn.Name = "examidDataGridViewTextBoxColumn";
            this.examidDataGridViewTextBoxColumn.Width = 125;
            // 
            // exam_date
            // 
            this.exam_date.DataPropertyName = "exam_date";
            this.exam_date.HeaderText = "exam_date";
            this.exam_date.MinimumWidth = 6;
            this.exam_date.Name = "exam_date";
            this.exam_date.Width = 125;
            // 
            // mathscoreDataGridViewTextBoxColumn
            // 
            this.mathscoreDataGridViewTextBoxColumn.DataPropertyName = "math_score";
            this.mathscoreDataGridViewTextBoxColumn.HeaderText = "math_score";
            this.mathscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mathscoreDataGridViewTextBoxColumn.Name = "mathscoreDataGridViewTextBoxColumn";
            this.mathscoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // sciencescoreDataGridViewTextBoxColumn
            // 
            this.sciencescoreDataGridViewTextBoxColumn.DataPropertyName = "science_score";
            this.sciencescoreDataGridViewTextBoxColumn.HeaderText = "science_score";
            this.sciencescoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sciencescoreDataGridViewTextBoxColumn.Name = "sciencescoreDataGridViewTextBoxColumn";
            this.sciencescoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // turkishscoreDataGridViewTextBoxColumn
            // 
            this.turkishscoreDataGridViewTextBoxColumn.DataPropertyName = "turkish_score";
            this.turkishscoreDataGridViewTextBoxColumn.HeaderText = "turkish_score";
            this.turkishscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.turkishscoreDataGridViewTextBoxColumn.Name = "turkishscoreDataGridViewTextBoxColumn";
            this.turkishscoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // inkilapscoreDataGridViewTextBoxColumn
            // 
            this.inkilapscoreDataGridViewTextBoxColumn.DataPropertyName = "inkilap_score";
            this.inkilapscoreDataGridViewTextBoxColumn.HeaderText = "inkilap_score";
            this.inkilapscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inkilapscoreDataGridViewTextBoxColumn.Name = "inkilapscoreDataGridViewTextBoxColumn";
            this.inkilapscoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // religionscoreDataGridViewTextBoxColumn
            // 
            this.religionscoreDataGridViewTextBoxColumn.DataPropertyName = "religion_score";
            this.religionscoreDataGridViewTextBoxColumn.HeaderText = "religion_score";
            this.religionscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.religionscoreDataGridViewTextBoxColumn.Name = "religionscoreDataGridViewTextBoxColumn";
            this.religionscoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // englishscoreDataGridViewTextBoxColumn
            // 
            this.englishscoreDataGridViewTextBoxColumn.DataPropertyName = "english_score";
            this.englishscoreDataGridViewTextBoxColumn.HeaderText = "english_score";
            this.englishscoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.englishscoreDataGridViewTextBoxColumn.Name = "englishscoreDataGridViewTextBoxColumn";
            this.englishscoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.studentTrackerDataSet1BindingSource;
            // 
            // studentTrackerDataSet1BindingSource
            // 
            this.studentTrackerDataSet1BindingSource.DataSource = this.studentTrackerDataSet1;
            this.studentTrackerDataSet1BindingSource.Position = 0;
            // 
            // studentTrackerDataSet1
            // 
            this.studentTrackerDataSet1.DataSetName = "StudentTrackerDataSet1";
            this.studentTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(661, 68);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(113, 42);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExamHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ResultsGrid);
            this.Name = "ExamHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExamHistory";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTrackerDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultsGrid;
        private System.Windows.Forms.BindingSource studentTrackerDataSet1BindingSource;
        private StudentTrackerDataSet1 studentTrackerDataSet1;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private StudentTrackerDataSet1TableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn examidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exam_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sciencescoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turkishscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inkilapscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishscoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button PrintButton;
    }
}