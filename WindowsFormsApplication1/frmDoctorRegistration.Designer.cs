namespace WindowsFormsApplication1
{
    partial class frmDoctorRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorRegistration));
            this.label8 = new System.Windows.Forms.Label();
            this.txtDoctorRegistrationContactNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDoctorRegistrationSearchDoctor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoctorRegistrationSurname = new System.Windows.Forms.TextBox();
            this.txtDoctorRegistrationFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoctorRegistrationNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1765 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDoctorRegistrationExperience = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDoctorRegistrationSpeciality = new System.Windows.Forms.Label();
            this.btnDoctorRegistrationUpdate = new System.Windows.Forms.Button();
            this.btnDoctorRegistrationDelete = new System.Windows.Forms.Button();
            this.btnDoctorRegistrationSave = new System.Windows.Forms.Button();
            this.txtDoctorRegistrationDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtDoctorRegistrationAddress = new System.Windows.Forms.RichTextBox();
            this.txtDoctorRegistrationDoctorID = new System.Windows.Forms.TextBox();
            this.rdobtnDoctorRegistrationDentist = new System.Windows.Forms.RadioButton();
            this.rdobtnDoctorRegistrationConsultant = new System.Windows.Forms.RadioButton();
            this.menuStrip1765.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoctorRegistrationExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 32);
            this.label8.TabIndex = 76;
            this.label8.Text = "Doctor Information";
            // 
            // txtDoctorRegistrationContactNo
            // 
            this.txtDoctorRegistrationContactNo.Location = new System.Drawing.Point(908, 324);
            this.txtDoctorRegistrationContactNo.MaxLength = 10;
            this.txtDoctorRegistrationContactNo.Name = "txtDoctorRegistrationContactNo";
            this.txtDoctorRegistrationContactNo.Size = new System.Drawing.Size(175, 22);
            this.txtDoctorRegistrationContactNo.TabIndex = 7;
            this.txtDoctorRegistrationContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDoctorRegistrationContactNo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(735, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 74;
            this.label7.Text = "Contact No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Address:";
            // 
            // btnDoctorRegistrationSearchDoctor
            // 
            this.btnDoctorRegistrationSearchDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorRegistrationSearchDoctor.Image = global::WindowsFormsApplication1.Properties.Resources.search_icon_16;
            this.btnDoctorRegistrationSearchDoctor.Location = new System.Drawing.Point(365, 218);
            this.btnDoctorRegistrationSearchDoctor.Name = "btnDoctorRegistrationSearchDoctor";
            this.btnDoctorRegistrationSearchDoctor.Size = new System.Drawing.Size(132, 28);
            this.btnDoctorRegistrationSearchDoctor.TabIndex = 1;
            this.btnDoctorRegistrationSearchDoctor.Text = "Search Doctor";
            this.btnDoctorRegistrationSearchDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctorRegistrationSearchDoctor.UseVisualStyleBackColor = true;
            this.btnDoctorRegistrationSearchDoctor.Click += new System.EventHandler(this.btnDoctorRegistrationSearchDoctor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 70;
            this.label5.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 69;
            this.label4.Text = "First";
            // 
            // txtDoctorRegistrationSurname
            // 
            this.txtDoctorRegistrationSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoctorRegistrationSurname.Location = new System.Drawing.Point(365, 269);
            this.txtDoctorRegistrationSurname.MaxLength = 100;
            this.txtDoctorRegistrationSurname.Name = "txtDoctorRegistrationSurname";
            this.txtDoctorRegistrationSurname.Size = new System.Drawing.Size(270, 22);
            this.txtDoctorRegistrationSurname.TabIndex = 3;
            // 
            // txtDoctorRegistrationFirstName
            // 
            this.txtDoctorRegistrationFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoctorRegistrationFirstName.Location = new System.Drawing.Point(204, 269);
            this.txtDoctorRegistrationFirstName.MaxLength = 100;
            this.txtDoctorRegistrationFirstName.Name = "txtDoctorRegistrationFirstName";
            this.txtDoctorRegistrationFirstName.Size = new System.Drawing.Size(152, 22);
            this.txtDoctorRegistrationFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Doctor Name:";
            // 
            // txtDoctorRegistrationNIC
            // 
            this.txtDoctorRegistrationNIC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoctorRegistrationNIC.Location = new System.Drawing.Point(908, 269);
            this.txtDoctorRegistrationNIC.MaxLength = 20;
            this.txtDoctorRegistrationNIC.Name = "txtDoctorRegistrationNIC";
            this.txtDoctorRegistrationNIC.Size = new System.Drawing.Size(242, 22);
            this.txtDoctorRegistrationNIC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(735, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "NIC Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Doctor ID:";
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
            this.menuStrip1765.Size = new System.Drawing.Size(1680, 26);
            this.menuStrip1765.Stretch = false;
            this.menuStrip1765.TabIndex = 79;
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
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
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
            this.label9.Location = new System.Drawing.Point(735, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Experience:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(956, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 82;
            this.label10.Text = "years";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 25);
            this.label11.TabIndex = 83;
            this.label11.Text = "Date of Birth:";
            // 
            // txtDoctorRegistrationExperience
            // 
            this.txtDoctorRegistrationExperience.Location = new System.Drawing.Point(908, 375);
            this.txtDoctorRegistrationExperience.Name = "txtDoctorRegistrationExperience";
            this.txtDoctorRegistrationExperience.Size = new System.Drawing.Size(49, 22);
            this.txtDoctorRegistrationExperience.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.breadcrumb_bg1;
            this.pictureBox3.Location = new System.Drawing.Point(-228, 557);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1908, 258);
            this.pictureBox3.TabIndex = 88;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.logo_copy;
            this.pictureBox2.Location = new System.Drawing.Point(908, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 89);
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.People_Doctor_Male_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(33, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 138);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // txtDoctorRegistrationSpeciality
            // 
            this.txtDoctorRegistrationSpeciality.AutoSize = true;
            this.txtDoctorRegistrationSpeciality.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorRegistrationSpeciality.Location = new System.Drawing.Point(735, 419);
            this.txtDoctorRegistrationSpeciality.Name = "txtDoctorRegistrationSpeciality";
            this.txtDoctorRegistrationSpeciality.Size = new System.Drawing.Size(112, 25);
            this.txtDoctorRegistrationSpeciality.TabIndex = 90;
            this.txtDoctorRegistrationSpeciality.Text = "Speciality?";
            // 
            // btnDoctorRegistrationUpdate
            // 
            this.btnDoctorRegistrationUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorRegistrationUpdate.ImageKey = "(none)";
            this.btnDoctorRegistrationUpdate.Location = new System.Drawing.Point(755, 484);
            this.btnDoctorRegistrationUpdate.Name = "btnDoctorRegistrationUpdate";
            this.btnDoctorRegistrationUpdate.Size = new System.Drawing.Size(152, 53);
            this.btnDoctorRegistrationUpdate.TabIndex = 13;
            this.btnDoctorRegistrationUpdate.Text = " Update Details";
            this.btnDoctorRegistrationUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctorRegistrationUpdate.UseVisualStyleBackColor = true;
            this.btnDoctorRegistrationUpdate.Click += new System.EventHandler(this.btnDoctorRegistrationUpdate_Click);
            // 
            // btnDoctorRegistrationDelete
            // 
            this.btnDoctorRegistrationDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorRegistrationDelete.ImageKey = "(none)";
            this.btnDoctorRegistrationDelete.Location = new System.Drawing.Point(486, 484);
            this.btnDoctorRegistrationDelete.Name = "btnDoctorRegistrationDelete";
            this.btnDoctorRegistrationDelete.Size = new System.Drawing.Size(152, 53);
            this.btnDoctorRegistrationDelete.TabIndex = 12;
            this.btnDoctorRegistrationDelete.Text = "Delete Details";
            this.btnDoctorRegistrationDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctorRegistrationDelete.UseVisualStyleBackColor = true;
            this.btnDoctorRegistrationDelete.Click += new System.EventHandler(this.btnDoctorRegistrationDelete_Click);
            // 
            // btnDoctorRegistrationSave
            // 
            this.btnDoctorRegistrationSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDoctorRegistrationSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorRegistrationSave.ImageKey = "(none)";
            this.btnDoctorRegistrationSave.Location = new System.Drawing.Point(237, 484);
            this.btnDoctorRegistrationSave.Name = "btnDoctorRegistrationSave";
            this.btnDoctorRegistrationSave.Size = new System.Drawing.Size(152, 53);
            this.btnDoctorRegistrationSave.TabIndex = 11;
            this.btnDoctorRegistrationSave.Text = "  Save Details";
            this.btnDoctorRegistrationSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctorRegistrationSave.UseVisualStyleBackColor = true;
            this.btnDoctorRegistrationSave.Click += new System.EventHandler(this.btnDoctorRegistrationSave_Click);
            // 
            // txtDoctorRegistrationDateOfBirth
            // 
            this.txtDoctorRegistrationDateOfBirth.Location = new System.Drawing.Point(204, 421);
            this.txtDoctorRegistrationDateOfBirth.Name = "txtDoctorRegistrationDateOfBirth";
            this.txtDoctorRegistrationDateOfBirth.Size = new System.Drawing.Size(246, 22);
            this.txtDoctorRegistrationDateOfBirth.TabIndex = 5;
            this.txtDoctorRegistrationDateOfBirth.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtDoctorRegistrationAddress
            // 
            this.txtDoctorRegistrationAddress.Location = new System.Drawing.Point(204, 333);
            this.txtDoctorRegistrationAddress.MaxLength = 1000;
            this.txtDoctorRegistrationAddress.Name = "txtDoctorRegistrationAddress";
            this.txtDoctorRegistrationAddress.Size = new System.Drawing.Size(431, 62);
            this.txtDoctorRegistrationAddress.TabIndex = 4;
            this.txtDoctorRegistrationAddress.Text = "";
            // 
            // txtDoctorRegistrationDoctorID
            // 
            this.txtDoctorRegistrationDoctorID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoctorRegistrationDoctorID.ForeColor = System.Drawing.Color.Red;
            this.txtDoctorRegistrationDoctorID.Location = new System.Drawing.Point(204, 222);
            this.txtDoctorRegistrationDoctorID.MaxLength = 5;
            this.txtDoctorRegistrationDoctorID.Name = "txtDoctorRegistrationDoctorID";
            this.txtDoctorRegistrationDoctorID.Size = new System.Drawing.Size(152, 22);
            this.txtDoctorRegistrationDoctorID.TabIndex = 0;
            // 
            // rdobtnDoctorRegistrationDentist
            // 
            this.rdobtnDoctorRegistrationDentist.AutoSize = true;
            this.rdobtnDoctorRegistrationDentist.Location = new System.Drawing.Point(908, 424);
            this.rdobtnDoctorRegistrationDentist.Name = "rdobtnDoctorRegistrationDentist";
            this.rdobtnDoctorRegistrationDentist.Size = new System.Drawing.Size(73, 21);
            this.rdobtnDoctorRegistrationDentist.TabIndex = 9;
            this.rdobtnDoctorRegistrationDentist.TabStop = true;
            this.rdobtnDoctorRegistrationDentist.Text = "Dentist";
            this.rdobtnDoctorRegistrationDentist.UseVisualStyleBackColor = true;
            this.rdobtnDoctorRegistrationDentist.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdobtnDoctorRegistrationConsultant
            // 
            this.rdobtnDoctorRegistrationConsultant.AutoSize = true;
            this.rdobtnDoctorRegistrationConsultant.Location = new System.Drawing.Point(1009, 424);
            this.rdobtnDoctorRegistrationConsultant.Name = "rdobtnDoctorRegistrationConsultant";
            this.rdobtnDoctorRegistrationConsultant.Size = new System.Drawing.Size(141, 21);
            this.rdobtnDoctorRegistrationConsultant.TabIndex = 10;
            this.rdobtnDoctorRegistrationConsultant.TabStop = true;
            this.rdobtnDoctorRegistrationConsultant.Text = "Dental Consultant";
            this.rdobtnDoctorRegistrationConsultant.UseVisualStyleBackColor = true;
            // 
            // frmDoctorRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1266, 748);
            this.Controls.Add(this.rdobtnDoctorRegistrationConsultant);
            this.Controls.Add(this.rdobtnDoctorRegistrationDentist);
            this.Controls.Add(this.txtDoctorRegistrationDoctorID);
            this.Controls.Add(this.txtDoctorRegistrationAddress);
            this.Controls.Add(this.txtDoctorRegistrationDateOfBirth);
            this.Controls.Add(this.btnDoctorRegistrationUpdate);
            this.Controls.Add(this.btnDoctorRegistrationDelete);
            this.Controls.Add(this.btnDoctorRegistrationSave);
            this.Controls.Add(this.txtDoctorRegistrationSpeciality);
            this.Controls.Add(this.txtDoctorRegistrationExperience);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1765);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDoctorRegistrationContactNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDoctorRegistrationSearchDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDoctorRegistrationSurname);
            this.Controls.Add(this.txtDoctorRegistrationFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDoctorRegistrationNIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoctorRegistration";
            this.Text = "Doctor Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoctorRegistration_Load);
            this.menuStrip1765.ResumeLayout(false);
            this.menuStrip1765.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoctorRegistrationExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDoctorRegistrationContactNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDoctorRegistrationSearchDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoctorRegistrationSurname;
        private System.Windows.Forms.TextBox txtDoctorRegistrationFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoctorRegistrationNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1765;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown txtDoctorRegistrationExperience;
        private System.Windows.Forms.Label txtDoctorRegistrationSpeciality;
        private System.Windows.Forms.Button btnDoctorRegistrationUpdate;
        private System.Windows.Forms.Button btnDoctorRegistrationDelete;
        private System.Windows.Forms.Button btnDoctorRegistrationSave;
        private System.Windows.Forms.DateTimePicker txtDoctorRegistrationDateOfBirth;
        private System.Windows.Forms.RichTextBox txtDoctorRegistrationAddress;
        private System.Windows.Forms.TextBox txtDoctorRegistrationDoctorID;
        private System.Windows.Forms.RadioButton rdobtnDoctorRegistrationDentist;
        private System.Windows.Forms.RadioButton rdobtnDoctorRegistrationConsultant;

    }
}