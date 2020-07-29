using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Payment
    {

          //properties
        private string invoiceno;
        private string treatmentcode;
        private string patientid;
        private string paymentmode;
        private int doctorscharge;
        private int treatmentfee;
        private int totalcharge;
        private int registrationfee;

        //default constructor
        public Payment()
        {
            this.invoiceno = null;
            this.treatmentcode = null;
            this.patientid = null;
            this.paymentmode = null;
            this.doctorscharge = 0;
            this.treatmentfee = 0;
            this.totalcharge = 0;
            this.registrationfee = 0;
        }

        //parameterized constructor
        public Payment(string pno, string ptcode, string ppid, string ppaymentmode, int pdoctorscharge, int ptreatmentfee, int ptotalcharge, int pregistrationfee)
        {
            this.invoiceno = pno;
            this.treatmentcode = ptcode;
            this.patientid = ppid;
            this.paymentmode = ppaymentmode;
            this.doctorscharge = pdoctorscharge;
            this.treatmentfee = ptreatmentfee;
            this.totalcharge = ptotalcharge;
            this.registrationfee = pregistrationfee;
        }


        //create getter methods

        public string getInvoiceNO()
        {
            return this.invoiceno;
        }

        public string getTreatmentCode()
        {
            return this.treatmentcode;
        }

        public string getPatientID()
        {
            return this.patientid;
        }

        public string getPaymentMode()
        {
            return this.paymentmode;
        }
        public int getDoctorsCharge()
        {
            return this.doctorscharge;
        }
        public int getStandardFee()
        {
            return this.treatmentfee;
        }
        public int getTotalCharge()
        {
            return this.totalcharge;
        }
        public int getRegistrationFee()
        {
            return this.registrationfee;
        }


    }
}
