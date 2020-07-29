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
    public partial class frmIncomeReport : Form
    {
        public frmIncomeReport()
        {
            InitializeComponent();
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            CrystalReportIncomeReport cr = new CrystalReportIncomeReport();
            SqlConnection conn = new SqlConnection();
            conn = DbConnection.getConnection();


            string appointmentdate = txtAppointmentDate.Value.ToString("dd MMM yyyy");


            conn.Open();
            string sql = "select * from IncomeReport2 where appointmentdate='" + appointmentdate + "'";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "IncomeReport2");
            DataTable dt = ds.Tables["IncomeReport2"];

            cr.SetDataSource(ds.Tables["IncomeReport2"]);
            crystalReportViewer6.ReportSource = cr;
            crystalReportViewer6.Refresh();
            conn.Close();




        }

        private void frmIncomeReport_Load(object sender, EventArgs e)
        {
            this.btnSearchDate.Image = WindowsFormsApplication1.Properties.Resources.search_icon_16;

            CrystalReportIncomeReport cr = new CrystalReportIncomeReport();
            SqlConnection conn = new SqlConnection();
            conn = DbConnection.getConnection();


            conn.Open();
            string sql = "select * from IncomeReport2";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "IncomeReport2");
            DataTable dt = ds.Tables["IncomeReport2"];

            cr.SetDataSource(ds.Tables["IncomeReport2"]);
            crystalReportViewer6.ReportSource = cr;
            crystalReportViewer6.Refresh();
            conn.Close();



        }

        private void crystalReportViewer6_Load(object sender, EventArgs e)
        {

        }
    }
}
