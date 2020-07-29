namespace WindowsFormsApplication1
{
    partial class frmPatientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientRegistrationPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientRegistrationNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatientRegistrationFirstName = new System.Windows.Forms.TextBox();
            this.txtPatientRegistrationSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatientRegistrationAddress = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatientRegistrationContactNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1e3 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPatientRegistrationRegistrationFee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPatientRegistrationUpdate = new System.Windows.Forms.Button();
            this.btnPatientRegistrationDelete = new System.Windows.Forms.Button();
            this.btnPatientRegistrationSave = new System.Windows.Forms.Button();
            this.pictureBox386 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPatientRegistrationSearchPatient = new System.Windows.Forms.Button();
            this.menuStrip1e3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox386)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(716, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIC Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPatientRegistrationPatientID
            // 
            this.txtPatientRegistrationPatientID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatientRegistrationPatientID.ForeColor = System.Drawing.Color.Red;
            this.txtPatientRegistrationPatientID.Location = new System.Drawing.Point(223, 224);
            this.txtPatientRegistrationPatientID.MaxLength = 5;
            this.txtPatientRegistrationPatientID.Name = "txtPatientRegistrationPatientID";
            this.txtPatientRegistrationPatientID.Size = new System.Drawing.Size(152, 22);
            this.txtPatientRegistrationPatientID.TabIndex = 0;
            this.txtPatientRegistrationPatientID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPatientRegistrationNIC
            // 
            this.txtPatientRegistrationNIC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatientRegistrationNIC.Location = new System.Drawing.Point(911, 274);
            this.txtPatientRegistrationNIC.MaxLength = 100;
            this.txtPatientRegistrationNIC.Name = "txtPatientRegistrationNIC";
            this.txtPatientRegistrationNIC.Size = new System.Drawing.Size(195, 22);
            this.txtPatientRegistrationNIC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient Name:";
            // 
            // txtPatientRegistrationFirstName
            // 
            this.txtPatientRegistrationFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatientRegistrationFirstName.Location = new System.Drawing.Point(223, 274);
            this.txtPatientRegistrationFirstName.MaxLength = 100;
            this.txtPatientRegistrationFirstName.Name = "txtPatientRegistrationFirstName";
            this.txtPatientRegistrationFirstName.Size = new System.Drawing.Size(152, 22);
            this.txtPatientRegistrationFirstName.TabIndex = 2;
            // 
            // txtPatientRegistrationSurname
            // 
            this.txtPatientRegistrationSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPatientRegistrationSurname.Location = new System.Drawing.Point(384, 274);
            this.txtPatientRegistrationSurname.MaxLength = 100;
            this.txtPatientRegistrationSurname.Name = "txtPatientRegistrationSurname";
            this.txtPatientRegistrationSurname.Size = new System.Drawing.Size(270, 22);
            this.txtPatientRegistrationSurname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "First";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Surname";
            // 
            // txtPatientRegistrationAddress
            // 
            this.txtPatientRegistrationAddress.Location = new System.Drawing.Point(223, 334);
            this.txtPatientRegistrationAddress.MaxLength = 1000;
            this.txtPatientRegistrationAddress.Name = "txtPatientRegistrationAddress";
            this.txtPatientRegistrationAddress.Size = new System.Drawing.Size(370, 57);
            this.txtPatientRegistrationAddress.TabIndex = 4;
            this.txtPatientRegistrationAddress.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(716, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact Number:";
            // 
            // txtPatientRegistrationContactNo
            // 
            this.txtPatientRegistrationContactNo.Location = new System.Drawing.Point(911, 324);
            this.txtPatientRegistrationContactNo.MaxLength = 10;
            this.txtPatientRegistrationContactNo.Name = "txtPatientRegistrationContactNo";
            this.txtPatientRegistrationContactNo.Size = new System.Drawing.Size(152, 22);
            this.txtPatientRegistrationContactNo.TabIndex = 6;
            this.txtPatientRegistrationContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientRegistrationContactNo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Patient Information";
            // 
            // menuStrip1e3
            // 
            this.menuStrip1e3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitApplicationToolStripMenuItem,
            this.exitApplicationToolStripMenuItem1});
            this.menuStrip1e3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1e3.Name = "menuStrip1e3";
            this.menuStrip1e3.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1e3.Size = new System.Drawing.Size(1687, 26);
            this.menuStrip1e3.Stretch = false;
            this.menuStrip1e3.TabIndex = 60;
            this.menuStrip1e3.Text = "menuStrip1";
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
            this.label9.Location = new System.Drawing.Point(716, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "Registration Fee:";
            // 
            // txtPatientRegistrationRegistrationFee
            // 
            this.txtPatientRegistrationRegistrationFee.Location = new System.Drawing.Point(911, 370);
            this.txtPatientRegistrationRegistrationFee.MaxLength = 6;
            this.txtPatientRegistrationRegistrationFee.Name = "txtPatientRegistrationRegistrationFee";
            this.txtPatientRegistrationRegistrationFee.Size = new System.Drawing.Size(78, 22);
            this.txtPatientRegistrationRegistrationFee.TabIndex = 7;
            this.txtPatientRegistrationRegistrationFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientRegistrationRegistrationFee_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(988, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 19);
            this.label10.TabIndex = 83;
            this.label10.Text = "LKR";
            // 
            // btnPatientRegistrationUpdate
            // 
            this.btnPatientRegistrationUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientRegistrationUpdate.ImageKey = "(none)";
            this.btnPatientRegistrationUpdate.Location = new System.Drawing.Point(789, 436);
            this.btnPatientRegistrationUpdate.Name = "btnPatientRegistrationUpdate";
            this.btnPatientRegistrationUpdate.Size = new System.Drawing.Size(152, 53);
            this.btnPatientRegistrationUpdate.TabIndex = 10;
            this.btnPatientRegistrationUpdate.Text = " Update Details";
            this.btnPatientRegistrationUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientRegistrationUpdate.UseVisualStyleBackColor = true;
            this.btnPatientRegistrationUpdate.Click += new System.EventHandler(this.btnPatientRegistrationUpdate_Click);
            // 
            // btnPatientRegistrationDelete
            // 
            this.btnPatientRegistrationDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientRegistrationDelete.ImageKey = "(none)";
            this.btnPatientRegistrationDelete.Location = new System.Drawing.Point(520, 436);
            this.btnPatientRegistrationDelete.Name = "btnPatientRegistrationDelete";
            this.btnPatientRegistrationDelete.Size = new System.Drawing.Size(152, 53);
            this.btnPatientRegistrationDelete.TabIndex = 9;
            this.btnPatientRegistrationDelete.Text = "Delete Details";
            this.btnPatientRegistrationDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientRegistrationDelete.UseVisualStyleBackColor = true;
            this.btnPatientRegistrationDelete.Click += new System.EventHandler(this.btnPatientRegistrationDelete_Click);
            // 
            // btnPatientRegistrationSave
            // 
            this.btnPatientRegistrationSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPatientRegistrationSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientRegistrationSave.ImageKey = "(none)";
            this.btnPatientRegistrationSave.Location = new System.Drawing.Point(271, 436);
            this.btnPatientRegistrationSave.Name = "btnPatientRegistrationSave";
            this.btnPatientRegistrationSave.Size = new System.Drawing.Size(152, 53);
            this.btnPatientRegistrationSave.TabIndex = 8;
            this.btnPatientRegistrationSave.Text = "  Save Details";
            this.btnPatientRegistrationSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientRegistrationSave.UseVisualStyleBackColor = true;
            this.btnPatientRegistrationSave.Click += new System.EventHandler(this.btnPatientRegistrationSave_Click);
            // 
            // pictureBox386
            // 
            this.pictureBox386.Image = global::WindowsFormsApplication1.Properties.Resources.breadcrumb_bg1;
            this.pictureBox386.Location = new System.Drawing.Point(-221, 520);
            this.pictureBox386.Name = "pictureBox386";
            this.pictureBox386.Size = new System.Drawing.Size(1908, 258);
            this.pictureBox386.TabIndex = 155;
            this.pictureBox386.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.logo_copy;
            this.pictureBox2.Location = new System.Drawing.Point(1027, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 89);
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Patients_icon;
            this.pictureBox1.Location = new System.Drawing.Point(55, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 138);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnPatientRegistrationSearchPatient
            // 
            this.btnPatientRegistrationSearchPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientRegistrationSearchPatient.Image = global::WindowsFormsApplication1.Properties.Resources.search_icon_16;
            this.btnPatientRegistrationSearchPatient.Location = new System.Drawing.Point(384, 221);
            this.btnPatientRegistrationSearchPatient.Name = "btnPatientRegistrationSearchPatient";
            this.btnPatientRegistrationSearchPatient.Size = new System.Drawing.Size(129, 28);
            this.btnPatientRegistrationSearchPatient.TabIndex = 1;
            this.btnPatientRegistrationSearchPatient.Text = "Search Patient";
            this.btnPatientRegistrationSearchPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientRegistrationSearchPatient.UseVisualStyleBackColor = true;
            this.btnPatientRegistrationSearchPatient.Click += new System.EventHandler(this.btnPatientRegistrationSearchPatient_Click);
            // 
            // frmPatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1370, 734);
            this.Controls.Add(this.pictureBox386);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPatientRegistrationRegistrationFee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1e3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPatientRegistrationUpdate);
            this.Controls.Add(this.btnPatientRegistrationDelete);
            this.Controls.Add(this.btnPatientRegistrationSave);
            this.Controls.Add(this.txtPatientRegistrationContactNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPatientRegistrationAddress);
            this.Controls.Add(this.btnPatientRegistrationSearchPatient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatientRegistrationSurname);
            this.Controls.Add(this.txtPatientRegistrationFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatientRegistrationNIC);
            this.Controls.Add(this.txtPatientRegistrationPatientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPatientRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1e3.ResumeLayout(false);
            this.menuStrip1e3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox386)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientRegistrationPatientID;
        private System.Windows.Forms.TextBox txtPatientRegistrationNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatientRegistrationFirstName;
        private System.Windows.Forms.TextBox txtPatientRegistrationSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPatientRegistrationSearchPatient;
        private System.Windows.Forms.RichTextBox txtPatientRegistrationAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatientRegistrationContactNo;
        private System.Windows.Forms.Button btnPatientRegistrationSave;
        private System.Windows.Forms.Button btnPatientRegistrationDelete;
        private System.Windows.Forms.Button btnPatientRegistrationUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1e3;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPatientRegistrationRegistrationFee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox386;
    }
}

