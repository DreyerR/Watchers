using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watchers.Webservice;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

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
                CreatePDF(dgvReport);
            }
            else
            {
                if (MessageBox.Show("There are no current records to export.\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CreatePDF(dgvReport);
                }
            }
        }

        private void CreatePDF(DataGridView dgv)
        {
            try
            {
                BaseFont baseF = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font txt = new iTextSharp.text.Font(baseF, 12, iTextSharp.text.Font.NORMAL);

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
                        Document pdfdoc = new Document(PageSize.A4, 40f, 40f, 40f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdfTable);
                        pdfdoc.Close();
                        stream.Close();

                    }
                    MessageBox.Show("Report successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
