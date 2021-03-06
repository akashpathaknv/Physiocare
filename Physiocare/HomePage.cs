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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPatient newPatient = new NewPatient();
            newPatient.ShowDialog();
            this.Close();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance attendance = new Attendance();
            attendance.ShowDialog();
            this.Close();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing billing = new Billing();
            billing.ShowDialog();
            this.Close();
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateDetails updateDetails = new UpdateDetails();
            updateDetails.ShowDialog();
            this.Close();
        }
    }
}
