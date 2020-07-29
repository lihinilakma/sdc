using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Doctor
    {
            //properties
            private string doctorid;
            private string fname;
            private string surname;
            private string address;
            private string dob;
            private string nic;
            private int contactno;
            private int experience;
            private string speciality;

            //default constructor
            public Doctor()
            {
                this.doctorid = null;
                this.fname = null;
                this.surname = null;
                this.address = null;
                this.dob = null;
                this.nic = null;
                this.contactno = 0;
                this.experience = 0;
                this.speciality = null;
            }

            //parameterized constructor
            public Doctor(string did, string dfname, string dsurname, string daddress, string ddob, string dnic, int dcontactno, int dexperience, string dspeciality)
            {
                this.doctorid = did;
                this.fname = dfname;
                this.surname = dsurname;
                this.address = daddress;
                this.dob = ddob;
                this.nic = dnic;
                this.contactno = dcontactno;
                this.experience = dexperience;
                this.speciality = dspeciality;
            }


            //create getter methods

            public string getDoctorID()
            {
                return this.doctorid;
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
            public string getDOB()
            {
                return this.dob;
            }
            public string getNIC()
            {
                return this.nic;
            }
            public int getContactNo()
            {
                return this.contactno;
            }
            public int getExperience()
            {
                return this.experience;
            }
            public string getSpeciality()
            {
                return this.speciality;
            }


    }
}
