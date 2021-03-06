using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physiocare
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        PhysiocareClasses.Physiocare c = new PhysiocareClasses.Physiocare();
        private void Attendance_Load(object sender, EventArgs e)
        {
            //Load Data on Data GridView
            DataTable dt = c.SelectPatient();
            dgvAttendance.DataSource = dt;
        }

        // Adding search functionality
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM PATIENT WHERE First_Name LIKE '%" + keyword + "%' OR Last_Name LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvAttendance.DataSource = dt;
        }

        private void dgvAttendance_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //To fetch the data from the DataGridView to all the fields in UpdateDetails form
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtPatientID.Text = dgvAttendance.Rows[rowIndex].Cells[0].Value.ToString();
            txtPatientFirstName.Text = dgvAttendance.Rows[rowIndex].Cells[1].Value.ToString();
            txtPatientLastName.Text = dgvAttendance.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void Calender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            //Get all the values from the input fields
            c.Patient_ID = int.Parse(txtPatientID.Text);
            c.FirstName = txtPatientFirstName.Text;
            c.LastName = txtPatientLastName.Text;
            c.Date = dtpAttendance.Value;

            //Update the data in the database
            bool success = c.InsertAttendance(c);

            if (success == true)
            {
                //Update successful message
                MessageBox.Show(c.FirstName+"'s Attendance has been updated succesfully.");

            }
            else
            {
                //Update unsuccessful message
                MessageBox.Show("Error while inserting Patient's Attendance, Please try again.");
            }

        }
    }
}
