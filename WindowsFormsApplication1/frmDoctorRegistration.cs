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
    public partial class frmDoctorRegistration : Form
    {
        public frmDoctorRegistration()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {



        }

        private void frmDoctorRegistration_Load(object sender, EventArgs e)
        {
            this.btnDoctorRegistrationSave.Image = WindowsFormsApplication1.Properties.Resources.saveicon;
            this.btnDoctorRegistrationDelete.Image = WindowsFormsApplication1.Properties.Resources.delete;
            this.btnDoctorRegistrationSearchDoctor.Image = WindowsFormsApplication1.Properties.Resources.search_icon_16;
            this.btnDoctorRegistrationUpdate.Image = WindowsFormsApplication1.Properties.Resources.update_25_252;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
        }

        private void txtDoctorRegistrationContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDoctorRegistrationSave_Click(object sender, EventArgs e)
        {




            if (string.IsNullOrWhiteSpace(txtDoctorRegistrationContactNo.Text))
            {
                MessageBox.Show("The contact number should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtDoctorRegistrationContactNo.TextLength <= 9)
            {
                MessageBox.Show("The contact number should have 10 digits.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtDoctorRegistrationDoctorID.Text))
            {
                MessageBox.Show("A doctor ID should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DoctorDBO ddbo = new DoctorDBO();
                    string doctorid = txtDoctorRegistrationDoctorID.Text;
                    string fname = txtDoctorRegistrationFirstName.Text;
                    string surname = txtDoctorRegistrationSurname.Text;
                    string address = txtDoctorRegistrationAddress.Text;
                    string dob = txtDoctorRegistrationDateOfBirth.Text;
                    string nic = txtDoctorRegistrationNIC.Text;
                    int contactno = int.Parse(txtDoctorRegistrationContactNo.Text.Trim());
                    int experience = int.Parse(txtDoctorRegistrationExperience.Text.Trim());
                    string speciality = "null"; if (rdobtnDoctorRegistrationDentist.Checked == true) { speciality = "Dentist"; } else if (rdobtnDoctorRegistrationConsultant.Checked == true) { speciality = "Dental Consultant"; };


                    Doctor doctor = new Doctor(doctorid, fname, surname, address, dob, nic, contactno, experience, speciality);
                    ddbo.doctorInfo(doctor);
                    MessageBox.Show("The new doctor's information was added successfully.", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("This Doctor's ID has already been entered.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        private void btnDoctorRegistrationDelete_Click(object sender, EventArgs e)
        {


            DoctorDBO ddbo = new DoctorDBO();
            string doctorid = txtDoctorRegistrationDoctorID.Text;
            string fname = txtDoctorRegistrationFirstName.Text;
            string surname = txtDoctorRegistrationSurname.Text;
            string address = txtDoctorRegistrationAddress.Text;
            string dob = txtDoctorRegistrationDateOfBirth.Text;
            string nic = txtDoctorRegistrationNIC.Text;
            int contactno = int.Parse(txtDoctorRegistrationContactNo.Text.Trim());
            int experience = int.Parse(txtDoctorRegistrationExperience.Text.Trim());
            string speciality = "null"; if (rdobtnDoctorRegistrationDentist.Checked == true) { speciality = "Dentist"; } else if (rdobtnDoctorRegistrationConsultant.Checked == true) { speciality = "Dental Consultant"; };

            Doctor doctor = new Doctor(doctorid, fname, surname, address, dob, nic, contactno, experience, speciality);
            ddbo.deleteDoctorInfo(doctor);
            MessageBox.Show("The doctor's record & it's information has been removed.", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtDoctorRegistrationDoctorID.Text = ""; txtDoctorRegistrationFirstName.Text = ""; txtDoctorRegistrationSurname.Text = ""; txtDoctorRegistrationAddress.Text = ""; txtDoctorRegistrationDateOfBirth.Text = ""; txtDoctorRegistrationNIC.Text = ""; txtDoctorRegistrationContactNo.Text = ""; txtDoctorRegistrationExperience.Text = ""; rdobtnDoctorRegistrationConsultant.Checked = false; rdobtnDoctorRegistrationDentist.Checked = false;


        }

        private void btnDoctorRegistrationUpdate_Click(object sender, EventArgs e)
        {

            DoctorDBO ddbo = new DoctorDBO();
            string doctorid = txtDoctorRegistrationDoctorID.Text;
            string fname = txtDoctorRegistrationFirstName.Text;
            string surname = txtDoctorRegistrationSurname.Text;
            string address = txtDoctorRegistrationAddress.Text;
            string dob = txtDoctorRegistrationDateOfBirth.Text;
            string nic = txtDoctorRegistrationNIC.Text;
            int contactno = int.Parse(txtDoctorRegistrationContactNo.Text.Trim());
            int experience = int.Parse(txtDoctorRegistrationExperience.Text.Trim());
            string speciality = "null"; if (rdobtnDoctorRegistrationDentist.Checked == true) { speciality = "Dentist"; } else if (rdobtnDoctorRegistrationConsultant.Checked == true) { speciality = "Dental Consultant"; };

            Doctor doctor = new Doctor(doctorid, fname, surname, address, dob, nic, contactno, experience, speciality);
            ddbo.updateDoctorInfo(doctor);
            MessageBox.Show("Changes made to the doctor's information has been updated.", "Edit Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnDoctorRegistrationSearchDoctor_Click(object sender, EventArgs e)
        {




            try
            {
                string doctorid = txtDoctorRegistrationDoctorID.Text;
                DoctorDBO ddbo = new DoctorDBO();
                Doctor doctor = ddbo.findDoctor(doctorid);

                txtDoctorRegistrationDoctorID.Text= doctor.getDoctorID();
                txtDoctorRegistrationFirstName.Text = doctor.getFirstName();
                txtDoctorRegistrationSurname.Text = doctor.getSurname();
                txtDoctorRegistrationAddress.Text = doctor.getAddress();
                txtDoctorRegistrationDateOfBirth.Text= doctor.getDOB();
                txtDoctorRegistrationNIC.Text = doctor.getNIC();
                txtDoctorRegistrationContactNo.Text = doctor.getContactNo().ToString();
                txtDoctorRegistrationExperience.Text = doctor.getExperience().ToString();
                string Speciality = doctor.getSpeciality();
                if (Speciality == "Dentist") { rdobtnDoctorRegistrationDentist.Checked = true; } else if (Speciality == "Dental Consultant") {rdobtnDoctorRegistrationConsultant.Checked = true; } 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't find any records or details of such a Doctor.", "Incorrect Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDoctorRegistrationDoctorID.Text = ""; txtDoctorRegistrationFirstName.Text = ""; txtDoctorRegistrationSurname.Text = ""; txtDoctorRegistrationAddress.Text = ""; txtDoctorRegistrationDateOfBirth.Text = ""; txtDoctorRegistrationNIC.Text = ""; txtDoctorRegistrationContactNo.Text = ""; txtDoctorRegistrationExperience.Text = ""; rdobtnDoctorRegistrationConsultant.Checked = false; rdobtnDoctorRegistrationDentist.Checked = false;

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

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
