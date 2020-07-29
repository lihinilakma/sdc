using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Treatment
    {

        //properties
        private string treatmentcode;
        private string treatmenttype;
        private string treatmentdetails;
        private string doctorid;
        private string patientid;
        private int standardfee;
        private int doctorscharge;

        //default constructor
        public Treatment()
        {
            this.treatmentcode = null;
            this.treatmenttype = null;
            this.treatmentdetails = null;
            this.doctorid = null;
            this.patientid = null;
            this.standardfee = 0;
            this.doctorscharge = 0;
        }

        //parameterized constructor
        public Treatment(string tcode, string ttype, string tdetails, string tdid, string tpid, int tstdfee, int tdocfee)
        {
            this.treatmentcode = tcode;
            this.treatmenttype = ttype;
            this.treatmentdetails = tdetails;
            this.doctorid = tdid;
            this.patientid = tpid;
            this.standardfee = tstdfee;
            this.doctorscharge = tdocfee;
        }


        //create getter methods

        public string getTreatmentCode()
        {
            return this.treatmentcode;
        }

        public string getTreatmentType()
        {
            return this.treatmenttype;
        }

        public string getTreatmentDetails()
        {
            return this.treatmentdetails;
        }

        public string getDoctorID()
        {
            return this.doctorid;
        }
        public string getPatientID()
        {
            return this.patientid;
        }
        public int getStandardFee()
        {
            return this.standardfee;
        }
        public int getDoctorsCharge()
        {
            return this.doctorscharge;
        }





    }
}
