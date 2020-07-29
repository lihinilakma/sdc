using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.CrystalReportsFolder;

namespace WindowsFormsApplication1
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDentalTreatmentPatientID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string patientid = txtPaymentPatientID.Text;
                PatientDBO pdbo = new PatientDBO();
                Patient patient = pdbo.findPatient(patientid);
                lblPaymentPatientName.ForeColor = Color.Black;
                lblPaymentPatientName.Text = patient.getFirstName() + " " + patient.getSurname();
            }
            catch
            {
                lblPaymentPatientName.ForeColor = Color.Red;
                lblPaymentPatientName.Text = "Invalid Patient ID";
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

            this.btnPaymentSave.Image = WindowsFormsApplication1.Properties.Resources.saveicon;
            this.btnPaymentDelete.Image = WindowsFormsApplication1.Properties.Resources.delete;
            this.btnPaymentUpdate.Image = WindowsFormsApplication1.Properties.Resources.update_25_252;
            this.btnPaymentPrintInvoice.Image=WindowsFormsApplication1.Properties.Resources.printer;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
        }

        private void btnPaymentSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtPaymentInvoiceNo.Text))
            {
                MessageBox.Show("An Invoice No should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtPaymentTreatmentCode.Text))
            {
                MessageBox.Show("The treatment ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtPaymentPatientID.Text))
            {
                MessageBox.Show("The patient's ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string patientid = txtPaymentPatientID.Text;
                int registrationfee=0;

                if (chkboxPaymentNewPatient.Checked == true)
                {
                    PatientDBO pdbo2 = new PatientDBO();
                    Patient patient = pdbo2.findPatient(patientid);
                    lblPaymentRegistrationFee.Text = "Registration Fee:-                     " + patient.getRegistrationFee().ToString();
                    registrationfee = patient.getRegistrationFee();
                }
                else if(chkboxPaymentNewPatient.Checked == false)
                {
                    lblPaymentRegistrationFee.Text = "  ";
                    registrationfee = 0;
                };



                    string treatmentcode = txtPaymentTreatmentCode.Text;
                    TreatmentDBO tdbo = new TreatmentDBO();
                    Treatment treatment = tdbo.findCharges(treatmentcode);
                    lblPaymentDoctorsCharge.Text = "Doctor's charge:-                      " + treatment.getDoctorsCharge().ToString();
                    lblPaymentStandardFee.Text = "Treatment Standard Fee:-       " + treatment.getStandardFee().ToString();
                    lblPaymentTotalCharge.Text = "Total Charge:-                            " + (treatment.getDoctorsCharge() + registrationfee + treatment.getStandardFee()).ToString();
                    int doctorscharge = treatment.getDoctorsCharge();
                    int treatmentfee = treatment.getStandardFee();
                    int totalcharge = treatment.getDoctorsCharge() + treatment.getStandardFee() + registrationfee;

                    try
                    {
                    PaymentDBO pdbo = new PaymentDBO();
                    string invoiceno = txtPaymentInvoiceNo.Text;
                    //string patientid = txtPaymentPatientID.Text; (temp)
                    string paymentmode = "None"; if (rdobtnPaymentCash.Checked == true) { paymentmode = "Cash"; } else if (rdobtnPaymentCreditCard.Checked == true) { paymentmode = "Credit Card"; } else if (rdobtnPaymentCheque.Checked == true) { paymentmode = "Cheque"; };



                    Payment payment = new Payment(invoiceno, treatmentcode, patientid, paymentmode, doctorscharge, treatmentfee, totalcharge,registrationfee);
                    pdbo.paymentInfo(payment);
                    MessageBox.Show("Payment information has been recorded successfully.", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("This Invoice ID has already been generated.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
             

            }

        }

        private void btnPaymentDelete_Click(object sender, EventArgs e)
        {

            string patientid = txtPaymentPatientID.Text;
                int registrationfee=0;

                if (chkboxPaymentNewPatient.Checked == true)
                {
                    PatientDBO pdbo2 = new PatientDBO();
                    Patient patient = pdbo2.findPatient(patientid);
                    lblPaymentRegistrationFee.Text = "Registration Fee:-                     " + patient.getRegistrationFee().ToString();
                    registrationfee = patient.getRegistrationFee();
                }
                else if(chkboxPaymentNewPatient.Checked == false)
                {
                    lblPaymentRegistrationFee.Text = "  ";
                    registrationfee = 0;
                };



                    string treatmentcode = txtPaymentTreatmentCode.Text;
                    TreatmentDBO tdbo = new TreatmentDBO();
                    Treatment treatment = tdbo.findCharges(treatmentcode);
                    lblPaymentDoctorsCharge.Text = "Doctor's charge:-                      " + treatment.getDoctorsCharge().ToString();
                    lblPaymentStandardFee.Text = "Treatment Standard Fee:-       " + treatment.getStandardFee().ToString();
                    lblPaymentTotalCharge.Text = "Total Charge:-                            " + (treatment.getDoctorsCharge() + registrationfee + treatment.getStandardFee()).ToString();
                    int doctorscharge = treatment.getDoctorsCharge();
                    int treatmentfee = treatment.getStandardFee();
                    int totalcharge = treatment.getDoctorsCharge() + treatment.getStandardFee() + registrationfee;

                   
                    PaymentDBO pdbo = new PaymentDBO();
                    string invoiceno = txtPaymentInvoiceNo.Text;
                    //string patientid = txtPaymentPatientID.Text; (temp)
                    string paymentmode = "None"; if (rdobtnPaymentCash.Checked == true) { paymentmode = "Cash"; } else if (rdobtnPaymentCreditCard.Checked == true) { paymentmode = "Credit Card"; } else if (rdobtnPaymentCheque.Checked == true) { paymentmode = "Cheque"; };



                        Payment payment = new Payment(invoiceno, treatmentcode, patientid, paymentmode, doctorscharge, treatmentfee, totalcharge,registrationfee);
                        pdbo.deletePaymentInfo(payment);
                        MessageBox.Show("The invoice & it's payment information has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtPaymentInvoiceNo.Text = ""; txtPaymentTreatmentCode.Text = ""; txtPaymentPatientID.Text = ""; rdobtnPaymentCash.Checked = false; rdobtnPaymentCheque.Checked = false; chkboxPaymentNewPatient.Checked = false; rdoBtnsasas.Checked = false; rdobtnPaymentCreditCard.Checked = false; lblPaymentTreatmentType.Text = ""; lblPaymentPatientName.Text = "";
                        lblPaymentDoctorsCharge.Text = "Doctor's charge:-                      "; lblPaymentStandardFee.Text = "Treatment Standard Fee:-       "; lblPaymentTotalCharge.Text = "Total Charge:-                            "; lblPaymentRegistrationFee.Text = "Registration Fee:-                     ";

        }

        private void btnPaymentUpdate_Click(object sender, EventArgs e)
        {
            string patientid = txtPaymentPatientID.Text;
                int registrationfee=0;

                if (chkboxPaymentNewPatient.Checked == true)
                {
                    PatientDBO pdbo2 = new PatientDBO();
                    Patient patient = pdbo2.findPatient(patientid);
                    lblPaymentRegistrationFee.Text = "Registration Fee:-                     " + patient.getRegistrationFee().ToString();
                    registrationfee = patient.getRegistrationFee();
                }
                else if(chkboxPaymentNewPatient.Checked == false)
                {
                    lblPaymentRegistrationFee.Text = "  ";
                    registrationfee = 0;
                };



                    string treatmentcode = txtPaymentTreatmentCode.Text;
                    TreatmentDBO tdbo = new TreatmentDBO();
                    Treatment treatment = tdbo.findCharges(treatmentcode);
                    lblPaymentDoctorsCharge.Text = "Doctor's charge:-                      " + treatment.getDoctorsCharge().ToString();
                    lblPaymentStandardFee.Text = "Treatment Standard Fee:-       " + treatment.getStandardFee().ToString();
                    lblPaymentTotalCharge.Text = "Total Charge:-                            " + (treatment.getDoctorsCharge() + registrationfee + treatment.getStandardFee()).ToString();
                    int doctorscharge = treatment.getDoctorsCharge();
                    int treatmentfee = treatment.getStandardFee();
                    int totalcharge = treatment.getDoctorsCharge() + treatment.getStandardFee() + registrationfee;

                   
                    PaymentDBO pdbo = new PaymentDBO();
                    string invoiceno = txtPaymentInvoiceNo.Text;
                    //string patientid = txtPaymentPatientID.Text; (temp)
                    string paymentmode = "None"; if (rdobtnPaymentCash.Checked == true) { paymentmode = "Cash"; } else if (rdobtnPaymentCreditCard.Checked == true) { paymentmode = "Credit Card"; } else if (rdobtnPaymentCheque.Checked == true) { paymentmode = "Cheque"; };



                    Payment payment = new Payment(invoiceno, treatmentcode, patientid, paymentmode, doctorscharge, treatmentfee, totalcharge,registrationfee);
                    pdbo.updatePaymentInfo(payment);
                    MessageBox.Show("Changes made to the invoice has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void txtPaymentTreatmentCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string treatmentcode = txtPaymentTreatmentCode.Text;
                TreatmentDBO tdbo = new TreatmentDBO();
                Treatment treatment = tdbo.findCharges(treatmentcode);
                lblPaymentTreatmentType.ForeColor = Color.Black;
                lblPaymentTreatmentType.Text = treatment.getTreatmentType();
            }
            catch
            {
                lblPaymentTreatmentType.ForeColor = Color.Red;
                lblPaymentTreatmentType.Text = "Invalid Treatment Code";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPaymentInvoiceNo.Text = ""; txtPaymentTreatmentCode.Text = ""; txtPaymentPatientID.Text = ""; rdobtnPaymentCash.Checked = false; rdobtnPaymentCheque.Checked = false; chkboxPaymentNewPatient.Checked = false; rdoBtnsasas.Checked = false; rdobtnPaymentCreditCard.Checked = false; lblPaymentTreatmentType.Text = ""; lblPaymentPatientName.Text = "";
            lblPaymentDoctorsCharge.Text = "Doctor's charge:-                      "; lblPaymentStandardFee.Text = "Treatment Standard Fee:-       "; lblPaymentTotalCharge.Text = "Total Charge:-                            "; lblPaymentRegistrationFee.Text = "Registration Fee:-                     ";

        }

        private void btnPaymentPrintInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaymentInvoiceNo.Text))
            {
                MessageBox.Show("The invoice number should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmGenerateInvoice frmGenerateInvoice = new frmGenerateInvoice();
                frmGenerateInvoice.Show();
                string pino = txtPaymentInvoiceNo.Text;
                frmGenerateInvoice.txtInvoiceNo.Text = pino.ToString();
              
            }
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
