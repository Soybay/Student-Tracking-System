using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Student_Tracking_System
{
    public partial class ExamHistory : Form
    {
        int user_id;

        public ExamHistory(int user_id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ApplyTheme();
            this.user_id = user_id;
            resultsTableAdapter.Fill(studentTrackerDataSet1.Results, user_id);
        }

        void ApplyTheme()
        {
            Color primary = Properties.Settings.Default.PrimaryColor;
            Color accent = Properties.Settings.Default.AccentColor;
            Color textboxBg = Properties.Settings.Default.TextboxBackColor;
            BackColor = primary;
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.BackColor = primary;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = textboxBg;
                btn.MouseEnter += (s, e) => btn.BackColor = accent;
                btn.MouseLeave += (s, e) => btn.BackColor = primary;
            }
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                tb.BackColor = textboxBg;
                tb.ForeColor = Color.Black;
            }
            foreach (ComboBox cb in Controls.OfType<ComboBox>())
            {
                cb.BackColor = textboxBg;
                cb.ForeColor = Color.Black;
                cb.FlatStyle = FlatStyle.Flat;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            DataTable table = studentTrackerDataSet1.Results;
            if (table.Rows.Count == 0) return;
            using (var sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = "ExamHistory.pdf" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    PdfPTable pdfTable = new PdfPTable(table.Columns.Count) { WidthPercentage = 100 };
                    foreach (DataColumn col in table.Columns)
                        pdfTable.AddCell(new Phrase(col.ColumnName));
                    foreach (DataRow row in table.Rows)
                        foreach (var cell in row.ItemArray)
                            pdfTable.AddCell(new Phrase(cell.ToString()));
                    doc.Add(pdfTable);
                    doc.Close();
                }
            }
        }
    }
}
