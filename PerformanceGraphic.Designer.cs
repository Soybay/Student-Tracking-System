namespace Student_Tracking_System
{
    partial class PerformanceGraphic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PerformanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PerformanceChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PerformanceChart.ChartAreas.Add(chartArea1);
            this.PerformanceChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.PerformanceChart.Legends.Add(legend1);
            this.PerformanceChart.Location = new System.Drawing.Point(0, 0);
            this.PerformanceChart.Name = "PerformanceChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PerformanceChart.Series.Add(series1);
            this.PerformanceChart.Size = new System.Drawing.Size(800, 450);
            this.PerformanceChart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(186, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Performance Graphic of Latest Exams";
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(660, 357);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(117, 49);
            this.PrintButton.TabIndex = 2;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PerformanceGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PerformanceChart);
            this.Name = "PerformanceGraphic";
            this.Text = "PerformanceGraphic";
            ((System.ComponentModel.ISupportInitialize)(this.PerformanceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PerformanceChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintButton;
    }
}