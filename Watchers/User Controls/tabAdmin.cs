using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Watchers.Webservice;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using LiveCharts;
using Watchers.Forms;

namespace Watchers
{
    public partial class tabAdmin : UserControl
    {

        private static tabAdmin _instance;

        public static tabAdmin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new tabAdmin();
                }
                return _instance;
            }
        }

        public tabAdmin()
        {
            InitializeComponent();
        }

        private void cbbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbCategory.SelectedIndex)
            {
                case 0:
                    PopulateBookings();
                    break;
                case 1:
                    break;
                case 2:
                    PopulateUsers();
                    break;
            }
        }

        private async void PopulateUsers()
        {
            try
            {
                cbbCategory.Enabled = false;
                lblCategory.Text = "Please wait...";

                DataTable users = await Api.GetAllUsersAsync();

                if (users != null)
                {
                    dgvReport.DataSource = users;

                    dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    lblCategory.Text = "Choose a report:";
                    cbbCategory.Enabled = true;
                }
                else
                {
                    Message.ShowMessage("Error on server side\nUsers: null", Message.MessageType.Error);
                }
  
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }

        private async void PopulateBookings()
        {
            try
            {
                cbbCategory.Enabled = false;
                lblCategory.Text = "Please wait...";

                DataTable bookings = await Api.GetAllBookingsAsync();

                if (bookings != null)
                {
                    dgvReport.DataSource = bookings;

                    dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    lblCategory.Text = "Choose a report:";
                    cbbCategory.Enabled = true;
                }
                else
                {
                    Message.ShowMessage("Error on server side\nUsers: null", Message.MessageType.Error);
                }

            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                CreatePDF(dgvReport, cbbCategory.SelectedItem.ToString());
            }
            else
            {
                if (MessageBox.Show("There are no current records to export.\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CreatePDF(dgvReport, cbbCategory.SelectedItem.ToString());
                }
            }
        }

        private void CreatePDF(DataGridView dgv, string title)
        {
            try
            {
                BaseFont baseF = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font txt = new iTextSharp.text.Font(baseF, 10, iTextSharp.text.Font.NORMAL);

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, txt));
                    cell.BackgroundColor = new BaseColor(Color.White);
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), txt));
                    }
                }

                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Save PDF report as";
                dialog.Filter = "PDF File | *.pdf";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream stream = new FileStream(dialog.FileName, FileMode.Create);
                    {
                        string workingDirectory = Environment.CurrentDirectory;
                        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                        iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(projectDirectory);
                        Document pdfdoc = new Document(PageSize.A4, 40f, 40f, 40f, 0f);

                        Paragraph heading = new Paragraph(title + " Report", FontFactory.GetFont("Courier", 25, 1, new BaseColor(255, 140, 51)));
                        heading.Alignment = Element.ALIGN_CENTER;
                        heading.SpacingBefore = 10f;
                        heading.SpacingAfter = 1f;

                        PdfWriter.GetInstance(pdfdoc, stream);

                        jpg.ScaleToFit(140f, 120f);
                        jpg.SpacingBefore = 10f;
                        jpg.SpacingAfter = 2f;
                        jpg.Alignment = Element.ALIGN_CENTER;

                        string dateNow = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                        Paragraph date = new Paragraph(dateNow, FontFactory.GetFont("Courier", 10, 1));
                        date.Alignment = Element.ALIGN_RIGHT;
                        date.SpacingBefore = 10f;
                        date.SpacingAfter = 2f;

                        pdfdoc.Open();
                        pdfdoc.Add(jpg);
                        pdfdoc.Add(Chunk.NEWLINE);
                        pdfdoc.Add(heading);
                        pdfdoc.Add(date);
                        pdfdoc.Add(pdfTable);
                        pdfdoc.Close();
                        stream.Close();

                    }
                    MessageBox.Show("Report successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    stream.Dispose();
                }
                dialog.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnChart_Click(object sender, EventArgs e)
        {
            try
            {
                btnChart.Enabled = false;
                btnChart.Text = "Please wait...";
                Cursor = Cursors.WaitCursor;

                SeriesCollection series = await Api.GetMovieCount();

                btnChart.Enabled = true;
                btnChart.Text = "Show Movie Statistics";
                Cursor = Cursors.Default;

                frmChart form = new frmChart(series);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }
    }
}
