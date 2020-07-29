namespace WindowsFormsApplication1.CrystalReportsFolder
{
    partial class frmDoctorAppointmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorAppointmentList));
            this.ddf = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.btnSearchDoctorAppointmentList = new System.Windows.Forms.Button();
            this.txtAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddf
            // 
            this.ddf.AutoSize = true;
            this.ddf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddf.Location = new System.Drawing.Point(26, 15);
            this.ddf.Name = "ddf";
            this.ddf.Size = new System.Drawing.Size(71, 17);
            this.ddf.TabIndex = 9;
            this.ddf.Text = "Doctor ID:";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoctorID.ForeColor = System.Drawing.Color.Red;
            this.txtDoctorID.Location = new System.Drawing.Point(153, 12);
            this.txtDoctorID.MaxLength = 5;
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(100, 22);
            this.txtDoctorID.TabIndex = 0;
            this.txtDoctorID.TextChanged += new System.EventHandler(this.txtDoctorID_TextChanged);
            // 
            // btnSearchDoctorAppointmentList
            // 
            this.btnSearchDoctorAppointmentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDoctorAppointmentList.Image = global::WindowsFormsApplication1.Properties.Resources.search_icon_16;
            this.btnSearchDoctorAppointmentList.Location = new System.Drawing.Point(153, 80);
            this.btnSearchDoctorAppointmentList.Name = "btnSearchDoctorAppointmentList";
            this.btnSearchDoctorAppointmentList.Size = new System.Drawing.Size(80, 33);
            this.btnSearchDoctorAppointmentList.TabIndex = 2;
            this.btnSearchDoctorAppointmentList.Text = "Search";
            this.btnSearchDoctorAppointmentList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchDoctorAppointmentList.UseVisualStyleBackColor = true;
            this.btnSearchDoctorAppointmentList.Click += new System.EventHandler(this.btnSearchDoctorAppointmentList_Click);
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(153, 46);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(293, 22);
            this.txtAppointmentDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Appointment Date:";
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Location = new System.Drawing.Point(29, 119);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.Size = new System.Drawing.Size(1044, 535);
            this.crystalReportViewer3.TabIndex = 12;
            this.crystalReportViewer3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(259, 15);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(187, 17);
            this.lblDoctorName.TabIndex = 13;
            this.lblDoctorName.Text = "***Doctor Name Displayed***";
            // 
            // frmDoctorAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1085, 666);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.crystalReportViewer3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAppointmentDate);
            this.Controls.Add(this.ddf);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.btnSearchDoctorAppointmentList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoctorAppointmentList";
            this.Text = "Report - Doctor Appointment List";
            this.Load += new System.EventHandler(this.frmDoctorAppointmentList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ddf;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Button btnSearchDoctorAppointmentList;
        private System.Windows.Forms.DateTimePicker txtAppointmentDate;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private System.Windows.Forms.Label lblDoctorName;
    }
}