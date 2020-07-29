namespace WindowsFormsApplication1
{
    partial class frmScheduleAppointment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleAppointment));
            this.menuStrip1765 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnScheduleAppointmentDelete = new System.Windows.Forms.Button();
            this.btnScheduleAppointmentSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScheduleAppointmentProblemDescription = new System.Windows.Forms.RichTextBox();
            this.btnScheduleAppointmentSearchPatient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScheduleAppointmentChannelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScheduleAppointmentDoctorName = new System.Windows.Forms.Label();
            this.txtScheduleAppointmentDoctorID = new System.Windows.Forms.TextBox();
            this.lblScheduleAppointmentPatientName = new System.Windows.Forms.Label();
            this.txtScheduleAppointmentPatientID = new System.Windows.Forms.TextBox();
            this.txtScheduleAppointmentTreatmentType = new System.Windows.Forms.ComboBox();
            this.txtScheduleAppointmentAppointmentDate = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnScheduleAppointmentUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentGridViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApplication1.DataSet2();
            this.scheduleappointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientregistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApplication1.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentGridViewTableAdapter = new WindowsFormsApplication1.DataSet2TableAdapters.AppointmentGridViewTableAdapter();
            this.menuStrip1765.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleappointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientregistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1765
            // 
            this.menuStrip1765.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitApplicationToolStripMenuItem,
            this.exitApplicationToolStripMenuItem1});
            this.menuStrip1765.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1765.Name = "menuStrip1765";
            this.menuStrip1765.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1765.Size = new System.Drawing.Size(1370, 26);
            this.menuStrip1765.Stretch = false;
            this.menuStrip1765.TabIndex = 83;
            this.menuStrip1765.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.exitApplicationToolStripMenuItem1.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(672, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 105;
            this.label9.Text = "Appointment";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.logo_copy;
            this.pictureBox2.Location = new System.Drawing.Point(1046, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 89);
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Actions_appointment_new_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 138);
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 32);
            this.label8.TabIndex = 101;
            this.label8.Text = "Schedule Appointment";
            // 
            // btnScheduleAppointmentDelete
            // 
            this.btnScheduleAppointmentDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScheduleAppointmentDelete.ImageKey = "(none)";
            this.btnScheduleAppointmentDelete.Location = new System.Drawing.Point(558, 353);
            this.btnScheduleAppointmentDelete.Name = "btnScheduleAppointmentDelete";
            this.btnScheduleAppointmentDelete.Size = new System.Drawing.Size(187, 53);
            this.btnScheduleAppointmentDelete.TabIndex = 8;
            this.btnScheduleAppointmentDelete.Text = "Delete Appointment";
            this.btnScheduleAppointmentDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScheduleAppointmentDelete.UseVisualStyleBackColor = true;
            this.btnScheduleAppointmentDelete.Click += new System.EventHandler(this.btnPatientRegistrationDelete_Click);
            // 
            // btnScheduleAppointmentSave
            // 
            this.btnScheduleAppointmentSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScheduleAppointmentSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScheduleAppointmentSave.ImageKey = "(none)";
            this.btnScheduleAppointmentSave.Location = new System.Drawing.Point(246, 353);
            this.btnScheduleAppointmentSave.Name = "btnScheduleAppointmentSave";
            this.btnScheduleAppointmentSave.Size = new System.Drawing.Size(187, 53);
            this.btnScheduleAppointmentSave.TabIndex = 7;
            this.btnScheduleAppointmentSave.Text = "  Save Appointment";
            this.btnScheduleAppointmentSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScheduleAppointmentSave.UseVisualStyleBackColor = true;
            this.btnScheduleAppointmentSave.Click += new System.EventHandler(this.btnPatientRegistrationSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Problem";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtScheduleAppointmentProblemDescription
            // 
            this.txtScheduleAppointmentProblemDescription.Location = new System.Drawing.Point(329, 282);
            this.txtScheduleAppointmentProblemDescription.MaxLength = 2500;
            this.txtScheduleAppointmentProblemDescription.Name = "txtScheduleAppointmentProblemDescription";
            this.txtScheduleAppointmentProblemDescription.Size = new System.Drawing.Size(275, 57);
            this.txtScheduleAppointmentProblemDescription.TabIndex = 4;
            this.txtScheduleAppointmentProblemDescription.Text = "";
            this.txtScheduleAppointmentProblemDescription.TextChanged += new System.EventHandler(this.txtScheduleAppointmentProblemDescription_TextChanged);
            // 
            // btnScheduleAppointmentSearchPatient
            // 
            this.btnScheduleAppointmentSearchPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScheduleAppointmentSearchPatient.Image = global::WindowsFormsApplication1.Properties.Resources.search_icon_16;
            this.btnScheduleAppointmentSearchPatient.Location = new System.Drawing.Point(489, 153);
            this.btnScheduleAppointmentSearchPatient.Name = "btnScheduleAppointmentSearchPatient";
            this.btnScheduleAppointmentSearchPatient.Size = new System.Drawing.Size(134, 28);
            this.btnScheduleAppointmentSearchPatient.TabIndex = 2;
            this.btnScheduleAppointmentSearchPatient.Text = "Search Patient";
            this.btnScheduleAppointmentSearchPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScheduleAppointmentSearchPatient.UseVisualStyleBackColor = true;
            this.btnScheduleAppointmentSearchPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 88;
            this.label3.Text = "Patient ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtScheduleAppointmentChannelNo
            // 
            this.txtScheduleAppointmentChannelNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtScheduleAppointmentChannelNo.ForeColor = System.Drawing.Color.Red;
            this.txtScheduleAppointmentChannelNo.Location = new System.Drawing.Point(329, 107);
            this.txtScheduleAppointmentChannelNo.MaxLength = 5;
            this.txtScheduleAppointmentChannelNo.Name = "txtScheduleAppointmentChannelNo";
            this.txtScheduleAppointmentChannelNo.Size = new System.Drawing.Size(152, 22);
            this.txtScheduleAppointmentChannelNo.TabIndex = 0;
            this.txtScheduleAppointmentChannelNo.TextChanged += new System.EventHandler(this.txtScheduleAppointmentChannelNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 85;
            this.label2.Text = "Treatment Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Treatment No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 107;
            this.label4.Text = "Description:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 108;
            this.label5.Text = "Doctor ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblScheduleAppointmentDoctorName
            // 
            this.lblScheduleAppointmentDoctorName.AutoSize = true;
            this.lblScheduleAppointmentDoctorName.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.lblScheduleAppointmentDoctorName.Location = new System.Drawing.Point(816, 180);
            this.lblScheduleAppointmentDoctorName.Name = "lblScheduleAppointmentDoctorName";
            this.lblScheduleAppointmentDoctorName.Size = new System.Drawing.Size(204, 18);
            this.lblScheduleAppointmentDoctorName.TabIndex = 127;
            this.lblScheduleAppointmentDoctorName.Text = "***Doctor Name Displayed***";
            this.lblScheduleAppointmentDoctorName.Click += new System.EventHandler(this.lblScheduleAppointmentDoctorName_Click);
            // 
            // txtScheduleAppointmentDoctorID
            // 
            this.txtScheduleAppointmentDoctorID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtScheduleAppointmentDoctorID.ForeColor = System.Drawing.Color.Red;
            this.txtScheduleAppointmentDoctorID.Location = new System.Drawing.Point(820, 155);
            this.txtScheduleAppointmentDoctorID.MaxLength = 5;
            this.txtScheduleAppointmentDoctorID.Name = "txtScheduleAppointmentDoctorID";
            this.txtScheduleAppointmentDoctorID.Size = new System.Drawing.Size(152, 22);
            this.txtScheduleAppointmentDoctorID.TabIndex = 5;
            this.txtScheduleAppointmentDoctorID.TextAlignChanged += new System.EventHandler(this.txtScheduleAppointmentDoctorID_TextAlignChanged);
            this.txtScheduleAppointmentDoctorID.TextChanged += new System.EventHandler(this.txtScheduleAppointmentDoctorID_TextChanged);
            // 
            // lblScheduleAppointmentPatientName
            // 
            this.lblScheduleAppointmentPatientName.AutoSize = true;
            this.lblScheduleAppointmentPatientName.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.lblScheduleAppointmentPatientName.Location = new System.Drawing.Point(327, 181);
            this.lblScheduleAppointmentPatientName.Name = "lblScheduleAppointmentPatientName";
            this.lblScheduleAppointmentPatientName.Size = new System.Drawing.Size(206, 18);
            this.lblScheduleAppointmentPatientName.TabIndex = 125;
            this.lblScheduleAppointmentPatientName.Text = "***Patient Name Displayed***";
            this.lblScheduleAppointmentPatientName.TextChanged += new System.EventHandler(this.lblScheduleAppointmentPatientName_TextChanged);
            this.lblScheduleAppointmentPatientName.Click += new System.EventHandler(this.lblScheduleAppointmentPatientName_Click);
            // 
            // txtScheduleAppointmentPatientID
            // 
            this.txtScheduleAppointmentPatientID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtScheduleAppointmentPatientID.ForeColor = System.Drawing.Color.Red;
            this.txtScheduleAppointmentPatientID.Location = new System.Drawing.Point(329, 156);
            this.txtScheduleAppointmentPatientID.MaxLength = 5;
            this.txtScheduleAppointmentPatientID.Name = "txtScheduleAppointmentPatientID";
            this.txtScheduleAppointmentPatientID.Size = new System.Drawing.Size(152, 22);
            this.txtScheduleAppointmentPatientID.TabIndex = 1;
            this.txtScheduleAppointmentPatientID.TextChanged += new System.EventHandler(this.txtScheduleAppointmentPatientID_TextChanged);
            // 
            // txtScheduleAppointmentTreatmentType
            // 
            this.txtScheduleAppointmentTreatmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtScheduleAppointmentTreatmentType.FormattingEnabled = true;
            this.txtScheduleAppointmentTreatmentType.Items.AddRange(new object[] {
            "Teeth Whitening",
            "Tooth Filling",
            "Dental Surgery",
            "Minor Oral Surgery",
            "Dental Implant",
            "Periodontal & GumTreatment",
            "Root Canal Treatment",
            "Cosmetic Braces",
            "Orthodontics",
            "Dental Radiology"});
            this.txtScheduleAppointmentTreatmentType.Location = new System.Drawing.Point(332, 224);
            this.txtScheduleAppointmentTreatmentType.MaxLength = 50;
            this.txtScheduleAppointmentTreatmentType.Name = "txtScheduleAppointmentTreatmentType";
            this.txtScheduleAppointmentTreatmentType.Size = new System.Drawing.Size(275, 24);
            this.txtScheduleAppointmentTreatmentType.TabIndex = 3;
            this.txtScheduleAppointmentTreatmentType.SelectedIndexChanged += new System.EventHandler(this.txtScheduleAppointmentTreatmentType_SelectedIndexChanged);
            // 
            // txtScheduleAppointmentAppointmentDate
            // 
            this.txtScheduleAppointmentAppointmentDate.Location = new System.Drawing.Point(820, 215);
            this.txtScheduleAppointmentAppointmentDate.MaxSelectionCount = 1;
            this.txtScheduleAppointmentAppointmentDate.Name = "txtScheduleAppointmentAppointmentDate";
            this.txtScheduleAppointmentAppointmentDate.TabIndex = 6;
            this.txtScheduleAppointmentAppointmentDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.txtScheduleAppointmentAppointmentDate_DateChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(671, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 130;
            this.label7.Text = "Date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnScheduleAppointmentUpdate
            // 
            this.btnScheduleAppointmentUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScheduleAppointmentUpdate.ImageKey = "(none)";
            this.btnScheduleAppointmentUpdate.Location = new System.Drawing.Point(901, 347);
            this.btnScheduleAppointmentUpdate.Name = "btnScheduleAppointmentUpdate";
            this.btnScheduleAppointmentUpdate.Size = new System.Drawing.Size(152, 53);
            this.btnScheduleAppointmentUpdate.TabIndex = 100;
            this.btnScheduleAppointmentUpdate.Text = " Update Details";
            this.btnScheduleAppointmentUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScheduleAppointmentUpdate.UseVisualStyleBackColor = true;
            this.btnScheduleAppointmentUpdate.Click += new System.EventHandler(this.btnPatientRegistrationUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 59;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.patientNameDataGridViewTextBoxColumn,
            this.treatmentTypeDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.appointmentGridViewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(332, 418);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(892, 318);
            this.dataGridView1.TabIndex = 131;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Channel No_";
            this.dataGridViewTextBoxColumn1.HeaderText = "Treatment No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 112;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Appointment Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Appointment Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 132;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "Patient Name";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            this.patientNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientNameDataGridViewTextBoxColumn.Width = 107;
            // 
            // treatmentTypeDataGridViewTextBoxColumn
            // 
            this.treatmentTypeDataGridViewTextBoxColumn.DataPropertyName = "Treatment Type";
            this.treatmentTypeDataGridViewTextBoxColumn.HeaderText = "Treatment Type";
            this.treatmentTypeDataGridViewTextBoxColumn.Name = "treatmentTypeDataGridViewTextBoxColumn";
            this.treatmentTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "Doctor Name";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Doctor Name";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            this.doctorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorNameDataGridViewTextBoxColumn.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Count (#)";
            this.dataGridViewTextBoxColumn3.HeaderText = "Count (#)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 84;
            // 
            // appointmentGridViewBindingSource
            // 
            this.appointmentGridViewBindingSource.DataMember = "AppointmentGridView";
            this.appointmentGridViewBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleappointmentBindingSource
            // 
            this.scheduleappointmentBindingSource.DataMember = "schedule_appointment";
            // 
            // patientregistrationBindingSource
            // 
            this.patientregistrationBindingSource.DataMember = "patient_registration";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // appointmentGridViewTableAdapter
            // 
            this.appointmentGridViewTableAdapter.ClearBeforeFill = true;
            // 
            // frmScheduleAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtScheduleAppointmentAppointmentDate);
            this.Controls.Add(this.txtScheduleAppointmentTreatmentType);
            this.Controls.Add(this.lblScheduleAppointmentDoctorName);
            this.Controls.Add(this.txtScheduleAppointmentDoctorID);
            this.Controls.Add(this.lblScheduleAppointmentPatientName);
            this.Controls.Add(this.txtScheduleAppointmentPatientID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnScheduleAppointmentUpdate);
            this.Controls.Add(this.btnScheduleAppointmentDelete);
            this.Controls.Add(this.btnScheduleAppointmentSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtScheduleAppointmentProblemDescription);
            this.Controls.Add(this.btnScheduleAppointmentSearchPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScheduleAppointmentChannelNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1765);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScheduleAppointment";
            this.Text = "Schedule Appointment";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            this.menuStrip1765.ResumeLayout(false);
            this.menuStrip1765.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleappointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientregistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1765;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnScheduleAppointmentDelete;
        private System.Windows.Forms.Button btnScheduleAppointmentSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtScheduleAppointmentProblemDescription;
        private System.Windows.Forms.Button btnScheduleAppointmentSearchPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScheduleAppointmentChannelNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblScheduleAppointmentDoctorName;
        private System.Windows.Forms.TextBox txtScheduleAppointmentDoctorID;
        private System.Windows.Forms.Label lblScheduleAppointmentPatientName;
        private System.Windows.Forms.TextBox txtScheduleAppointmentPatientID;
        private System.Windows.Forms.ComboBox txtScheduleAppointmentTreatmentType;
        private System.Windows.Forms.MonthCalendar txtScheduleAppointmentAppointmentDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnScheduleAppointmentUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource scheduleappointmentBindingSource;


        private System.Windows.Forms.BindingSource patientregistrationBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn channelnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource appointmentGridViewBindingSource;
        private DataSet2TableAdapters.AppointmentGridViewTableAdapter appointmentGridViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}