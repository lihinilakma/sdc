using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class PatientDBO
    {

        SqlConnection conn = null;
        public PatientDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void patientInfo(Patient patient)
        {
            try{
                string pid = patient.getPatientID();
                string pfname = patient.getFirstName();
                string psurname = patient.getSurname();
                string paddress = patient.getAddress();
                string pnic = patient.getNIC();
                int pcontactno = patient.getContactNo();
                int pregistrationfee = patient.getRegistrationFee();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into patient_registration values('" + pid + "','" + pfname + "','" + psurname + "','" + paddress + "','" + pnic + "','" + pcontactno + "','" + pregistrationfee + "')", conn);

            cmd.ExecuteNonQuery();
        }
            catch (Exception ex)
            {
                var sqlException = ex.InnerException as System.Data.SqlClient.SqlException;

                if (sqlException.Number == 2601 || sqlException.Number == 2627)
                {
                }
                conn.Close();
            }
        }





        public void updatePatientInfo(Patient patient)
        {
            string pid = patient.getPatientID();
            string pfname = patient.getFirstName();
            string psurname = patient.getSurname();
            string paddress = patient.getAddress();
            string pnic = patient.getNIC();
            int pcontactno = patient.getContactNo();
            int pregistrationfee = patient.getRegistrationFee();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update patient_registration set patientid='" + pid + "',fname='" + pfname + "',surname='" + psurname + "',address='" + paddress + "',nic='" + pnic + "',contactno='" + pcontactno + "',registrationfee='" + pregistrationfee + "' where patientid='" + pid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }




        public Patient findPatient(string patientid)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from patient_registration where patientid='" + patientid + "'", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            Patient patient = null;

            while (rd.Read())
            {
                string pid = rd[0].ToString();
                string pfname = rd[1].ToString();
                string psurname = rd[2].ToString();
                string paddress = rd[3].ToString();
                string pnic = rd[4].ToString();
                int pcontactno = int.Parse(rd[5].ToString());
                int pregistrationfee = int.Parse(rd[6].ToString());

                patient = new Patient(pid, pfname, psurname, paddress, pnic, pcontactno, pregistrationfee);
            }
            conn.Close();
            return patient;
        }





        public void deletePatientInfo(Patient patient)
        {
            string pid = patient.getPatientID();
            string pfname = patient.getFirstName();
            string psurname = patient.getSurname();
            string paddress = patient.getAddress();
            string pnic = patient.getNIC();
            int pcontactno = patient.getContactNo();
            int pregistrationfee = patient.getRegistrationFee();

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from patient_registration where patientid='" + pid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }




     









    }



}
