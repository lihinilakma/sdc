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
    public partial class frmScheduleAppointment : Form
    {
        public frmScheduleAppointment()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.AppointmentGridView' table. You can move, or remove it, as needed.
            this.appointmentGridViewTableAdapter.Fill(this.dataSet2.AppointmentGridView);
            txtScheduleAppointmentTreatmentType.DropDownStyle = ComboBoxStyle.DropDownList;
            btnScheduleAppointmentUpdate.Hide();
            this.btnScheduleAppointmentSave.Image = WindowsFormsApplication1.Properties.Resources.saveicon;
            this.btnScheduleAppointmentDelete.Image = WindowsFormsApplication1.Properties.Resources.delete;
            this.btnScheduleAppointmentUpdate.Image = WindowsFormsApplication1.Properties.Resources.update_25_252;
            this.btnScheduleAppointmentSearchPatient.Image = WindowsFormsApplication1.Properties.Resources.search_icon_16;
            

        }


        private void btnPatientRegistrationUpdate_Click(object sender, EventArgs e)
        {

                 string doctorid3 = txtScheduleAppointmentDoctorID.Text;
                 string appointmentdate3 = txtScheduleAppointmentAppointmentDate.SelectionRange.Start.ToString("dd MMM yyyy");
                 AppointmentDBO adbo3 = new AppointmentDBO();
                 Appointment appointment3 = adbo3.findCount(doctorid3, appointmentdate3);
                 string temp = "";
                 try
                 {
                     temp = appointment3.getCount().ToString();
                 }
                 catch (Exception ex2)
                 {
                 }

                 if (temp == "8")
                 {
                     MessageBox.Show("Total Appointment Count Reached 8", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 else
                 {
                    
            AppointmentDBO adbo = new AppointmentDBO();
            string channelno = txtScheduleAppointmentChannelNo.Text;
            string patientid = txtScheduleAppointmentPatientID.Text;
            string treatmenttype = txtScheduleAppointmentTreatmentType.Text;
            string problemdescription = txtScheduleAppointmentProblemDescription.Text;
            string doctorid = txtScheduleAppointmentDoctorID.Text;
            string appointmentdate = txtScheduleAppointmentAppointmentDate.SelectionRange.Start.ToString("dd MMM yyyy");
            int count = 1;  //int.Parse(txtScheduleAppointmentTreatmentType.Text.Trim());

            Appointment appointment = new Appointment(channelno, patientid, treatmenttype, problemdescription, doctorid, appointmentdate, count);
            adbo.updateAppointmentInfo(appointment);
            MessageBox.Show("Changes made to the scheduled appointment has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }

        }



        private void btnPatientRegistrationSave_Click(object sender, EventArgs e)
        {

            

             if (string.IsNullOrWhiteSpace(txtScheduleAppointmentDoctorID.Text))
            {
                MessageBox.Show("A doctor ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else if (string.IsNullOrWhiteSpace(txtScheduleAppointmentPatientID.Text))
             {
                 MessageBox.Show("A patient ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else if (string.IsNullOrWhiteSpace(txtScheduleAppointmentChannelNo.Text))
             {
                 MessageBox.Show("A treatment No should be provided.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else
             {
                 string doctorid3 = txtScheduleAppointmentDoctorID.Text;
                 string appointmentdate3 = txtScheduleAppointmentAppointmentDate.SelectionRange.Start.ToString("dd MMM yyyy");
                 AppointmentDBO adbo3 = new AppointmentDBO();
                 Appointment appointment3 = adbo3.findCount(doctorid3, appointmentdate3);
                 string temp = "";
                 try
                 {
                     temp = appointment3.getCount().ToString();
                 }
                 catch (Exception ex2)
                 {
                 }

                 if (temp == "8")
                 {
                     MessageBox.Show("Total Appointment Count Reached 8", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 else
                 {

                     try
                     {
                         AppointmentDBO adbo = new AppointmentDBO();
                         string channelno = txtScheduleAppointmentChannelNo.Text;
                         string patientid = txtScheduleAppointmentPatientID.Text;
                         string treatmenttype = txtScheduleAppointmentTreatmentType.Text;
                         string problemdescription = txtScheduleAppointmentProblemDescription.Text;
                         string doctorid = txtScheduleAppointmentDoctorID.Text;
                         string appointmentdate = txtScheduleAppointmentAppointmentDate.SelectionRange.Start.ToString("dd MMM yyyy");
                         int count = 1;  

                         Appointment appointment1 = new Appointment(channelno, patientid, treatmenttype, problemdescription, doctorid, appointmentdate, count);
                         adbo.appointmentInfo(appointment1);
                         MessageBox.Show("New appointment has been scheduled successfully.", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                         AppointmentDBO bdbo = new AppointmentDBO();
                         Appointment appointment2 = bdbo.findAppointment(patientid, appointmentdate);
                         string counter = (appointment2.getCount() + 1).ToString();
                         int result = Int32.Parse(counter);

                         this.appointmentGridViewTableAdapter.Fill(this.dataSet2.AppointmentGridView);
                         

                     }

                     catch (Exception ex2)
                     {
                         MessageBox.Show("This Treatment No has already been issued.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                     }

                 }
             }


        }

        private void btnPatientRegistrationDelete_Click(object sender, EventArgs e)
        {

            
             if (string.IsNullOrWhiteSpace(txtScheduleAppointmentDoctorID.Text))
            {
                MessageBox.Show("A doctor ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else if (string.IsNullOrWhiteSpace(txtScheduleAppointmentAppointmentDate.SelectionRange.Start.ToString("dd MMM yyyy")))
             {
                 MessageBox.Show("The appointment date should be selected.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
             else
             {

                 AppointmentDBO adbo = new AppointmentDBO();
                 string channelno = txtScheduleAppointmentChannelNo.Text;
                 string patientid = txtScheduleAppointmentPatientID.Text;
                 string treatmenttype = txtScheduleAppointmentTreatmentType.Text;
                 string problemdescription = txtScheduleAppointmentProblemDescription.Text;
                 string doctorid = txtScheduleAppointmentDoctorID.Text;
                 string appointmentdate = txtScheduleAppointmentAppointmentDate.SelectionRange.Start.ToString("dd MMM yyyy");
                 int count = 1;  //int.Parse(txtScheduleAppointmentTreatmentType.Text.Trim());


                 Appointment appointment = new Appointment(channelno, patientid, treatmenttype, problemdescription, doctorid, appointmentdate, count);
                 adbo.deleteAppointmentInfo(appointment);
                 MessageBox.Show("The scheduled appointment has been cancelled.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                 txtScheduleAppointmentChannelNo.Text = ""; txtScheduleAppointmentPatientID.Text = ""; txtScheduleAppointmentProblemDescription.Text = ""; txtScheduleAppointmentDoctorID.Text = ""; txtScheduleAppointmentAppointmentDate.SelectionStart = DateTime.Today; lblScheduleAppointmentPatientName.Text = ""; lblScheduleAppointmentDoctorName.Text = "";txtScheduleAppointmentTreatmentType.SelectedItem = null;
                 this.appointmentGridViewTableAdapter.Fill(this.dataSet2.AppointmentGridView);

             }
        }


        private void button1_Click(object sender, EventArgs e)
        {





            try
            {
                string patientid = txtScheduleAppointmentPatientID.Text;
                string appointmentdate = txtScheduleAppointmentAppointmentDate.Text;
                AppointmentDBO adbo = new AppointmentDBO();
                Appointment appointment = adbo.findAppointment(patientid,appointmentdate);

                txtScheduleAppointmentChannelNo.Text = appointment.getChannelNO();
                txtScheduleAppointmentPatientID.Text = appointment.getPatientID();
                txtScheduleAppointmentTreatmentType.Text = appointment.getTreatmentType();
                txtScheduleAppointmentProblemDescription.Text = appointment.getProblemDescription();
                txtScheduleAppointmentDoctorID.Text = appointment.getDoctorID();
                DateTime example = Convert.ToDateTime(appointment.getAppointmentDate());
                txtScheduleAppointmentAppointmentDate.SetDate(example);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't find an appointment scheduled of such a Patient.", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtScheduleAppointmentPatientID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string patientid = txtScheduleAppointmentPatientID.Text;
                PatientDBO pdbo = new PatientDBO();
                Patient patient = pdbo.findPatient(patientid);
                lblScheduleAppointmentPatientName.ForeColor = Color.Black;
                lblScheduleAppointmentPatientName.Text = patient.getFirstName() + " " + patient.getSurname();
            }
            catch
            {
                lblScheduleAppointmentPatientName.ForeColor = Color.Red;
                lblScheduleAppointmentPatientName.Text = "Invalid Patient ID";
            }
        }

        private void txtScheduleAppointmentDoctorID_TextAlignChanged(object sender, EventArgs e)
        {
           
        }

        private void txtScheduleAppointmentDoctorID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string doctorid = txtScheduleAppointmentDoctorID.Text;
                DoctorDBO ddbo = new DoctorDBO();
                Doctor doctor = ddbo.findDoctor(doctorid);
                lblScheduleAppointmentDoctorName.ForeColor = Color.Black;
                lblScheduleAppointmentDoctorName.Text = "DR. " + doctor.getFirstName() + " " + doctor.getSurname();
            }
            catch
            {
                lblScheduleAppointmentDoctorName.ForeColor = Color.Red;
                lblScheduleAppointmentDoctorName.Text = "Invalid Doctor ID";

            }
        }

        private void lblScheduleAppointmentPatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            try
            {
                string doctorid = txtScheduleAppointmentDoctorID.Text;
                string appointmentdate = txtScheduleAppointmentAppointmentDate.SelectionRange.Start.ToString("dd MMM yyyy");
                AppointmentDBO adbo = new AppointmentDBO();
                Appointment appointment2 = adbo.findCount(doctorid, appointmentdate);
                lblScheduleAppointmentCount.Text = appointment2.getCount().ToString();
                string temp = lblScheduleAppointmentCount.Text;

                if (temp=="8")
                {
                    MessageBox.Show("Total Appointment Count Reached 8", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("xxxxx", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             */
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblScheduleAppointmentDoctorName_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtScheduleAppointmentTreatmentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtScheduleAppointmentChannelNo.Text = ""; txtScheduleAppointmentPatientID.Text = ""; txtScheduleAppointmentProblemDescription.Text = ""; txtScheduleAppointmentDoctorID.Text = ""; txtScheduleAppointmentAppointmentDate.SelectionStart = DateTime.Today; lblScheduleAppointmentPatientName.Text = ""; lblScheduleAppointmentDoctorName.Text = ""; txtScheduleAppointmentTreatmentType.SelectedItem = null;
            this.appointmentGridViewTableAdapter.Fill(this.dataSet2.AppointmentGridView);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtScheduleAppointmentChannelNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtScheduleAppointmentProblemDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScheduleAppointmentAppointmentDate_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblScheduleAppointmentPatientName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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
