namespace WindowsFormsApplication1.CrystalReportsFolder
{
    partial class frmIncomeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncomeReport));
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.crystalReportViewer6 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReportIncomeReport3 = new WindowsFormsApplication1.CrystalReportsFolder.CrystalReportIncomeReport();
            this.CrystalReportIncomeReport2 = new WindowsFormsApplication1.CrystalReportsFolder.CrystalReportIncomeReport();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.CrystalReportIncomeReport1 = new WindowsFormsApplication1.CrystalReportsFolder.CrystalReportIncomeReport();
            this.SuspendLayout();
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDate.Image = global::WindowsFormsApplication1.Properties.Resources.search_icon_16;
            this.btnSearchDate.Location = new System.Drawing.Point(314, 8);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(89, 37);
            this.btnSearchDate.TabIndex = 1;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // crystalReportViewer6
            // 
            this.crystalReportViewer6.ActiveViewIndex = 0;
            this.crystalReportViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer6.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer6.Location = new System.Drawing.Point(12, 59);
            this.crystalReportViewer6.Name = "crystalReportViewer6";
            this.crystalReportViewer6.ReportSource = this.CrystalReportIncomeReport3;
            this.crystalReportViewer6.Size = new System.Drawing.Size(1061, 603);
            this.crystalReportViewer6.TabIndex = 2;
            this.crystalReportViewer6.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer6.Load += new System.EventHandler(this.crystalReportViewer6_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(60, 16);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(244, 22);
            this.txtAppointmentDate.TabIndex = 0;
            // 
            // frmIncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1085, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAppointmentDate);
            this.Controls.Add(this.crystalReportViewer6);
            this.Controls.Add(this.btnSearchDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncomeReport";
            this.Text = "Report - Daily Income Report";
            this.Load += new System.EventHandler(this.frmIncomeReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtAppointmentDate;
        private CrystalReportIncomeReport CrystalReportIncomeReport2;
        private CrystalReportIncomeReport CrystalReportIncomeReport1;
        private CrystalReportIncomeReport CrystalReportIncomeReport3;
    }
}