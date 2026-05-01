namespace FoodCycle
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pending = new System.Windows.Forms.Panel();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.Accepted = new System.Windows.Forms.Panel();
            this.lblAcceptedCount = new System.Windows.Forms.Label();
            this.lblAcceptedTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.pending.SuspendLayout();
            this.Accepted.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.pbUser);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 546);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(52, 472);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(12, 96);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Welcome, User";
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(12, 12);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(75, 68);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(52, 391);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(52, 293);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(116, 34);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(52, 198);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 34);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.pending);
            this.pnlContainer.Controls.Add(this.Accepted);
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContainer.Location = new System.Drawing.Point(266, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(615, 546);
            this.pnlContainer.TabIndex = 1;
            // 
            // pending
            // 
            this.pending.BackColor = System.Drawing.Color.Orange;
            this.pending.Controls.Add(this.lblPendingCount);
            this.pending.Controls.Add(this.lblPendingTitle);
            this.pending.Location = new System.Drawing.Point(403, 255);
            this.pending.Name = "pending";
            this.pending.Size = new System.Drawing.Size(200, 100);
            this.pending.TabIndex = 2;
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingCount.ForeColor = System.Drawing.Color.White;
            this.lblPendingCount.Location = new System.Drawing.Point(65, 38);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(43, 46);
            this.lblPendingCount.TabIndex = 6;
            this.lblPendingCount.Text = "0";
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingTitle.Location = new System.Drawing.Point(28, 22);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(150, 20);
            this.lblPendingTitle.TabIndex = 4;
            this.lblPendingTitle.Text = "Pending Donations";
            // 
            // Accepted
            // 
            this.Accepted.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Accepted.Controls.Add(this.lblAcceptedCount);
            this.Accepted.Controls.Add(this.lblAcceptedTitle);
            this.Accepted.Location = new System.Drawing.Point(403, 132);
            this.Accepted.Name = "Accepted";
            this.Accepted.Size = new System.Drawing.Size(200, 100);
            this.Accepted.TabIndex = 1;
            // 
            // lblAcceptedCount
            // 
            this.lblAcceptedCount.AutoSize = true;
            this.lblAcceptedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptedCount.ForeColor = System.Drawing.Color.White;
            this.lblAcceptedCount.Location = new System.Drawing.Point(65, 36);
            this.lblAcceptedCount.Name = "lblAcceptedCount";
            this.lblAcceptedCount.Size = new System.Drawing.Size(43, 46);
            this.lblAcceptedCount.TabIndex = 5;
            this.lblAcceptedCount.Text = "0";
            // 
            // lblAcceptedTitle
            // 
            this.lblAcceptedTitle.AutoSize = true;
            this.lblAcceptedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptedTitle.Location = new System.Drawing.Point(28, 16);
            this.lblAcceptedTitle.Name = "lblAcceptedTitle";
            this.lblAcceptedTitle.Size = new System.Drawing.Size(160, 20);
            this.lblAcceptedTitle.TabIndex = 3;
            this.lblAcceptedTitle.Text = "Accepted Donations";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.lblTotalCount);
            this.panel2.Controls.Add(this.lblTotalTitle);
            this.panel2.Location = new System.Drawing.Point(403, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.White;
            this.lblTotalCount.Location = new System.Drawing.Point(65, 34);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(43, 46);
            this.lblTotalCount.TabIndex = 4;
            this.lblTotalCount.Text = "0";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalTitle.Location = new System.Drawing.Point(27, 14);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(127, 20);
            this.lblTotalTitle.TabIndex = 3;
            this.lblTotalTitle.Text = "Total Donations";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 546);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pending.ResumeLayout(false);
            this.pending.PerformLayout();
            this.Accepted.ResumeLayout(false);
            this.Accepted.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pending;
        private System.Windows.Forms.Panel Accepted;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblAcceptedTitle;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblAcceptedCount;
        private System.Windows.Forms.Button btnExit;
    }
}