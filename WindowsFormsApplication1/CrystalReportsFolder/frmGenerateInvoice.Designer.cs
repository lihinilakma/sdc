namespace WindowsFormsApplication1.CrystalReportsFolder
{
    partial class frmGenerateInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateInvoice));
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = -1;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer4.Location = new System.Drawing.Point(20, 76);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.Size = new System.Drawing.Size(1044, 514);
            this.crystalReportViewer4.TabIndex = 13;
            this.crystalReportViewer4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer4.Load += new System.EventHandler(this.crystalReportViewer4_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Invoice Ref No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInvoiceNo.ForeColor = System.Drawing.Color.Red;
            this.txtInvoiceNo.Location = new System.Drawing.Point(120, 32);
            this.txtInvoiceNo.MaxLength = 5;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(100, 22);
            this.txtInvoiceNo.TabIndex = 0;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchInvoice.Image = global::WindowsFormsApplication1.Properties.Resources.search_icon_16;
            this.btnSearchInvoice.Location = new System.Drawing.Point(226, 25);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(85, 36);
            this.btnSearchInvoice.TabIndex = 1;
            this.btnSearchInvoice.Text = "Search";
            this.btnSearchInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // frmGenerateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1085, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.btnSearchInvoice);
            this.Controls.Add(this.crystalReportViewer4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGenerateInvoice";
            this.Text = "Report - Generate Invoice";
            this.Load += new System.EventHandler(this.frmGenerateInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Button btnSearchInvoice;
    }
}