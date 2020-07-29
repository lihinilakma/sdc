using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class AppointmentDBO
    {




          SqlConnection conn = null;
        public AppointmentDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void appointmentInfo(Appointment appointment1)
        {
            try{
                string ano = appointment1.getChannelNO();
                string apid = appointment1.getPatientID();
                string atreatmenttype = appointment1.getTreatmentType();
                string aproblemdescription = appointment1.getProblemDescription();
                string adid = appointment1.getDoctorID();
                string aappointmentdate = appointment1.getAppointmentDate();
                int acount = appointment1.getCount();

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into schedule_appointment values('" + ano + "','" + apid + "','" + atreatmenttype + "','" + aproblemdescription + "','" + adid + "','" + aappointmentdate + "','" + acount + "')", conn);
            cmd.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("update schedule_appointment set count=(select count (channelno) from schedule_appointment where doctorid='" + adid + "' and appointmentdate ='" + aappointmentdate + "') where doctorid='" + adid + "' and appointmentdate='" + aappointmentdate + "'", conn);
            cmd2.ExecuteNonQuery();

                //update schedule_appointment set count='6' where doctorid='DR001' and appointmentdate= '15 Aug 2019'; ---   where channelno='" + ano + "'


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




        public void updateAppointmentInfo(Appointment appointment)
        {
            string ano = appointment.getChannelNO();
            string apid = appointment.getPatientID();
            string atreatmenttype = appointment.getTreatmentType();
            string aproblemdescription = appointment.getProblemDescription();
            string adid = appointment.getDoctorID();
            string aappointmentdate = appointment.getAppointmentDate();
            int acount = appointment.getCount();

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("update schedule_appointment set count=(select count (channelno) from schedule_appointment where doctorid='" + adid + "' and appointmentdate ='" + aappointmentdate + "') where doctorid='" + adid + "' and appointmentdate= '" + aappointmentdate + "'", conn);
            cmd1.ExecuteNonQuery();


            SqlCommand cmd2 = new SqlCommand("update schedule_appointment set count=(select count (channelno) from schedule_appointment where doctorid='" + adid + "' and appointmentdate ='" + aappointmentdate + "') where doctorid='" + adid + "' and appointmentdate='" + aappointmentdate + "'", conn);
            cmd2.ExecuteNonQuery();


            SqlCommand cmd3 = new SqlCommand("update schedule_appointment set channelno='" + ano + "',patientid='" + apid + "',treatmenttype='" + atreatmenttype + "',problemdescription='" + aproblemdescription + "',doctorid='" + adid + "',appointmentdate='" + aappointmentdate + "',count='" + acount + "' where channelno='" + ano + "'", conn);
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand("update schedule_appointment set count=(select count (channelno) from schedule_appointment where doctorid='" + adid + "' and appointmentdate ='" + aappointmentdate + "') where doctorid='" + adid + "' and appointmentdate= '" + aappointmentdate + "'", conn);
            cmd4.ExecuteNonQuery();








            conn.Close();
        }





        public void deleteAppointmentInfo(Appointment appointment)
        {
            string ano = appointment.getChannelNO();
            string apid = appointment.getPatientID();
            string atreatmenttype = appointment.getTreatmentType();
            string aproblemdescription = appointment.getProblemDescription();
            string adid = appointment.getDoctorID();
            string aappointmentdate = appointment.getAppointmentDate();
            int acount = appointment.getCount();

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from schedule_appointment where channelno='" + ano + "'", conn);

            cmd.ExecuteNonQuery();


            SqlCommand cmd2 = new SqlCommand("update schedule_appointment set count=(select count (channelno) from schedule_appointment where doctorid='" + adid + "' and appointmentdate ='" + aappointmentdate + "') where doctorid='" + adid + "' and appointmentdate='" + aappointmentdate + "'", conn);
            cmd2.ExecuteNonQuery();





            conn.Close();
        }




        public Appointment findAppointment(string patientid, string appointmentdate)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from schedule_appointment where patientid='" + patientid + "'", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            Appointment appointment = null;

            while (rd.Read())
            {
                string ano = rd[0].ToString();
                string apid = rd[1].ToString();
                string atreatmenttype = rd[2].ToString();
                string aproblemdescription = rd[3].ToString();
                string adid = rd[4].ToString();
                string aappointmentdate = rd[5].ToString();
                int acount = int.Parse(rd[6].ToString());

                appointment = new Appointment(ano, apid, atreatmenttype, aproblemdescription, adid, aappointmentdate, acount);
            }
            conn.Close();
            return appointment;
        }


        public Appointment findCount(string doctorid3, string appointmentdate3)
        {

            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from schedule_appointment where appointmentdate='" + appointmentdate3 + "' and doctorid='" + doctorid3 + "'", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            Appointment appointment3 = null;

            while (rd.Read())
            {
                string ano = rd[0].ToString();
                string apid = rd[1].ToString();
                string atreatmenttype = rd[2].ToString();
                string aproblemdescription = rd[3].ToString();
                string adid = rd[4].ToString();
                string aappointmentdate = rd[5].ToString();
                int acount = int.Parse(rd[6].ToString());

                appointment3 = new Appointment(ano, apid, atreatmenttype, aproblemdescription, adid, aappointmentdate, acount);
            }
            conn.Close();
            return appointment3;
        }














    }
}
