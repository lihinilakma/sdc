using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmPatientRegistration : Form
    {
        public frmPatientRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnPatientRegistrationSave.Image = WindowsFormsApplication1.Properties.Resources.saveicon;
            this.btnPatientRegistrationDelete.Image = WindowsFormsApplication1.Properties.Resources.delete;
            this.btnPatientRegistrationUpdate.Image = WindowsFormsApplication1.Properties.Resources.update_25_252;
            this.btnPatientRegistrationSearchPatient.Image= WindowsFormsApplication1.Properties.Resources.search_icon_16;
        
        }

        private void btnPatientRegistrationSave_Click(object sender, EventArgs e)
        {
            

             if (string.IsNullOrWhiteSpace(txtPatientRegistrationContactNo.Text))
            {
                MessageBox.Show("The contact number should be entered." ,"Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPatientRegistrationContactNo.TextLength<=9)
            {
                MessageBox.Show("The contact number should have 10 digits.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else if (string.IsNullOrWhiteSpace(txtPatientRegistrationPatientID.Text))
             {
                 MessageBox.Show("A patient ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else
             {
                 try
                 {
                     PatientDBO pdbo = new PatientDBO();
                     string patientid = txtPatientRegistrationPatientID.Text;
                     string fname = txtPatientRegistrationFirstName.Text;
                     string surname = txtPatientRegistrationSurname.Text;
                     string address = txtPatientRegistrationAddress.Text;
                     string nic = txtPatientRegistrationNIC.Text;
                     int contactno = int.Parse(txtPatientRegistrationContactNo.Text.Trim());
                     int registrationfee = int.Parse(txtPatientRegistrationRegistrationFee.Text.Trim());


                     Patient patient = new Patient(patientid, fname, surname, address, nic, contactno, registrationfee);
                     pdbo.patientInfo(patient);
                     MessageBox.Show("The new patient's information was added successfully.", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 catch (Exception ex2)
                 {
                     MessageBox.Show("This Patient's ID has already been entered.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 }

             }


        }

        private void btnPatientRegistrationUpdate_Click(object sender, EventArgs e)
        {

            PatientDBO pdbo = new PatientDBO();
            string patientid = txtPatientRegistrationPatientID.Text;
            string fname = txtPatientRegistrationFirstName.Text;
            string surname = txtPatientRegistrationSurname.Text;
            string address = txtPatientRegistrationAddress.Text;
            string nic = txtPatientRegistrationNIC.Text;
            int contactno = int.Parse(txtPatientRegistrationContactNo.Text.Trim());
            int registrationfee = int.Parse(txtPatientRegistrationRegistrationFee.Text.Trim());

            Patient patient = new Patient(patientid, fname, surname, address, nic, contactno, registrationfee);
            pdbo.updatePatientInfo(patient);
            MessageBox.Show("Changes made to the patient's record has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
        }

        private void txtPatientRegistrationContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPatientRegistrationRegistrationFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnPatientRegistrationDelete_Click(object sender, EventArgs e)
        {

            PatientDBO pdbo = new PatientDBO();
            string patientid = txtPatientRegistrationPatientID.Text;
            string fname = txtPatientRegistrationFirstName.Text;
            string surname = txtPatientRegistrationSurname.Text;
            string address = txtPatientRegistrationAddress.Text;
            string nic = txtPatientRegistrationNIC.Text;
            int contactno = int.Parse(txtPatientRegistrationContactNo.Text.Trim());
            int registrationfee = int.Parse(txtPatientRegistrationRegistrationFee.Text.Trim());

            Patient patient = new Patient(patientid, fname, surname, address, nic, contactno, registrationfee);
            pdbo.deletePatientInfo(patient);
            MessageBox.Show("The patient's record & it's information has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtPatientRegistrationPatientID.Text = ""; txtPatientRegistrationFirstName.Text = ""; txtPatientRegistrationSurname.Text = ""; txtPatientRegistrationAddress.Text = ""; txtPatientRegistrationNIC.Text = ""; txtPatientRegistrationContactNo.Text = ""; txtPatientRegistrationRegistrationFee.Text = "";




        }

        private void btnPatientRegistrationSearchPatient_Click(object sender, EventArgs e)
        {

            try
            {
                string patientid = txtPatientRegistrationPatientID.Text;
                PatientDBO pdbo = new PatientDBO();
                Patient patient = pdbo.findPatient(patientid);

                txtPatientRegistrationPatientID.Text = patient.getPatientID();
                txtPatientRegistrationFirstName.Text = patient.getFirstName();
                txtPatientRegistrationSurname.Text = patient.getSurname();
                txtPatientRegistrationAddress.Text = patient.getAddress();
                txtPatientRegistrationNIC.Text= patient.getNIC();
                txtPatientRegistrationContactNo.Text = patient.getContactNo().ToString();
                txtPatientRegistrationRegistrationFee.Text = patient.getRegistrationFee().ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't find any records or details of such a Patient.", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPatientRegistrationPatientID.Text = ""; txtPatientRegistrationFirstName.Text = ""; txtPatientRegistrationSurname.Text = ""; txtPatientRegistrationAddress.Text = ""; txtPatientRegistrationNIC.Text = ""; txtPatientRegistrationContactNo.Text = ""; txtPatientRegistrationRegistrationFee.Text = "";

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
    }
}
