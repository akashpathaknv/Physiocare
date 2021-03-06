using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physiocare
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }
        
        PhysiocareClasses.Physiocare c = new PhysiocareClasses.Physiocare();

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewPatient_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtFirstName != null && txtLastName != null && txtAge != null && cmbGender != null && txtContactNumber != null && txtPatientProblem != null && txtPerSessionCost != null)
            {
                //Get all the values from the input fields
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

                // Inserting data into Database using insert method present in PhysiocareClasses
                bool success = c.InsertPatient(c);
                if(success == true)
                {
                    //Successfully inserted
                    MessageBox.Show("New Patient details has been inserted");
                    Clear();
                }

                else
                {
                    //Unsuccessful 
                    MessageBox.Show("Error while inserting data in the table");
                }

            }

            else
            {
                MessageBox.Show("Kindly enter all the mandatory fields marked with *. Try Again.");
            }
        }


        public void Clear()
        {
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

     
    }
}
