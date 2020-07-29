using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmDentalTreatment : Form
    {
        public frmDentalTreatment()
        {
            InitializeComponent();
        }

        private void frmDentalTreatment_Load(object sender, EventArgs e)
        {
            txtDentalTreatmentTreatmentType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.btnDentalTreatmentSave.Image = WindowsFormsApplication1.Properties.Resources.saveicon;
            this.btnDentalTreatmentDelete.Image = WindowsFormsApplication1.Properties.Resources.delete;
            this.btnDentalTreatmentUpdate.Image = WindowsFormsApplication1.Properties.Resources.update_25_252;

            lblDentalTreatmentDoctorName.Text = "";
            lblDentalTreatmentPatientName.Text = "";

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
        }

        private void menuStrip1765_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtDentalTreatmentStandardFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDentalTreatmentDoctorsCharge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDentalTreatmentSave_Click(object sender, EventArgs e)
        {



        }

        private void btnDentalTreatmentDelete_Click(object sender, EventArgs e)
        {



            
        }

        private void btnDentalTreatmentUpdate_Click(object sender, EventArgs e)
        {



        }

        private void txtDentalTreatmentDoctorID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDentalTreatmentPatientID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDentalTreatmentTreatmentCode.Text = ""; txtDentalTreatmentTreatmentDetails.Text = ""; txtDentalTreatmentDoctorID.Text = ""; txtDentalTreatmentPatientID.Text = ""; txtDentalTreatmentStandardFee.Text = ""; txtDentalTreatmentDoctorsCharge.Text = ""; lblDentalTreatmentDoctorName.Text = ""; lblDentalTreatmentPatientName.Text = ""; txtDentalTreatmentTreatmentType.SelectedItem = null;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtDentalTreatmentTreatmentDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDentalTreatmentTreatmentCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDentalTreatmentTreatmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDentalTreatmentDoctorName_Click(object sender, EventArgs e)
        {

        }

        private void lblDentalTreatmentPatientName_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDentalTreatmentStandardFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDentalTreatmentDoctorsCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
        }

        private void btnDentalTreatmentDelete_Click_1(object sender, EventArgs e)
        {
            TreatmentDBO tdbo = new TreatmentDBO();
            string treatmentcode = txtDentalTreatmentTreatmentCode.Text;
            string treatmenttype = txtDentalTreatmentTreatmentType.Text;
            string treatmentdetails = txtDentalTreatmentTreatmentDetails.Text;
            string doctorid = txtDentalTreatmentDoctorID.Text;
            string patientid = txtDentalTreatmentPatientID.Text;
            int standardfee = int.Parse(txtDentalTreatmentStandardFee.Text.Trim());
            int doctorscharge = int.Parse(txtDentalTreatmentDoctorsCharge.Text.Trim());

            Treatment treatment = new Treatment(treatmentcode, treatmenttype, treatmentdetails, doctorid, patientid, standardfee, doctorscharge);
            tdbo.deleteTreatmentInfo(treatment);
            MessageBox.Show("The dental treatment record & it's information has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtDentalTreatmentTreatmentCode.Text = ""; txtDentalTreatmentTreatmentDetails.Text = ""; txtDentalTreatmentDoctorID.Text = ""; txtDentalTreatmentPatientID.Text = ""; txtDentalTreatmentStandardFee.Text = ""; txtDentalTreatmentDoctorsCharge.Text = ""; lblDentalTreatmentDoctorName.Text = ""; lblDentalTreatmentPatientName.Text = ""; txtDentalTreatmentTreatmentType.SelectedItem = null;

        }

        private void btnDentalTreatmentSave_Click_1(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtDentalTreatmentDoctorID.Text))
            {
                MessageBox.Show("The Doctor's ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtDentalTreatmentPatientID.Text))
            {
                MessageBox.Show("The Patient's ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtDentalTreatmentTreatmentType.Text))
            {
                MessageBox.Show("The type of dental treatment should be selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    TreatmentDBO tdbo = new TreatmentDBO();
                    string treatmentcode = txtDentalTreatmentTreatmentCode.Text;
                    string treatmenttype = txtDentalTreatmentTreatmentType.Text;
                    string treatmentdetails = txtDentalTreatmentTreatmentDetails.Text;
                    string doctorid = txtDentalTreatmentDoctorID.Text;
                    string patientid = txtDentalTreatmentPatientID.Text;
                    int standardfee = int.Parse(txtDentalTreatmentStandardFee.Text.Trim());
                    int doctorscharge = int.Parse(txtDentalTreatmentDoctorsCharge.Text.Trim());


                    Treatment treatment = new Treatment(treatmentcode, treatmenttype, treatmentdetails, doctorid, patientid, standardfee, doctorscharge);
                    tdbo.treatmentInfo(treatment);
                    MessageBox.Show("The patient's dental treatment information was added successfully.", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("This Treatment Code has already been entered.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnDentalTreatmentUpdate_Click_1(object sender, EventArgs e)
        {

            TreatmentDBO tdbo = new TreatmentDBO();
            string treatmentcode = txtDentalTreatmentTreatmentCode.Text;
            string treatmenttype = txtDentalTreatmentTreatmentType.Text;
            string treatmentdetails = txtDentalTreatmentTreatmentDetails.Text;
            string doctorid = txtDentalTreatmentDoctorID.Text;
            string patientid = txtDentalTreatmentPatientID.Text;
            int standardfee = int.Parse(txtDentalTreatmentStandardFee.Text.Trim());
            int doctorscharge = int.Parse(txtDentalTreatmentDoctorsCharge.Text.Trim());

            Treatment treatment = new Treatment(treatmentcode, treatmenttype, treatmentdetails, doctorid, patientid, standardfee, doctorscharge);
            tdbo.updateTreatmentInfo(treatment);
            MessageBox.Show("Changes made to the dental treatment record has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void txtDentalTreatmentDoctorID_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string doctorid = txtDentalTreatmentDoctorID.Text;
                DoctorDBO ddbo = new DoctorDBO();
                Doctor doctor = ddbo.findDoctor(doctorid);
                lblDentalTreatmentDoctorName.ForeColor = Color.Black;
                lblDentalTreatmentDoctorName.Text = "DR. " + doctor.getFirstName() + " " + doctor.getSurname();
            }
            catch
            {
                lblDentalTreatmentDoctorName.ForeColor = Color.Red;
                lblDentalTreatmentDoctorName.Text = "Invalid Doctor ID";

            }
        }

        private void txtDentalTreatmentPatientID_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string patientid = txtDentalTreatmentPatientID.Text;
                PatientDBO pdbo = new PatientDBO();
                Patient patient = pdbo.findPatient(patientid);
                lblDentalTreatmentPatientName.ForeColor = Color.Black;
                lblDentalTreatmentPatientName.Text = patient.getFirstName() + " " + patient.getSurname();
            }
            catch
            {
                lblDentalTreatmentPatientName.ForeColor = Color.Red;
                lblDentalTreatmentPatientName.Text = "Invalid Patient ID";
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtDentalTreatmentTreatmentCode.Text = ""; txtDentalTreatmentTreatmentDetails.Text = ""; txtDentalTreatmentDoctorID.Text = ""; txtDentalTreatmentPatientID.Text = ""; txtDentalTreatmentStandardFee.Text = ""; txtDentalTreatmentDoctorsCharge.Text = ""; lblDentalTreatmentDoctorName.Text = ""; lblDentalTreatmentPatientName.Text = ""; txtDentalTreatmentTreatmentType.SelectedItem = null;




        }

        private void exitApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            { } 
        }

        private void btnDentalTreatmentSearch_Click(object sender, EventArgs e)
        {



            try
            {
                string treatmentcode = txtDentalTreatmentTreatmentCode.Text;
                TreatmentDBO tdbo = new TreatmentDBO();
                Treatment treatment = tdbo.findTreatment(treatmentcode);

                txtDentalTreatmentTreatmentCode.Text = treatment.getTreatmentCode();
                txtDentalTreatmentTreatmentType.Text = treatment.getTreatmentType();
                txtDentalTreatmentTreatmentDetails.Text = treatment.getTreatmentDetails();
                txtDentalTreatmentDoctorID.Text = treatment.getDoctorID();
                txtDentalTreatmentPatientID.Text = treatment.getPatientID();
                txtDentalTreatmentStandardFee.Text = treatment.getStandardFee().ToString();
                txtDentalTreatmentDoctorsCharge.Text = treatment.getDoctorsCharge().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't find any matching dental treatment records.", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
