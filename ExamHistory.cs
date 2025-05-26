using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Student_Tracking_System
{
    public partial class ExamHistory : Form
    {

        int user_id;

        public ExamHistory(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.resultsTableAdapter.Fill(this.studentTrackerDataSet1.Results, user_id);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var table = this.studentTrackerDataSet1.Results;
            if (table.Rows.Count == 0) return;
            using (var sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = "ExamHistory.pdf" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                using (var fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
                    for (int c = 0; c < table.Columns.Count; c++)
                        pdfTable.AddCell(new Phrase(table.Columns[c].ColumnName));
                    foreach (DataRow row in table.Rows)
                        for (int c = 0; c < table.Columns.Count; c++)
                            pdfTable.AddCell(new Phrase(row[c].ToString()));
                    doc.Add(pdfTable);
                    doc.Close();
                }
            }
        }

    }
}