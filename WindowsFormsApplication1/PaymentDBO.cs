using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class PaymentDBO
    {

        
        SqlConnection conn = null;
        public PaymentDBO()
        {
            conn= DbConnection.getConnection();
        }

        public void paymentInfo(Payment payment)
        {
            try{
                string pno = payment.getInvoiceNO();
                string ptcode = payment.getTreatmentCode();
                string ppid = payment.getPatientID();
                string ppaymentmode = payment.getPaymentMode();
                int pdoctorscharge = payment.getDoctorsCharge();
                int ptreatmentfee = payment.getStandardFee();
                int ptotalcharge = payment.getTotalCharge();
                int pregistrationfee = payment.getRegistrationFee();

            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into payment values('" + pno + "','" + ptcode + "','" + ppid + "','" + ppaymentmode + "','" + pdoctorscharge + "','" + ptreatmentfee + "','" + ptotalcharge + "','" + pregistrationfee + "')", conn);

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






        public void updatePaymentInfo(Payment payment)
        {
            string pno = payment.getInvoiceNO();
            string ptcode = payment.getTreatmentCode();
            string ppid = payment.getPatientID();
            string ppaymentmode = payment.getPaymentMode();
            int pdoctorscharge = payment.getDoctorsCharge();
            int ptreatmentfee = payment.getStandardFee();
            int ptotalcharge = payment.getTotalCharge();
            int pregistrationfee = payment.getRegistrationFee();

            conn.Open();

            SqlCommand cmd = new SqlCommand("update payment set invoiceno='" + pno + "',treatmentcode='" + ptcode + "',patientid='" + ppid + "',paymentmode='" + ppaymentmode + "',doctorscharge='" + pdoctorscharge + "',treatmentfee='" + ptreatmentfee + "',totalcharge='" + ptotalcharge + "',registrationfee='" + pregistrationfee + "' where invoiceno='" + pno + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }





        public void deletePaymentInfo(Payment payment)
        {
            string pno = payment.getInvoiceNO();
            string ptcode = payment.getTreatmentCode();
            string ppid = payment.getPatientID();
            string ppaymentmode = payment.getPaymentMode();
            int pdoctorscharge = payment.getDoctorsCharge();
            int ptreatmentfee = payment.getStandardFee();
            int ptotalcharge = payment.getTotalCharge();
            int pregistrationfee = payment.getRegistrationFee();

            conn.Open();

            SqlCommand cmd = new SqlCommand("delete from payment where invoiceno='" + pno + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }




    }
}
