namespace WindowsFormsApplication1
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.labelefgr = new System.Windows.Forms.Label();
            this.menuStrip1765tg = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerateCustomerInvoice = new System.Windows.Forms.Button();
            this.btnDoctorAppointmentList = new System.Windows.Forms.Button();
            this.btnPatientTreatmentHistory = new System.Windows.Forms.Button();
            this.pictureBox2sdfs = new System.Windows.Forms.PictureBox();
            this.menuStrip1765tg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2sdfs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelefgr
            // 
            this.labelefgr.AutoSize = true;
            this.labelefgr.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelefgr.Location = new System.Drawing.Point(30, 58);
            this.labelefgr.Name = "labelefgr";
            this.labelefgr.Size = new System.Drawing.Size(235, 32);
            this.labelefgr.TabIndex = 79;
            this.labelefgr.Text = "Generate Reports";
            // 
            // menuStrip1765tg
            // 
            this.menuStrip1765tg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitApplicationToolStripMenuItem,
            this.exitApplicationToolStripMenuItem1});
            this.menuStrip1765tg.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1765tg.Name = "menuStrip1765tg";
            this.menuStrip1765tg.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1765tg.Size = new System.Drawing.Size(706, 26);
            this.menuStrip1765tg.Stretch = false;
            this.menuStrip1765tg.TabIndex = 82;
            this.menuStrip1765tg.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.exitToolStripMenuItem.Text = "New";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.exitApplicationToolStripMenuItem.Text = "Log Out";
            // 
            // exitApplicationToolStripMenuItem1
            // 
            this.exitApplicationToolStripMenuItem1.Name = "exitApplicationToolStripMenuItem1";
            this.exitApplicationToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.exitApplicationToolStripMenuItem1.Text = "Exit Application";
            // 
            // btnGenerateCustomerInvoice
            // 
            this.btnGenerateCustomerInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateCustomerInvoice.BackColor = System.Drawing.Color.Goldenrod;
            this.btnGenerateCustomerInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Bold);
            this.btnGenerateCustomerInvoice.Image = global::WindowsFormsApplication1.Properties.Resources.cash_register1;
            this.btnGenerateCustomerInvoice.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerateCustomerInvoice.Location = new System.Drawing.Point(516, 121);
            this.btnGenerateCustomerInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateCustomerInvoice.Name = "btnGenerateCustomerInvoice";
            this.btnGenerateCustomerInvoice.Size = new System.Drawing.Size(147, 179);
            this.btnGenerateCustomerInvoice.TabIndex = 91;
            this.btnGenerateCustomerInvoice.Text = "Generate Customer Invoice";
            this.btnGenerateCustomerInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateCustomerInvoice.UseVisualStyleBackColor = false;
            this.btnGenerateCustomerInvoice.Click += new System.EventHandler(this.btnGenerateCustomerInvoice_Click);
            // 
            // btnDoctorAppointmentList
            // 
            this.btnDoctorAppointmentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoctorAppointmentList.BackColor = System.Drawing.Color.Khaki;
            this.btnDoctorAppointmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Bold);
            this.btnDoctorAppointmentList.Image = global::WindowsFormsApplication1.Properties.Resources.People_Doctor_Male_icon2;
            this.btnDoctorAppointmentList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDoctorAppointmentList.Location = new System.Drawing.Point(44, 121);
            this.btnDoctorAppointmentList.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctorAppointmentList.Name = "btnDoctorAppointmentList";
            this.btnDoctorAppointmentList.Size = new System.Drawing.Size(147, 179);
            this.btnDoctorAppointmentList.TabIndex = 90;
            this.btnDoctorAppointmentList.Text = "Doctor\'s Appointment List";
            this.btnDoctorAppointmentList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoctorAppointmentList.UseVisualStyleBackColor = false;
            this.btnDoctorAppointmentList.Click += new System.EventHandler(this.btnDoctorAppointmentList_Click_2);
            // 
            // btnPatientTreatmentHistory
            // 
            this.btnPatientTreatmentHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatientTreatmentHistory.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPatientTreatmentHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Bold);
            this.btnPatientTreatmentHistory.Image = global::WindowsFormsApplication1.Properties.Resources.Patients_icon;
            this.btnPatientTreatmentHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPatientTreatmentHistory.Location = new System.Drawing.Point(280, 121);
            this.btnPatientTreatmentHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatientTreatmentHistory.Name = "btnPatientTreatmentHistory";
            this.btnPatientTreatmentHistory.Size = new System.Drawing.Size(147, 179);
            this.btnPatientTreatmentHistory.TabIndex = 89;
            this.btnPatientTreatmentHistory.Text = "Patient\'s Treatment History";
            this.btnPatientTreatmentHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPatientTreatmentHistory.UseVisualStyleBackColor = false;
            this.btnPatientTreatmentHistory.Click += new System.EventHandler(this.btnPatientTreatmentHistory_Click_2);
            // 
            // pictureBox2sdfs
            // 
            this.pictureBox2sdfs.Image = global::WindowsFormsApplication1.Properties.Resources.logo_copy;
            this.pictureBox2sdfs.Location = new System.Drawing.Point(842, 117);
            this.pictureBox2sdfs.Name = "pictureBox2sdfs";
            this.pictureBox2sdfs.Size = new System.Drawing.Size(287, 89);
            this.pictureBox2sdfs.TabIndex = 81;
            this.pictureBox2sdfs.TabStop = false;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 748);
            this.Controls.Add(this.btnGenerateCustomerInvoice);
            this.Controls.Add(this.btnDoctorAppointmentList);
            this.Controls.Add(this.btnPatientTreatmentHistory);
            this.Controls.Add(this.menuStrip1765tg);
            this.Controls.Add(this.pictureBox2sdfs);
            this.Controls.Add(this.labelefgr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReports";
            this.Text = "Generate Reports";
            this.menuStrip1765tg.ResumeLayout(false);
            this.menuStrip1765tg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2sdfs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2sdfs;
        private System.Windows.Forms.Label labelefgr;
        private System.Windows.Forms.MenuStrip menuStrip1765tg;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.Button btnGenerateCustomerInvoice;
        private System.Windows.Forms.Button btnDoctorAppointmentList;
        private System.Windows.Forms.Button btnPatientTreatmentHistory;
    }
}