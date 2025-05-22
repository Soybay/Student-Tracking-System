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
            this.ExamsListGrid = new System.Windows.Forms.DataGridView();
            this.AddExamButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExamsListGrid)).BeginInit();
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
            this.AddExamButton.Location = new System.Drawing.Point(666, 71);
            this.AddExamButton.Name = "AddExamButton";
            this.AddExamButton.Size = new System.Drawing.Size(113, 40);
            this.AddExamButton.TabIndex = 1;
            this.AddExamButton.Text = "Add Exam";
            this.AddExamButton.UseVisualStyleBackColor = true;
            this.AddExamButton.Click += new System.EventHandler(this.AddExamButton_Click);
            // 
            // ExamsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddExamButton);
            this.Controls.Add(this.ExamsListGrid);
            this.Name = "ExamsList";
            this.Text = "ExamsList";
            this.Load += new System.EventHandler(this.ExamsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamsListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ExamsListGrid;
        private System.Windows.Forms.Button AddExamButton;
    }
}