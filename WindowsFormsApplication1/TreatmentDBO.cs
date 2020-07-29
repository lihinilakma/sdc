using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class TreatmentDBO
    {


        SqlConnection conn = null;
        public TreatmentDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void treatmentInfo(Treatment treatment)
        {
            try{
                string tcode = treatment.getTreatmentCode();
                string ttype = treatment.getTreatmentType();
                string tdetails = treatment.getTreatmentDetails();
                string tdid = treatment.getDoctorID();
                string tpid = treatment.getPatientID();
                int tstdfee = treatment.getStandardFee();
                int tdocfee = treatment.getDoctorsCharge();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into dental_treatment values('" + tcode + "','" + ttype + "','" + tdetails + "','" + tdid + "','" + tpid + "','" + tstdfee + "','" + tdocfee + "')", conn);

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




        public void updateTreatmentInfo(Treatment treatment)
        {
            string tcode = treatment.getTreatmentCode();
            string ttype = treatment.getTreatmentType();
            string tdetails = treatment.getTreatmentDetails();
            string tdid = treatment.getDoctorID();
            string tpid = treatment.getPatientID();
            int tstdfee = treatment.getStandardFee();
            int tdocfee = treatment.getDoctorsCharge();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update dental_treatment set treatmentcode='" + tcode + "',treatmenttype='" + ttype + "',treatmentdetails='" + tdetails + "',doctorid='" + tdid + "',patientid='" + tpid + "',standardfee='" + tstdfee + "',doctorscharge='" + tdocfee + "' where treatmentcode='" + tcode + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }






        public void deleteTreatmentInfo(Treatment treatment)
        {
            string tcode = treatment.getTreatmentCode();
            string ttype = treatment.getTreatmentType();
            string tdetails = treatment.getTreatmentDetails();
            string tdid = treatment.getDoctorID();
            string tpid = treatment.getPatientID();
            int tstdfee = treatment.getStandardFee();
            int tdocfee = treatment.getDoctorsCharge();

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from dental_treatment where treatmentcode='" + tcode + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }



        public Treatment findCharges(string treatmentcode)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from dental_treatment where treatmentcode='" + treatmentcode + "'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            Treatment treatment = null;
            while (rd.Read())
            {
                string tcode = rd[0].ToString();
                string ttype = rd[1].ToString();
                string tdetails = rd[2].ToString();
                string tdid = rd[3].ToString();
                string tpid = rd[4].ToString();
                int tstdfee = int.Parse(rd[5].ToString());
                int tdocfee = int.Parse(rd[6].ToString());

                treatment = new Treatment(tcode, ttype, tdetails, tdid, tpid, tstdfee, tdocfee);
            }
            conn.Close();
            return treatment;

        }





        public Treatment findTreatment(string treatmentcode)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from dental_treatment where treatmentcode='" + treatmentcode + "'", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            Treatment treatment = null;

            while (rd.Read())
            {
                string tcode = rd[0].ToString();
                string ttype = rd[1].ToString();
                string tdetails = rd[2].ToString();
                string tdid = rd[3].ToString();
                string tpid = rd[4].ToString();
                int tstdfee = int.Parse(rd[5].ToString());
                int tdocfee = int.Parse(rd[6].ToString());

                treatment = new Treatment(tcode, ttype, tdetails, tdid, tpid, tstdfee, tdocfee);
            }
            conn.Close();
            return treatment;
     
        }















    }
}
