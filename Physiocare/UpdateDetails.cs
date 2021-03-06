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
    public partial class UpdateDetails : Form
    {
        public UpdateDetails()
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
        private void UpdateDetails_Load(object sender, EventArgs e)
        {
            //Load Data on Data GridView
            DataTable dt = c.SelectPatient();
            dgvUpdate.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get all the values from the input fields
            c.Patient_ID = int.Parse(txtPatientID.Text);
            c.FirstName = txtFirstName.Text;
            c.MiddleName = txtMiddleName.Text;
            c.LastName = txtLastName.Text;
            c.Age = Int32.Parse(txtAge.Text);
            c.Gender = cmbGender.Text;
            c.ContactNumber = txtContactNumber.Text;
            c.EmailID = txtEmailID.Text;
            c.Address = txtAddress.Text;
            c.PatientProblem = txtPatientProblem.Text;
            c.BriefHistory = txtBriefHistory.Text;
            c.Height = (float)Convert.ToDouble(txtHeight.Text);
            c.Weight = (float)Convert.ToDouble(txtWeight.Text);
            c.PerSessionCost = Int32.Parse(txtPerSessionCost.Text);
            c.Notes = txtNotes.Text;
            c.ReferredBy = txtReferredBy.Text;

            //Update the data in the database
            bool success = c.UpdatePatient(c);

            if(success == true)
            {
                //Update successful message
                MessageBox.Show("Patient's Record has been updated succesfully.");

                //Clear all the fields
                Clear();

                //Load Data on Data GridView
                DataTable dt = c.SelectPatient();
                dgvUpdate.DataSource = dt;
            }
            else
            {
                //Update unsuccessful message
                MessageBox.Show("Error while updating Patient's record, Please try again.");
            }

        }

        private void dgvAttendance_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //To fetch the data from the DataGridView to all the fields in UpdateDetails form
            //identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtPatientID.Text = dgvUpdate.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUpdate.Rows[rowIndex].Cells[1].Value.ToString();
            txtMiddleName.Text = dgvUpdate.Rows[rowIndex].Cells[2].Value.ToString();
            txtLastName.Text = dgvUpdate.Rows[rowIndex].Cells[3].Value.ToString();
            txtAge.Text = dgvUpdate.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvUpdate.Rows[rowIndex].Cells[5].Value.ToString();
            txtContactNumber.Text = dgvUpdate.Rows[rowIndex].Cells[6].Value.ToString();
            txtEmailID.Text = dgvUpdate.Rows[rowIndex].Cells[7].Value.ToString();
            txtAddress.Text = dgvUpdate.Rows[rowIndex].Cells[8].Value.ToString();
            txtPatientProblem.Text = dgvUpdate.Rows[rowIndex].Cells[9].Value.ToString();
            txtBriefHistory.Text = dgvUpdate.Rows[rowIndex].Cells[10].Value.ToString();
            txtReferredBy.Text = dgvUpdate.Rows[rowIndex].Cells[11].Value.ToString();
            txtPerSessionCost.Text = dgvUpdate.Rows[rowIndex].Cells[12].Value.ToString();
            txtNotes.Text = dgvUpdate.Rows[rowIndex].Cells[13].Value.ToString();
            txtWeight.Text = dgvUpdate.Rows[rowIndex].Cells[14].Value.ToString();
            txtHeight.Text = dgvUpdate.Rows[rowIndex].Cells[15].Value.ToString();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the value of patient ID from the Form field
            c.Patient_ID = int.Parse(txtPatientID.Text);

            //Delete the record from the table using delete method defined in Physiocare class
            bool success = c.DeletePatient(c);
            if(success == true)
            {
                //Success message
                MessageBox.Show("Patient's record has been successfully deleted.");

                //Clear all the fields
                Clear();

                //Load Data on Data GridView
                DataTable dt = c.SelectPatient();
                dgvUpdate.DataSource = dt;
                
            }
            else
            {
                //Unsucceful message
                MessageBox.Show("Error while deleting the record, please try again later.");
            }
        }

        public void Clear()
        {
            txtPatientID.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAge.Text = "";
            cmbGender.Text = "";
            txtContactNumber.Text = "";
            txtEmailID.Text = "";
            txtAddress.Text = "";
            txtPatientProblem.Text = "";
            txtBriefHistory.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtPerSessionCost.Text = "";
            txtNotes.Text = "";
            txtReferredBy.Text = "";

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
            dgvUpdate.DataSource = dt;
            
        }

        private void dgvUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
