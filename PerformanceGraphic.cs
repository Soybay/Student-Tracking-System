using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace Student_Tracking_System
{
    public partial class PerformanceGraphic : Form
    {
        int user_id;

        public PerformanceGraphic(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            LoadPerformanceColumns();
        }

        void LoadPerformanceColumns()
        {
            DataTable dt = new DataTable();
            string cs = "Data Source=LAPTOP-RU2S58BF;Initial Catalog=StudentTracker;Integrated Security=True;";
            using (var con = new SqlConnection(cs))
            using (var da = new SqlDataAdapter(
                "SELECT TOP(6) e.exam_date, " +
                "(r.math_score + r.science_score + r.turkish_score + r.inkilap_score + r.religion_score + r.english_score) AS total_score " +
                "FROM Results r " +
                "JOIN Exams e ON r.exam_id = e.exam_id " +
                "WHERE r.user_id = @uid " +
                "ORDER BY e.exam_date DESC", con))
            {
                da.SelectCommand.Parameters.AddWithValue("@uid", user_id);
                da.Fill(dt);
            }

            dt.DefaultView.Sort = "exam_date ASC";
            dt = dt.DefaultView.ToTable();

            PerformanceChart.Series.Clear();
            var series = new Series("Total")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (DataRow row in dt.Rows)
            {
                var date = (DateTime)row["exam_date"];
                string label = date.ToString("yyyy-MM-dd");
                double value = Convert.ToDouble(row["total_score"]);
                series.Points.AddXY(label, value);
            }

            PerformanceChart.Series.Add(series);

            var area = PerformanceChart.ChartAreas[0];
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 90;
            area.AxisY.Interval = 15;
            area.AxisX.Interval = 1;
            PerformanceChart.Invalidate();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            using (var ms = new MemoryStream())
            {
                PerformanceChart.SaveImage(ms, ChartImageFormat.Png);
                ms.Position = 0;
                var pdf = new PdfDocument();
                var page = pdf.AddPage();
                var gfx = XGraphics.FromPdfPage(page);
                var img = XImage.FromStream(ms);
                var ratio = Math.Min(page.Width.Point / img.PixelWidth, page.Height.Point / img.PixelHeight);
                var w = img.PixelWidth * ratio;
                var h = img.PixelHeight * ratio;
                gfx.DrawImage(img, (page.Width.Point - w) / 2, (page.Height.Point - h) / 2, w, h);
                using (var sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = "Performance.pdf" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                        pdf.Save(sfd.FileName);
                }
            }
        }
    }
}
