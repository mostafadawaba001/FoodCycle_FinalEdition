namespace FoodCycle
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dgvAdminDonations = new System.Windows.Forms.DataGridView();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminDonations)).BeginInit();
            this.SuspendLayout();

            // panel1
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(389, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // btnReject
            this.btnReject.BackColor = System.Drawing.Color.LightCoral;
            this.btnReject.Location = new System.Drawing.Point(481, 15);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(133, 23);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject Donation";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);

            // btnAccept
            this.btnAccept.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAccept.Location = new System.Drawing.Point(632, 15);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(128, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept Donation";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);

            // dgvAdminDonations
            this.dgvAdminDonations.AllowUserToAddRows = false;
            this.dgvAdminDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminDonations.ColumnHeadersHeight = 35;
            this.dgvAdminDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvAdminDonations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProvider,
                this.colType,
                this.colQty,
                this.colExpiry,
                this.colAddress});

            this.dgvAdminDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminDonations.Location = new System.Drawing.Point(0, 0);
            this.dgvAdminDonations.MultiSelect = false;
            this.dgvAdminDonations.Name = "dgvAdminDonations";
            this.dgvAdminDonations.ReadOnly = true;
            this.dgvAdminDonations.RowHeadersWidth = 51;
            this.dgvAdminDonations.RowTemplate.Height = 24;
            this.dgvAdminDonations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminDonations.Size = new System.Drawing.Size(800, 390);
            this.dgvAdminDonations.TabIndex = 1;

            // colProvider
            this.colProvider.HeaderText = "Provider";
            this.colProvider.MinimumWidth = 6;
            this.colProvider.Name = "colProvider";
            this.colProvider.ReadOnly = true;

            // colType
            this.colType.HeaderText = "Food Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;

            // colQty
            this.colQty.HeaderText = "Quantity";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;

            // colExpiry
            this.colExpiry.HeaderText = "Expiry Date";
            this.colExpiry.MinimumWidth = 6;
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.ReadOnly = true;

            // colAddress
            this.colAddress.HeaderText = "Provider Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;

            // AdminForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAdminDonations);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";

            // IMPORTANT FIX
            this.Load += new System.EventHandler(this.AdminForm_Load);

            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminDonations)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAdminDonations;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    }
}