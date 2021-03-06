using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Workbook = Microsoft.Office.Interop.Excel.Workbook;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;
using Application = Microsoft.Office.Interop.Excel.Application;
using DataTable = System.Data.DataTable;

namespace Physiocare
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        PhysiocareClasses.Physiocare c = new PhysiocareClasses.Physiocare();
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog.FileName;
                txtBillFormat.Text = strfilename;
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestinationPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            //Load Data on Data GridView
            DataTable dt = c.SelectPatient();
            dgvBilling.DataSource = dt;
        }

        private void dgvBilling_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //To fetch the data from the DataGridView to all the fields in UpdateDetails form
            //identify the row on which mouse is clicked
            Clear();
            int rowIndex = e.RowIndex;
            txtPatientID.Text = dgvBilling.Rows[rowIndex].Cells[0].Value.ToString();
            txtPatientFirstName.Text = dgvBilling.Rows[rowIndex].Cells[1].Value.ToString();
            txtPatientMiddleName.Text = dgvBilling.Rows[rowIndex].Cells[2].Value.ToString();
            txtPatientLastName.Text = dgvBilling.Rows[rowIndex].Cells[3].Value.ToString();
            txtPatientProblem.Text = dgvBilling.Rows[rowIndex].Cells[9].Value.ToString();
            txtPerSessionCost.Text = dgvBilling.Rows[rowIndex].Cells[12].Value.ToString();            
            txtStartDate.Text = Convert.ToDateTime(dgvBilling.Rows[rowIndex].Cells[16].Value.ToString()).ToString("dd/MM/yyyy");
            c.Patient_ID = int.Parse(txtPatientID.Text);
            txtEndDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Running count query on attendance table to fetch total attendance of selected patient.
            c.SelectAttendace();
            txtTotalNumberOfVisits.Text = c.TotalVisit.ToString();
            txtTotalCost.Text = Convert.ToString(c.TotalVisit * int.Parse(txtPerSessionCost.Text));

        }


        // Adding search functionality
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PATIENT WHERE First_Name LIKE '%" + keyword + "%' OR Last_Name LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvBilling.DataSource = dt;
        }

        public void Clear()
        {
            txtPatientID.Text = "";
            cmbPatientPrefix.Text = "";
            txtPatientFirstName.Text = "";
            txtPatientMiddleName.Text = "";
            txtPatientLastName.Text = "";
            txtPerSessionCost.Text = "";
            txtTotalNumberOfVisits.Text = "";
            txtPatientProblem.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtTotalCost.Text = "";
            txtBillNumber.Text = "";
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            //Get all the values from the input fields
            c.Patient_ID = int.Parse(txtPatientID.Text);
            c.FirstName = txtPatientFirstName.Text;
            c.MiddleName = txtPatientMiddleName.Text;
            c.LastName = txtPatientLastName.Text;
            c.PatientProblem = txtPatientProblem.Text;
            c.TotalVisit = Int32.Parse(txtTotalNumberOfVisits.Text);
            c.TotalCharges = Int32.Parse(txtTotalCost.Text);
            c.BillNumber = Int32.Parse(txtBillNumber.Text);

            //Converting number to words for total amount
            string TotalChargesWords = ConvertNumbertoWords(c.TotalCharges) +" ONLY";
            

            //Generating all the strings to be replaced in the bill format.
            string FullName = cmbPatientPrefix.Text + " " + txtPatientFirstName.Text +" "+ txtPatientMiddleName.Text +" "+ txtPatientLastName.Text;
            string DateRange = txtStartDate.Text + " to " + txtEndDate.Text;
            string FullDesc = "Rs." + txtPerSessionCost.Text + " per session for " + txtTotalNumberOfVisits.Text + " days.";
            string EndDate = txtEndDate.Text;
            string BillNumber = txtBillNumber.Text;
            string PatientProblem = txtPatientProblem.Text;
            string BillDate = txtEndDate.Text;
            string TotalCharges = txtTotalCost.Text;

            //Generate bill in the destination path
            System.IO.File.Copy(txtBillFormat.Text, txtDestinationPath.Text, true);

            void ReplaceTextInExcelFile(string filename)
            {
                try
                {
                    object m = Type.Missing;

                    // open excel.
                    Application app = new Application();

                    // open the workbook. 
                    Workbook wb = app.Workbooks.Open(
                        filename,
                        m, false, m, m, m, m, m, m, m, m, m, m, m, m); ;
                    

                    // get the active worksheet. (Replace this if you need to.) 
                    Worksheet ws = (Worksheet)wb.ActiveSheet;

                    // get the used range. 
                    Range r = (Range)ws.UsedRange;

                    // call the replace method to replace instances. 
                    bool x = (bool)r.Replace(
                        "BillDate", BillDate,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    x = (bool)r.Replace(
                        "AmountInWords", TotalChargesWords,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    x = (bool)r.Replace(
                        "FullName", FullName,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    x = (bool)r.Replace(
                        "DateRange", DateRange,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    x = (bool)r.Replace(
                        "FullDesc", FullDesc,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    x = (bool)r.Replace(
                        "EndDate", EndDate,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    x = (bool)r.Replace(
                        "BillNumber", BillNumber,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    x = (bool)r.Replace(
                        "PatientProblem", PatientProblem,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    x = (bool)r.Replace(
                        "TotalCharges", TotalCharges,
                        XlLookAt.xlWhole,
                        XlSearchOrder.xlByRows,
                        true, m, m, m);

                    // save and close. 
                    wb.Save();
                    //wb.SaveAs(@"C:\Users\akash\source\akash.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, m, m, m, m, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, m, m, m, m, m);
                    app.Quit();
                    app = null;
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
                
                
                
                
            }

            ReplaceTextInExcelFile(txtDestinationPath.Text);


            /*//Generate bill in the destination path
            System.IO.File.Copy(txtBillFormat.Text, txtDestinationPath.Text, true);
            ReplaceTextInExcelFile(txtDestinationPath.Text, "BillDate", txtEndDate.Text);
            //Thread.Sleep(2000);
            ReplaceTextInExcelFile(txtDestinationPath.Text, "BillNumber", txtBillNumber.Text);
            //Thread.Sleep(2000);
            ReplaceTextInExcelFile(txtDestinationPath.Text, "FullName", FullName);
            //Thread.Sleep(2000);
            ReplaceTextInExcelFile(txtDestinationPath.Text, "AmountInWords", TotalChargesWords);
            //Thread.Sleep(2000);
            ReplaceTextInExcelFile(txtDestinationPath.Text, "PatientProblem", txtPatientProblem.Text);
            //Thread.Sleep(2000);
            ReplaceTextInExcelFile(txtDestinationPath.Text, "DateRange", DateRange);
            //Thread.Sleep(2000);
            ReplaceTextInExcelFile(txtDestinationPath.Text, "FullDesc", FullDesc);
            //Thread.Sleep(2000);
            ReplaceTextInExcelFile(txtDestinationPath.Text, "TotalCharges", txtTotalCost.Text);
            */




            //Insert the Billing information in the Billing table using the insertBilling method created in physiocare class
            bool success = c.InsertBilling(c);

            if (success == true)
            {
                //Update successful message
                MessageBox.Show("Bill has been generated succesfully.");

                //Clear all the fields
                Clear();

            }
            else
            {
                //Update unsuccessful message
                MessageBox.Show("Error while generating Bill, Please try again.");
            }
        }



        //Method to convert numbers into words
        public string ConvertNumbertoWords(int number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LACS ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            //if ((number / 10) > 0)  
            //{  
            // words += ConvertNumbertoWords(number / 10) + " RUPEES ";  
            // number %= 10;  
            //}  
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]
                {
            "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"
         };
                var tensMap = new[]
                {
            "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"
        };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }



        




        //Trial for excel edit

       /*public static void ReplaceTextInExcelFile(string filename, string replace, string replacement)
        {
            object m = Type.Missing;

            // open excel.
            Application app = new Application();

            // open the workbook. 
            Workbook wb = app.Workbooks.Open(
                filename,
                m, false, m, m, m, m, m, m, m, m, m, m, m, m);

            // get the active worksheet. (Replace this if you need to.) 
            Worksheet ws = (Worksheet)wb.ActiveSheet;

            // get the used range. 
            Range r = (Range)ws.UsedRange;

            // call the replace method to replace instances. 
            bool success = (bool)r.Replace(
                replace,
                replacement,
                XlLookAt.xlWhole,
                XlSearchOrder.xlByRows,
                true, m, m, m);

            // save and close. 
            wb.Save();
            app.Quit();
            app = null;
        }*/

    }
}
