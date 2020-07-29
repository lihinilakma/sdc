using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.CrystalReportsFolder;


namespace WindowsFormsApplication1
{
    public partial class frmPatientTreatmentHistory : Form
    {
        public frmPatientTreatmentHistory()
        {
            InitializeComponent();
        }

        private void frmPatientTreatmentHistory_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
 

        }

        private void btnSearchPatient_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientID.Text))
            {
                CrystalReportPatientTreatmentHistory cr = new CrystalReportPatientTreatmentHistory();
                SqlConnection conn = new SqlConnection();
                conn = DbConnection.getConnection();

                conn.Open();
                string sql = "select * from patienttreatmenthistory";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.Fill(ds, "PatientTreatmentHistory");
                DataTable dt = ds.Tables["PatientTreatmentHistory"];

                cr.SetDataSource(ds.Tables["PatientTreatmentHistory"]);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
                conn.Close();
            }
            else
            {

                CrystalReportPatientTreatmentHistory cr = new CrystalReportPatientTreatmentHistory();
                SqlConnection conn = new SqlConnection();
                conn = DbConnection.getConnection();

                string pid = txtPatientID.Text;

                conn.Open();
                string sql = "select * from patienttreatmenthistory where patientid='" + pid + "'";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.Fill(ds, "PatientTreatmentHistory");
                DataTable dt = ds.Tables["PatientTreatmentHistory"];

                cr.SetDataSource(ds.Tables["PatientTreatmentHistory"]);
                crystalReportViewer1.ReportSource = cr;
                crystalReportViewer1.Refresh();
                conn.Close();
            }
        }

        private void frmPatientTreatmentHistory_Load_1(object sender, EventArgs e)
        {
            this.btnSearchPatient.Image = WindowsFormsApplication1.Properties.Resources.search_icon_16;
            CrystalReportPatientTreatmentHistory cr = new CrystalReportPatientTreatmentHistory();
            SqlConnection conn = new SqlConnection();
            conn = DbConnection.getConnection();

            conn.Open();
            string sql = "select * from patienttreatmenthistory";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "PatientTreatmentHistory");
            DataTable dt = ds.Tables["PatientTreatmentHistory"];

            cr.SetDataSource(ds.Tables["PatientTreatmentHistory"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();
        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string patientid = txtPatientID.Text;
                PatientDBO pdbo = new PatientDBO();
                Patient patient = pdbo.findPatient(patientid);
                lblPatientName.ForeColor = Color.Black;
                lblPatientName.Text = patient.getFirstName() + " " + patient.getSurname();
            }
            catch
            {
                lblPatientName.ForeColor = Color.Red;
                lblPatientName.Text = "Invalid Patient ID";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
