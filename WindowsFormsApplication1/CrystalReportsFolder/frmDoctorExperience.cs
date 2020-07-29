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
    public partial class frmDoctorExperience : Form
    {
        public frmDoctorExperience()
        {
            InitializeComponent();
        }

        private void frmDoctorExperience_Load(object sender, EventArgs e)
        {


            CrystalReportDoctorExperience cr = new CrystalReportDoctorExperience();
            SqlConnection conn = new SqlConnection();
            conn = DbConnection.getConnection();

            conn.Open();
            string sql = "select * from doctorexperience order by experience desc";

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            adapter.Fill(ds, "doctorexperience");
            DataTable dt = ds.Tables["doctorexperience"];

            cr.SetDataSource(ds.Tables["doctorexperience"]);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            conn.Close();
        }
    }
}
