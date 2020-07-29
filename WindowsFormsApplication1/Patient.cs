using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Patient
    {
        //properties
        private string patientid;
        private string fname;
        private string surname;
        private string address;
        private string nic;
        private int contactno;
        private int registrationfee;

        //default constructor
        public Patient()
        {
            this.patientid = null;
            this.fname = null;
            this.surname = null;
            this.address = null;
            this.nic = null;
            this.contactno = 0;
            this.registrationfee = 0;
        }

        //parameterized constructor
        public Patient(string pid, string pfname, string psurname, string paddress, string pnic, int pcontactno, int pregistrationfee)
        {
            this.patientid = pid;
            this.fname = pfname;
            this.surname = psurname;
            this.address = paddress;
            this.nic = pnic;
            this.contactno = pcontactno;
            this.registrationfee = pregistrationfee;
        }


        //create getter methods

        public string getPatientID()
        {
            return this.patientid;
        }

        public string getFirstName()
        {
            return this.fname;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public string getAddress()
        {
            return this.address;
        }
        public string getNIC()
        {
            return this.nic;
        }
        public int getContactNo()
        {
            return this.contactno;
        }
        public int getRegistrationFee()
        {
            return this.registrationfee;
        }
    }

}
