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
    public partial class frmGenerateInvoice : Form
    {
        public frmGenerateInvoice()
        {
            InitializeComponent();
        }

        private void frmGenerateInvoice_Load(object sender, EventArgs e)
        {
            this.btnSearchInvoice.Image = WindowsFormsApplication1.Properties.Resources.search_icon_16;
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtInvoiceNo.Text))
            {
                MessageBox.Show("The invoice number should be entered.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                CrystalReportGenerateInvoice cr = new CrystalReportGenerateInvoice();
                SqlConnection conn = new SqlConnection();
                conn = DbConnection.getConnection();

                string pino = txtInvoiceNo.Text;

                conn.Open();
                string sql = "select * from generateinvoice where invoiceno='" + pino + "'";

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.Fill(ds, "generateinvoice");
                DataTable dt = ds.Tables["generateinvoice"];

                cr.SetDataSource(ds.Tables["generateinvoice"]);
                crystalReportViewer4.ReportSource = cr;
                crystalReportViewer4.Refresh();
                conn.Close();
            
        }
        }

        private void crystalReportViewer4_Load(object sender, EventArgs e)
        {

        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
