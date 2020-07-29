namespace WindowsFormsApplication1
{
    partial class frmUserManagement
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
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDoctorRegistrationDoctorID = new System.Windows.Forms.TextBox();
            this.txtDoctorRegistrationFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserManagementUpdate = new System.Windows.Forms.Button();
            this.btnUserManagementDelete = new System.Windows.Forms.Button();
            this.btnUserManagementSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 32);
            this.label8.TabIndex = 78;
            this.label8.Text = "Manage Users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.People_Doctor_Male_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(30, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 138);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // txtDoctorRegistrationDoctorID
            // 
            this.txtDoctorRegistrationDoctorID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoctorRegistrationDoctorID.ForeColor = System.Drawing.Color.Red;
            this.txtDoctorRegistrationDoctorID.Location = new System.Drawing.Point(228, 227);
            this.txtDoctorRegistrationDoctorID.MaxLength = 5;
            this.txtDoctorRegistrationDoctorID.Name = "txtDoctorRegistrationDoctorID";
            this.txtDoctorRegistrationDoctorID.Size = new System.Drawing.Size(152, 22);
            this.txtDoctorRegistrationDoctorID.TabIndex = 80;
            // 
            // txtDoctorRegistrationFirstName
            // 
            this.txtDoctorRegistrationFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoctorRegistrationFirstName.Location = new System.Drawing.Point(228, 274);
            this.txtDoctorRegistrationFirstName.MaxLength = 100;
            this.txtDoctorRegistrationFirstName.Name = "txtDoctorRegistrationFirstName";
            this.txtDoctorRegistrationFirstName.Size = new System.Drawing.Size(152, 22);
            this.txtDoctorRegistrationFirstName.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Username:";
            // 
            // btnUserManagementUpdate
            // 
            this.btnUserManagementUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagementUpdate.ImageKey = "(none)";
            this.btnUserManagementUpdate.Location = new System.Drawing.Point(703, 425);
            this.btnUserManagementUpdate.Name = "btnUserManagementUpdate";
            this.btnUserManagementUpdate.Size = new System.Drawing.Size(152, 53);
            this.btnUserManagementUpdate.TabIndex = 87;
            this.btnUserManagementUpdate.Text = " Update User";
            this.btnUserManagementUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManagementUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUserManagementDelete
            // 
            this.btnUserManagementDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagementDelete.ImageKey = "(none)";
            this.btnUserManagementDelete.Location = new System.Drawing.Point(434, 425);
            this.btnUserManagementDelete.Name = "btnUserManagementDelete";
            this.btnUserManagementDelete.Size = new System.Drawing.Size(152, 53);
            this.btnUserManagementDelete.TabIndex = 86;
            this.btnUserManagementDelete.Text = "Delete User";
            this.btnUserManagementDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManagementDelete.UseVisualStyleBackColor = true;
            // 
            // btnUserManagementSave
            // 
            this.btnUserManagementSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUserManagementSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagementSave.ImageKey = "(none)";
            this.btnUserManagementSave.Location = new System.Drawing.Point(185, 425);
            this.btnUserManagementSave.Name = "btnUserManagementSave";
            this.btnUserManagementSave.Size = new System.Drawing.Size(152, 53);
            this.btnUserManagementSave.TabIndex = 85;
            this.btnUserManagementSave.Text = "  Save User";
            this.btnUserManagementSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManagementSave.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(228, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 24);
            this.comboBox1.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 89;
            this.label2.Text = "Category:";
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnUserManagementUpdate);
            this.Controls.Add(this.btnUserManagementDelete);
            this.Controls.Add(this.btnUserManagementSave);
            this.Controls.Add(this.txtDoctorRegistrationDoctorID);
            this.Controls.Add(this.txtDoctorRegistrationFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Name = "frmUserManagement";
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDoctorRegistrationDoctorID;
        private System.Windows.Forms.TextBox txtDoctorRegistrationFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserManagementUpdate;
        private System.Windows.Forms.Button btnUserManagementDelete;
        private System.Windows.Forms.Button btnUserManagementSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}