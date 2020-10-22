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
using System.Resources;

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
            set
            {
                _instance = null;
            }
        }

        public tabAdmin()
        {
            InitializeComponent();
        }

        private void cbbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (cbbCategory.SelectedIndex)
                {
                    case 0:
                        PopulateBookings();
                        break;
                    case 1:
                        PopulateOrders();
                        break;
                    case 2:
                        PopulateUsers();
                        break;
                }
                btnPDF.Enabled = true;
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
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
                lblCategory.Text = "Please wait..."; //giving effects to the cursor

                DataTable bookings = await Api.GetAllBookingsAsync();  //using the api method to populate the datagridview

                if (bookings != null)
                {
                    dgvReport.DataSource = bookings; //setting the dataset of the datagridview to the booking object

                    //setting the values for all the columns of the datagridview
                    dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    lblCategory.Text = "Choose a report:";  //giving effects to the cursor
                    cbbCategory.Enabled = true;  
                }
                else
                {
                    Message.ShowMessage("Error on server side\nBookings: null", Message.MessageType.Error);
                    lblCategory.Text = "Choose a report:";  //giving effects to the cursor
                    cbbCategory.Enabled = true; 
                    cbbCategory.Focus();
                }

            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
                lblCategory.Text = "Choose a report:";
                cbbCategory.Enabled = true; 
                cbbCategory.Enabled = true;
                cbbCategory.SelectedIndex = -1;
                cbbCategory.Focus();
            }
        }

        private async void PopulateOrders()
        {
            try
            {
                cbbCategory.Enabled = false;
                lblCategory.Text = "Please wait...";

                DataTable orders = await Api.GetOrdersAsync();

                if (orders != null)
                {
                    dgvReport.DataSource = orders;

                    dgvReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvReport.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    lblCategory.Text = "Choose a report:";
                    cbbCategory.Enabled = true;
                }
                else
                {
                    Message.ShowMessage("Error on server side\nOrders: null", Message.MessageType.Error);
                    lblCategory.Text = "Choose a report:";
                    cbbCategory.Enabled = true;
                    cbbCategory.SelectedIndex = -1;
                    cbbCategory.Focus();
                }

            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
                lblCategory.Text = "Choose a report:";
                cbbCategory.Enabled = true;
                cbbCategory.SelectedIndex = -1;
                cbbCategory.Focus();
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReport.Rows.Count > 0)
                {
                    CreatePDF(dgvReport, cbbCategory.SelectedItem.ToString()); //calling the pdf method
                }
                else
                {
                    if (MessageBox.Show("There are no current records to export.\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if(cbbCategory.SelectedIndex == -1)
                        {
                            Message.ShowMessage("No category was selected...Please select a category", Message.MessageType.Error);
                            cbbCategory.Focus();
                        }else
                        {
                            CreatePDF(dgvReport, cbbCategory.SelectedItem.ToString());
                        }
                    }
                }
            }
            catch(Exception error)
            {
                Message.ShowMessage(error.Message, Message.MessageType.Error);
            }
        }

        private void CreatePDF(DataGridView dgv, string title)
        {
            try
            {
                //create a font object used in the pdf
                BaseFont baseF = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count); //create a new pdf table with the column count the same as that of the datagridview
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT; //text in pdf table is left aligned
                pdfTable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font txt = new iTextSharp.text.Font(baseF, 6, iTextSharp.text.Font.NORMAL); //add the font object to the pdf 

                foreach (DataGridViewColumn col in dgv.Columns) //creating the columns in the pdf table
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, txt));
                    cell.BackgroundColor = new BaseColor(Color.White);
                    pdfTable.DefaultCell.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER; //formatting cells to be more readible
                    pdfTable.AddCell(cell);
                    pdfTable.DefaultCell.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
                }

                foreach (DataGridViewRow row in dgv.Rows) //transverse the rows in the datagridview to be the same as that of pdf table
                {
                    foreach (DataGridViewCell cell in row.Cells)//populate the rows of the pdf table
                    {
                        pdfTable.AddCell(new Phrase(cell.Value.ToString(), txt));
                    }
                }

                SaveFileDialog dialog = new SaveFileDialog(); //object for save file dialog 
                dialog.Title = "Save PDF report as";
                dialog.Filter = "PDF File | *.pdf";

                if (dialog.ShowDialog() == DialogResult.OK) //if the dialog result is OK
                {
                    FileStream stream = new FileStream(dialog.FileName, FileMode.Create); //creating an object for filestream of the pdf
                    {
                        Document pdfdoc = new Document(PageSize.A4, 40f, 40f, 40f, 0f);//creating a object for the document component of the pdf

                        Paragraph heading = new Paragraph(title + " Report", FontFactory.GetFont("Courier", 25, 1, new BaseColor(255, 140, 51))); //creating a paragraph object
                        heading.Alignment = Element.ALIGN_CENTER; //heading is center aligned
                        heading.SpacingBefore = 10f;
                        heading.SpacingAfter = 1f;

                        PdfWriter.GetInstance(pdfdoc, stream);

                        string workingDirectory = Environment.CurrentDirectory + @"\Resources\Watchers2.png"; //getting the path for the pdf
                        //string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Watchers\\Resources\\Watchers2.png";

                        iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(workingDirectory); //creating a image object for the image

                        jpg.ScaleToFit(140f, 120f);
                        jpg.SpacingBefore = 10f;
                        jpg.SpacingAfter = 2f;
                        jpg.Alignment = Element.ALIGN_CENTER;

                        string dateNow = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                        Paragraph date = new Paragraph(dateNow, FontFactory.GetFont("Courier", 10, 1));
                        date.Alignment = Element.ALIGN_CENTER;
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
                Cursor = Cursors.WaitCursor;  //giving effects to the cursor

                SeriesCollection series = await Api.GetMovieCount(); //api method to get number of movies

                btnChart.Enabled = true;
                btnChart.Text = "Show Movie Statistics";
                Cursor = Cursors.Default; //giving effects to the cursor

                frmChart form = new frmChart(series); //the series is sent to the chart form
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                Message.ShowMessage(ex.Message, Message.MessageType.Error);
            }
        }
    }
}
