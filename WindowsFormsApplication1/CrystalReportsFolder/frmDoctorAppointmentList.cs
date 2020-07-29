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

namespace WindowsFormsApplication1.CrystalReportsFolder
{
    public partial class frmDoctorAppointmentList : Form
    {
        public frmDoctorAppointmentList()
        {
            InitializeComponent();
        }

        private void frmDoctorAppointmentList_Load(object sender, EventArgs e)
        {
            this.btnSearchDoctorAppointmentList.Image = WindowsFormsApplication1.Properties.Resources.search_icon_16;
            CrystalReportDoctorAppointmentList cr = new CrystalReportDoctorAppointmentList();
            SqlConnection conn = new SqlConnection();
            conn = DbConnection.getConnection();

            conn.Open();
            string sql = "select * from DoctorAppointmentList";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "DoctorAppointmentList");
            DataTable dt = ds.Tables["DoctorAppointmentList"];

            cr.SetDataSource(ds.Tables["DoctorAppointmentList"]);
            crystalReportViewer3.ReportSource = cr;
            crystalReportViewer3.Refresh();
            conn.Close();
        }

        private void btnSearchDoctorAppointmentList_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtDoctorID.Text))
            {
                CrystalReportDoctorAppointmentList cr = new CrystalReportDoctorAppointmentList();
                SqlConnection conn = new SqlConnection();
                conn = DbConnection.getConnection();

                string appointmentdate = txtAppointmentDate.Value.ToString("dd MMM yyyy");

                conn.Open();
                string sql = "select * from DoctorAppointmentList where appointmentdate='" + appointmentdate + "'";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.Fill(ds, "DoctorAppointmentList");
                DataTable dt = ds.Tables["DoctorAppointmentList"];

                cr.SetDataSource(ds.Tables["DoctorAppointmentList"]);
                crystalReportViewer3.ReportSource = cr;
                crystalReportViewer3.Refresh();
                conn.Close();


            }
            else
            {
                CrystalReportDoctorAppointmentList cr = new CrystalReportDoctorAppointmentList();
                SqlConnection conn = new SqlConnection();
                conn = DbConnection.getConnection();

                string did = txtDoctorID.Text;
                string appointmentdate = txtAppointmentDate.Value.ToString("dd MMM yyyy");

                conn.Open();
                string sql = "select * from DoctorAppointmentList where doctorid='" + did + "' and appointmentdate='" + appointmentdate + "'";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.Fill(ds, "DoctorAppointmentList");
                DataTable dt = ds.Tables["DoctorAppointmentList"];

                cr.SetDataSource(ds.Tables["DoctorAppointmentList"]);
                crystalReportViewer3.ReportSource = cr;
                crystalReportViewer3.Refresh();
                conn.Close();
            }
        }

        private void txtDoctorID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string doctorid = txtDoctorID.Text;
                DoctorDBO ddbo = new DoctorDBO();
                Doctor doctor = ddbo.findDoctor(doctorid);
                lblDoctorName.ForeColor = Color.Black;
                lblDoctorName.Text = "DR. " + doctor.getFirstName() + " " + doctor.getSurname();
            }
            catch
            {
                lblDoctorName.ForeColor = Color.Red;
                lblDoctorName.Text = "Invalid Doctor ID";

            }
        }
    }
}
