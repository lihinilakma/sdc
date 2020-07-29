using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Appointment
    {

          //properties
        private string channelno;
        private string patientid;
        private string treatmenttype;
        private string problemdescription;
        private string doctorid;
        private string appointmentdate;
        private int count;

        //default constructor
        public Appointment()
        {
            this.channelno = null;
            this.patientid = null;
            this.treatmenttype = null;
            this.problemdescription = null;
            this.doctorid = null;
            this.appointmentdate = null;
            this.count = 0;
        }

        //parameterized constructor
        public Appointment(string ano, string apid, string atreatmenttype, string aproblemdescription, string adid, string aappointmentdate, int acount)
        {
            this.channelno = ano;
            this.patientid = apid;
            this.treatmenttype = atreatmenttype;
            this.problemdescription = aproblemdescription;
            this.doctorid = adid;
            this.appointmentdate = aappointmentdate;
            this.count = acount;
        }


        //create getter methods

        public string getChannelNO()
        {
            return this.channelno;
        }

        public string getPatientID()
        {
            return this.patientid;
        }

        public string getTreatmentType()
        {
            return this.treatmenttype;
        }

        public string getProblemDescription()
        {
            return this.problemdescription;
        }
        public string getDoctorID()
        {
            return this.doctorid;
        }
        public string getAppointmentDate()
        {
            return this.appointmentdate;
        }
        public int getCount()
        {
            return this.count;
        }



    }
}
