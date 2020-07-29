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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }


        private void btnHomeCustomerFeedback_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeSalesStaffDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeSalesEnquiry_Click(object sender, EventArgs e)
        {


        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {





        }

        private void btnHomeGenerateQuotation_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }

        private void pictureBox2222_Click(object sender, EventArgs e)
        {

        }

        private void lblHomepageWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnPatientTreatmentHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateCustomerInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorAppointmentList_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorAppointmentList_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPatientTreatmentHistory_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGenerateCustomerInvoice_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHomeAppointments_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeReports_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeDoctors_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeTreatments_Click(object sender, EventArgs e)
        {

        }

        private void btnHomePatients_Click(object sender, EventArgs e)
        {

        }

        private void btnHomePayments_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeDoctors_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmDoctorRegistration frmDoctorRegistration = new frmDoctorRegistration();
            frmDoctorRegistration.Show();
        }

        private void btnDoctorAppointmentList_Click_2(object sender, EventArgs e)
        {
            frmDoctorAppointmentList frmDoctorAppointmentList = new frmDoctorAppointmentList();
            frmDoctorAppointmentList.Show();
        }

        private void btnPatientTreatmentHistory_Click_2(object sender, EventArgs e)
        {
            frmPatientTreatmentHistory frmPatientTreatmentHistory = new frmPatientTreatmentHistory();
            frmPatientTreatmentHistory.Show();
        }

        private void btnHomeReports_Click_1(object sender, EventArgs e)
        {
            frmIncomeReport frmIncomeReport = new frmIncomeReport();
            frmIncomeReport.Show();
        }

        private void btnHomePayments_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPayment frmPayment = new frmPayment();
            frmPayment.Show();
        }

        private void btnHomeTreatments_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmDentalTreatment frmDentalTreatment = new frmDentalTreatment();
            frmDentalTreatment.Show();
        }

        private void btnHomeAppointments_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmScheduleAppointment frmAppointment = new frmScheduleAppointment();
            frmAppointment.Show();
        }

        private void btnHomePatients_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPatientRegistration frmPatientRegistration = new frmPatientRegistration();
            frmPatientRegistration.Show();
        }

        private void btnGenerateCustomerInvoice_Click_2(object sender, EventArgs e)
        {
            frmGenerateInvoice frmGenerateInvoice = new frmGenerateInvoice();
            frmGenerateInvoice.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctorExperience_Click(object sender, EventArgs e)
        {
            frmDoctorExperience frmDoctorExperience = new frmDoctorExperience();
            frmDoctorExperience.Show();
        }
    }
}
