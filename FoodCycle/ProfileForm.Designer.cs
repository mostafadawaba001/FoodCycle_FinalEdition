namespace FoodCycle
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProfileRole = new System.Windows.Forms.TextBox();
            this.lblProfileRoleTitle = new System.Windows.Forms.Label();
            this.txtProfileAddress = new System.Windows.Forms.TextBox();
            this.lblProfileAddressTitle = new System.Windows.Forms.Label();
            this.txtProfilePhone = new System.Windows.Forms.TextBox();
            this.lblProfilePhoneTitle = new System.Windows.Forms.Label();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.lblProfileEmailTitle = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblProfileNameTitle = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Profile Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.txtProfileRole);
            this.groupBox1.Controls.Add(this.lblProfileRoleTitle);
            this.groupBox1.Controls.Add(this.txtProfileAddress);
            this.groupBox1.Controls.Add(this.lblProfileAddressTitle);
            this.groupBox1.Controls.Add(this.txtProfilePhone);
            this.groupBox1.Controls.Add(this.lblProfilePhoneTitle);
            this.groupBox1.Controls.Add(this.txtProfileEmail);
            this.groupBox1.Controls.Add(this.lblProfileEmailTitle);
            this.groupBox1.Controls.Add(this.txtProfileName);
            this.groupBox1.Controls.Add(this.lblProfileNameTitle);
            this.groupBox1.Location = new System.Drawing.Point(25, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // txtProfileRole
            // 
            this.txtProfileRole.Location = new System.Drawing.Point(118, 271);
            this.txtProfileRole.Name = "txtProfileRole";
            this.txtProfileRole.ReadOnly = true;
            this.txtProfileRole.Size = new System.Drawing.Size(300, 22);
            this.txtProfileRole.TabIndex = 4;
            // 
            // lblProfileRoleTitle
            // 
            this.lblProfileRoleTitle.AutoSize = true;
            this.lblProfileRoleTitle.Location = new System.Drawing.Point(22, 271);
            this.lblProfileRoleTitle.Name = "lblProfileRoleTitle";
            this.lblProfileRoleTitle.Size = new System.Drawing.Size(96, 16);
            this.lblProfileRoleTitle.TabIndex = 10;
            this.lblProfileRoleTitle.Text = "Account Type :";
            // 
            // txtProfileAddress
            // 
            this.txtProfileAddress.Location = new System.Drawing.Point(118, 221);
            this.txtProfileAddress.Name = "txtProfileAddress";
            this.txtProfileAddress.ReadOnly = true;
            this.txtProfileAddress.Size = new System.Drawing.Size(300, 22);
            this.txtProfileAddress.TabIndex = 3;
            // 
            // lblProfileAddressTitle
            // 
            this.lblProfileAddressTitle.AutoSize = true;
            this.lblProfileAddressTitle.Location = new System.Drawing.Point(22, 221);
            this.lblProfileAddressTitle.Name = "lblProfileAddressTitle";
            this.lblProfileAddressTitle.Size = new System.Drawing.Size(64, 16);
            this.lblProfileAddressTitle.TabIndex = 8;
            this.lblProfileAddressTitle.Text = "Address :";
            // 
            // txtProfilePhone
            // 
            this.txtProfilePhone.Location = new System.Drawing.Point(118, 176);
            this.txtProfilePhone.Name = "txtProfilePhone";
            this.txtProfilePhone.ReadOnly = true;
            this.txtProfilePhone.Size = new System.Drawing.Size(300, 22);
            this.txtProfilePhone.TabIndex = 2;
            // 
            // lblProfilePhoneTitle
            // 
            this.lblProfilePhoneTitle.AutoSize = true;
            this.lblProfilePhoneTitle.Location = new System.Drawing.Point(22, 176);
            this.lblProfilePhoneTitle.Name = "lblProfilePhoneTitle";
            this.lblProfilePhoneTitle.Size = new System.Drawing.Size(52, 16);
            this.lblProfilePhoneTitle.TabIndex = 6;
            this.lblProfilePhoneTitle.Text = "Phone :";
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Location = new System.Drawing.Point(118, 130);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.ReadOnly = true;
            this.txtProfileEmail.Size = new System.Drawing.Size(300, 22);
            this.txtProfileEmail.TabIndex = 1;
            // 
            // lblProfileEmailTitle
            // 
            this.lblProfileEmailTitle.AutoSize = true;
            this.lblProfileEmailTitle.Location = new System.Drawing.Point(22, 130);
            this.lblProfileEmailTitle.Name = "lblProfileEmailTitle";
            this.lblProfileEmailTitle.Size = new System.Drawing.Size(47, 16);
            this.lblProfileEmailTitle.TabIndex = 4;
            this.lblProfileEmailTitle.Text = "Email :";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(118, 79);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.ReadOnly = true;
            this.txtProfileName.Size = new System.Drawing.Size(300, 22);
            this.txtProfileName.TabIndex = 0;
            // 
            // lblProfileNameTitle
            // 
            this.lblProfileNameTitle.AutoSize = true;
            this.lblProfileNameTitle.Location = new System.Drawing.Point(22, 79);
            this.lblProfileNameTitle.Name = "lblProfileNameTitle";
            this.lblProfileNameTitle.Size = new System.Drawing.Size(74, 16);
            this.lblProfileNameTitle.TabIndex = 2;
            this.lblProfileNameTitle.Text = "Full Name :";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(304, 400);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(110, 40);
            this.btnEditProfile.TabIndex = 5;
            this.btnEditProfile.Text = "Edit";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Enabled = false;
            this.btnSaveProfile.Location = new System.Drawing.Point(420, 400);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(110, 40);
            this.btnSaveProfile.TabIndex = 6;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(156, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProfileRole;
        private System.Windows.Forms.Label lblProfileRoleTitle;
        private System.Windows.Forms.TextBox txtProfileAddress;
        private System.Windows.Forms.Label lblProfileAddressTitle;
        private System.Windows.Forms.Label lblProfilePhoneTitle;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label lblProfileEmailTitle;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfileNameTitle;
        private System.Windows.Forms.TextBox txtProfilePhone;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnBack;
    }
}