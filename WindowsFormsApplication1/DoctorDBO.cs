using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DoctorDBO
    {


         SqlConnection conn = null;
        public DoctorDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void doctorInfo(Doctor doctor)
        {
            try{
                string did = doctor.getDoctorID();
                string dfname = doctor.getFirstName();
                string dsurname = doctor.getSurname();
                string daddress = doctor.getAddress();
                string ddob = doctor.getDOB();
                string dnic = doctor.getNIC();
                int dcontactno = doctor.getContactNo();
                int dexperience = doctor.getExperience();
                string dspeciality = doctor.getSpeciality();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into doctor_registration values('" + did + "','" + dfname + "','" + dsurname + "','" + daddress + "','" + ddob + "','" + dnic + "','" + dcontactno + "','" + dexperience + "','" + dspeciality + "')", conn);

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





        public void updateDoctorInfo(Doctor doctor)
        {
            string did = doctor.getDoctorID();
            string dfname = doctor.getFirstName();
            string dsurname = doctor.getSurname();
            string daddress = doctor.getAddress();
            string ddob = doctor.getDOB();
            string dnic = doctor.getNIC();
            int dcontactno = doctor.getContactNo();
            int dexperience = doctor.getExperience();
            string dspeciality = doctor.getSpeciality();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update doctor_registration set doctorid='" + did + "',fname='" + dfname + "',surname='" + dsurname + "',address='" + daddress + "',dob='" + ddob + "',nic='" + dnic + "',contactno='" + dcontactno + "',experience='" + dexperience + "',speciality='" + dspeciality + "' where doctorid='" + did + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }





        public Doctor findDoctor(string doctorid)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from doctor_registration where doctorid='" + doctorid + "'", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            Doctor doctor = null;

            while (rd.Read())
            {
                string did = rd[0].ToString();
                string dfname = rd[1].ToString();
                string dsurname = rd[2].ToString();
                string daddress = rd[3].ToString();
                string ddob = rd[4].ToString();
                string dnic = rd[5].ToString();
                int dcontactno = int.Parse(rd[6].ToString());
                int dexperience = int.Parse(rd[7].ToString());
                string dspeciality = rd[8].ToString();



                doctor = new Doctor(did, dfname, dsurname, daddress, ddob, dnic, dcontactno, dexperience, dspeciality);
            }
            conn.Close();
            return doctor;
        }




        public void deleteDoctorInfo(Doctor doctor)
        {
            string did = doctor.getDoctorID();
            string dfname = doctor.getFirstName();
            string dsurname = doctor.getSurname();
            string daddress = doctor.getAddress();
            string ddob = doctor.getDOB();
            string dnic = doctor.getNIC();
            int dcontactno = doctor.getContactNo();
            int dexperience = doctor.getExperience();
            string dspeciality = doctor.getSpeciality();

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from doctor_registration where doctorid='" + did + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }






    }
}
