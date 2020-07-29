namespace WindowsFormsApplication1
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.menuStrip1765 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPaymentUpdate = new System.Windows.Forms.Button();
            this.btnPaymentDelete = new System.Windows.Forms.Button();
            this.btnPaymentSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaymentPatientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymentInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtPaymentTreatmentCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdobtnPaymentCash = new System.Windows.Forms.RadioButton();
            this.rdobtnPaymentCreditCard = new System.Windows.Forms.RadioButton();
            this.rdobtnPaymentCheque = new System.Windows.Forms.RadioButton();
            this.lblPaymentDoctorsCharge = new System.Windows.Forms.Label();
            this.lblPaymentStandardFee = new System.Windows.Forms.Label();
            this.lblPaymentTotalCharge = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPaymentRegistrationFee = new System.Windows.Forms.Label();
            this.lblPaymentTreatmentType = new System.Windows.Forms.TextBox();
            this.lblPaymentPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkboxPaymentNewPatient = new System.Windows.Forms.RadioButton();
            this.rdoBtnsasas = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnPaymentPrintInvoice = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1765.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1765.Size = new System.Drawing.Size(1655, 26);
            this.menuStrip1765.Stretch = false;
            this.menuStrip1765.TabIndex = 84;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 32);
            this.label8.TabIndex = 81;
            this.label8.Text = "Payment Information";
            // 
            // btnPaymentUpdate
            // 
            this.btnPaymentUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentUpdate.ImageKey = "(none)";
            this.btnPaymentUpdate.Location = new System.Drawing.Point(737, 491);
            this.btnPaymentUpdate.Name = "btnPaymentUpdate";
            this.btnPaymentUpdate.Size = new System.Drawing.Size(152, 53);
            this.btnPaymentUpdate.TabIndex = 7;
            this.btnPaymentUpdate.Text = " Update Details";
            this.btnPaymentUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentUpdate.UseVisualStyleBackColor = true;
            this.btnPaymentUpdate.Click += new System.EventHandler(this.btnPaymentUpdate_Click);
            // 
            // btnPaymentDelete
            // 
            this.btnPaymentDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentDelete.ImageKey = "(none)";
            this.btnPaymentDelete.Location = new System.Drawing.Point(468, 491);
            this.btnPaymentDelete.Name = "btnPaymentDelete";
            this.btnPaymentDelete.Size = new System.Drawing.Size(152, 53);
            this.btnPaymentDelete.TabIndex = 6;
            this.btnPaymentDelete.Text = "Delete Details";
            this.btnPaymentDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentDelete.UseVisualStyleBackColor = true;
            this.btnPaymentDelete.Click += new System.EventHandler(this.btnPaymentDelete_Click);
            // 
            // btnPaymentSave
            // 
            this.btnPaymentSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPaymentSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentSave.ImageKey = "(none)";
            this.btnPaymentSave.Location = new System.Drawing.Point(219, 491);
            this.btnPaymentSave.Name = "btnPaymentSave";
            this.btnPaymentSave.Size = new System.Drawing.Size(152, 53);
            this.btnPaymentSave.TabIndex = 5;
            this.btnPaymentSave.Text = "  Save Details";
            this.btnPaymentSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentSave.UseVisualStyleBackColor = true;
            this.btnPaymentSave.Click += new System.EventHandler(this.btnPaymentSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 146;
            this.label5.Text = "Treatment Code:";
            // 
            // txtPaymentPatientID
            // 
            this.txtPaymentPatientID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaymentPatientID.ForeColor = System.Drawing.Color.Red;
            this.txtPaymentPatientID.Location = new System.Drawing.Point(242, 358);
            this.txtPaymentPatientID.MaxLength = 5;
            this.txtPaymentPatientID.Name = "txtPaymentPatientID";
            this.txtPaymentPatientID.Size = new System.Drawing.Size(152, 22);
            this.txtPaymentPatientID.TabIndex = 2;
            this.txtPaymentPatientID.TextChanged += new System.EventHandler(this.txtDentalTreatmentPatientID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 143;
            this.label4.Text = "Patient ID:";
            // 
            // txtPaymentInvoiceNo
            // 
            this.txtPaymentInvoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaymentInvoiceNo.ForeColor = System.Drawing.Color.Red;
            this.txtPaymentInvoiceNo.Location = new System.Drawing.Point(242, 258);
            this.txtPaymentInvoiceNo.MaxLength = 5;
            this.txtPaymentInvoiceNo.Name = "txtPaymentInvoiceNo";
            this.txtPaymentInvoiceNo.Size = new System.Drawing.Size(152, 22);
            this.txtPaymentInvoiceNo.TabIndex = 0;
            // 
            // txtPaymentTreatmentCode
            // 
            this.txtPaymentTreatmentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPaymentTreatmentCode.ForeColor = System.Drawing.Color.Red;
            this.txtPaymentTreatmentCode.Location = new System.Drawing.Point(242, 307);
            this.txtPaymentTreatmentCode.MaxLength = 5;
            this.txtPaymentTreatmentCode.Name = "txtPaymentTreatmentCode";
            this.txtPaymentTreatmentCode.Size = new System.Drawing.Size(152, 22);
            this.txtPaymentTreatmentCode.TabIndex = 1;
            this.txtPaymentTreatmentCode.TextChanged += new System.EventHandler(this.txtPaymentTreatmentCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 138;
            this.label1.Text = "Invoice No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 155;
            this.label2.Text = "Payment";
            // 
            // rdobtnPaymentCash
            // 
            this.rdobtnPaymentCash.AutoSize = true;
            this.rdobtnPaymentCash.Location = new System.Drawing.Point(20, 4);
            this.rdobtnPaymentCash.Name = "rdobtnPaymentCash";
            this.rdobtnPaymentCash.Size = new System.Drawing.Size(61, 21);
            this.rdobtnPaymentCash.TabIndex = 0;
            this.rdobtnPaymentCash.TabStop = true;
            this.rdobtnPaymentCash.Text = "Cash";
            this.rdobtnPaymentCash.UseVisualStyleBackColor = true;
            // 
            // rdobtnPaymentCreditCard
            // 
            this.rdobtnPaymentCreditCard.AutoSize = true;
            this.rdobtnPaymentCreditCard.Location = new System.Drawing.Point(20, 30);
            this.rdobtnPaymentCreditCard.Name = "rdobtnPaymentCreditCard";
            this.rdobtnPaymentCreditCard.Size = new System.Drawing.Size(100, 21);
            this.rdobtnPaymentCreditCard.TabIndex = 2;
            this.rdobtnPaymentCreditCard.TabStop = true;
            this.rdobtnPaymentCreditCard.Text = "Credit Card";
            this.rdobtnPaymentCreditCard.UseVisualStyleBackColor = true;
            // 
            // rdobtnPaymentCheque
            // 
            this.rdobtnPaymentCheque.AutoSize = true;
            this.rdobtnPaymentCheque.Location = new System.Drawing.Point(132, 4);
            this.rdobtnPaymentCheque.Name = "rdobtnPaymentCheque";
            this.rdobtnPaymentCheque.Size = new System.Drawing.Size(78, 21);
            this.rdobtnPaymentCheque.TabIndex = 1;
            this.rdobtnPaymentCheque.TabStop = true;
            this.rdobtnPaymentCheque.Text = "Cheque";
            this.rdobtnPaymentCheque.UseVisualStyleBackColor = true;
            // 
            // lblPaymentDoctorsCharge
            // 
            this.lblPaymentDoctorsCharge.AutoSize = true;
            this.lblPaymentDoctorsCharge.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDoctorsCharge.Location = new System.Drawing.Point(934, 332);
            this.lblPaymentDoctorsCharge.Name = "lblPaymentDoctorsCharge";
            this.lblPaymentDoctorsCharge.Size = new System.Drawing.Size(259, 19);
            this.lblPaymentDoctorsCharge.TabIndex = 159;
            this.lblPaymentDoctorsCharge.Text = "Doctor\'s charge:-                     xxxxx";
            // 
            // lblPaymentStandardFee
            // 
            this.lblPaymentStandardFee.AutoSize = true;
            this.lblPaymentStandardFee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStandardFee.Location = new System.Drawing.Point(934, 362);
            this.lblPaymentStandardFee.Name = "lblPaymentStandardFee";
            this.lblPaymentStandardFee.Size = new System.Drawing.Size(259, 19);
            this.lblPaymentStandardFee.TabIndex = 160;
            this.lblPaymentStandardFee.Text = "Treatment Standard Fee:-      xxxxx";
            // 
            // lblPaymentTotalCharge
            // 
            this.lblPaymentTotalCharge.AutoSize = true;
            this.lblPaymentTotalCharge.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTotalCharge.Location = new System.Drawing.Point(934, 392);
            this.lblPaymentTotalCharge.Name = "lblPaymentTotalCharge";
            this.lblPaymentTotalCharge.Size = new System.Drawing.Size(260, 19);
            this.lblPaymentTotalCharge.TabIndex = 161;
            this.lblPaymentTotalCharge.Text = "Total Charge:-                           xxxxx";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1146, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 162;
            this.label9.Text = "(LKR)";
            // 
            // lblPaymentRegistrationFee
            // 
            this.lblPaymentRegistrationFee.AutoSize = true;
            this.lblPaymentRegistrationFee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentRegistrationFee.Location = new System.Drawing.Point(935, 305);
            this.lblPaymentRegistrationFee.Name = "lblPaymentRegistrationFee";
            this.lblPaymentRegistrationFee.Size = new System.Drawing.Size(258, 19);
            this.lblPaymentRegistrationFee.TabIndex = 167;
            this.lblPaymentRegistrationFee.Text = "Registration Fee:-                    xxxxx";
            // 
            // lblPaymentTreatmentType
            // 
            this.lblPaymentTreatmentType.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentTreatmentType.Location = new System.Drawing.Point(638, 308);
            this.lblPaymentTreatmentType.Name = "lblPaymentTreatmentType";
            this.lblPaymentTreatmentType.ReadOnly = true;
            this.lblPaymentTreatmentType.Size = new System.Drawing.Size(201, 22);
            this.lblPaymentTreatmentType.TabIndex = 168;
            // 
            // lblPaymentPatientName
            // 
            this.lblPaymentPatientName.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentPatientName.Location = new System.Drawing.Point(637, 359);
            this.lblPaymentPatientName.Name = "lblPaymentPatientName";
            this.lblPaymentPatientName.ReadOnly = true;
            this.lblPaymentPatientName.Size = new System.Drawing.Size(201, 22);
            this.lblPaymentPatientName.TabIndex = 169;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 170;
            this.label3.Text = "Treatment Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 171;
            this.label6.Text = "Patient Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 25);
            this.label7.TabIndex = 172;
            this.label7.Text = "New";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdobtnPaymentCreditCard);
            this.panel1.Controls.Add(this.rdobtnPaymentCash);
            this.panel1.Controls.Add(this.rdobtnPaymentCheque);
            this.panel1.Location = new System.Drawing.Point(617, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 57);
            this.panel1.TabIndex = 4;
            // 
            // chkboxPaymentNewPatient
            // 
            this.chkboxPaymentNewPatient.AutoSize = true;
            this.chkboxPaymentNewPatient.Location = new System.Drawing.Point(21, 3);
            this.chkboxPaymentNewPatient.Name = "chkboxPaymentNewPatient";
            this.chkboxPaymentNewPatient.Size = new System.Drawing.Size(112, 21);
            this.chkboxPaymentNewPatient.TabIndex = 0;
            this.chkboxPaymentNewPatient.TabStop = true;
            this.chkboxPaymentNewPatient.Text = "Yes, first visit";
            this.chkboxPaymentNewPatient.UseVisualStyleBackColor = true;
            // 
            // rdoBtnsasas
            // 
            this.rdoBtnsasas.AutoSize = true;
            this.rdoBtnsasas.Location = new System.Drawing.Point(21, 31);
            this.rdoBtnsasas.Name = "rdoBtnsasas";
            this.rdoBtnsasas.Size = new System.Drawing.Size(164, 21);
            this.rdoBtnsasas.TabIndex = 1;
            this.rdoBtnsasas.TabStop = true;
            this.rdoBtnsasas.Text = "No, existing customer";
            this.rdoBtnsasas.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoBtnsasas);
            this.panel2.Controls.Add(this.chkboxPaymentNewPatient);
            this.panel2.Location = new System.Drawing.Point(221, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 53);
            this.panel2.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 178;
            this.label10.Text = "Patient?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(462, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 25);
            this.label11.TabIndex = 179;
            this.label11.Text = "Mode:";
            // 
            // btnPaymentPrintInvoice
            // 
            this.btnPaymentPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentPrintInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentPrintInvoice.ImageKey = "(none)";
            this.btnPaymentPrintInvoice.Location = new System.Drawing.Point(993, 491);
            this.btnPaymentPrintInvoice.Name = "btnPaymentPrintInvoice";
            this.btnPaymentPrintInvoice.Size = new System.Drawing.Size(152, 53);
            this.btnPaymentPrintInvoice.TabIndex = 8;
            this.btnPaymentPrintInvoice.Text = "Print Invoice";
            this.btnPaymentPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaymentPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPaymentPrintInvoice.Click += new System.EventHandler(this.btnPaymentPrintInvoice_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.breadcrumb_bg1;
            this.pictureBox3.Location = new System.Drawing.Point(-253, 561);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1908, 258);
            this.pictureBox3.TabIndex = 154;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.logo_copy;
            this.pictureBox2.Location = new System.Drawing.Point(1010, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 89);
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.cash_register;
            this.pictureBox1.Location = new System.Drawing.Point(65, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 138);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1266, 748);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPaymentPatientName);
            this.Controls.Add(this.lblPaymentTreatmentType);
            this.Controls.Add(this.lblPaymentRegistrationFee);
            this.Controls.Add(this.btnPaymentPrintInvoice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPaymentTotalCharge);
            this.Controls.Add(this.lblPaymentStandardFee);
            this.Controls.Add(this.lblPaymentDoctorsCharge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnPaymentUpdate);
            this.Controls.Add(this.btnPaymentDelete);
            this.Controls.Add(this.btnPaymentSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPaymentPatientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPaymentInvoiceNo);
            this.Controls.Add(this.txtPaymentTreatmentCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1765);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.menuStrip1765.ResumeLayout(false);
            this.menuStrip1765.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1765;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPaymentUpdate;
        private System.Windows.Forms.Button btnPaymentDelete;
        private System.Windows.Forms.Button btnPaymentSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaymentPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaymentInvoiceNo;
        private System.Windows.Forms.TextBox txtPaymentTreatmentCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdobtnPaymentCash;
        private System.Windows.Forms.RadioButton rdobtnPaymentCreditCard;
        private System.Windows.Forms.RadioButton rdobtnPaymentCheque;
        private System.Windows.Forms.Label lblPaymentDoctorsCharge;
        private System.Windows.Forms.Label lblPaymentStandardFee;
        private System.Windows.Forms.Label lblPaymentTotalCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPaymentPrintInvoice;
        private System.Windows.Forms.Label lblPaymentRegistrationFee;
        private System.Windows.Forms.TextBox lblPaymentTreatmentType;
        private System.Windows.Forms.TextBox lblPaymentPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton chkboxPaymentNewPatient;
        private System.Windows.Forms.RadioButton rdoBtnsasas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}