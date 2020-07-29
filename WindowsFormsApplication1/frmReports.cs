using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.CrystalReportsFolder;

namespace WindowsFormsApplication1
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
        }

        private void btnPatientTreatmentHistory_Click(object sender, EventArgs e)
        {
            frmPatientTreatmentHistory frmPatientTreatmentHistory = new frmPatientTreatmentHistory();
            frmPatientTreatmentHistory.Show();
        }

        private void btnDoctorAppointmentList_Click(object sender, EventArgs e)
        {
            frmDoctorAppointmentList frmDoctorAppointmentList = new frmDoctorAppointmentList();
            frmDoctorAppointmentList.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientTreatmentHistory_Click_1(object sender, EventArgs e)
        {
            frmPatientTreatmentHistory frmPatientTreatmentHistory = new frmPatientTreatmentHistory();
            frmPatientTreatmentHistory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeTreatments_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorAppointmentList_Click_1(object sender, EventArgs e)
        {
            frmDoctorAppointmentList frmDoctorAppointmentList = new frmDoctorAppointmentList();
            frmDoctorAppointmentList.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmGenerateInvoice frmGenerateInvoice = new frmGenerateInvoice();
            frmGenerateInvoice.Show();
        }

        private void btnGenerateCustomerInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorAppointmentList_Click_2(object sender, EventArgs e)
        {

        }

        private void btnPatientTreatmentHistory_Click_2(object sender, EventArgs e)
        {

        }
    }
}
