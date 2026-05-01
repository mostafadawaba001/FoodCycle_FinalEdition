namespace FoodCycle
{
    partial class CharityForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCharityTitle = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRequestDonation = new System.Windows.Forms.Button();
            this.dgvAvailableDonations = new System.Windows.Forms.DataGridView();
            this.colProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableDonations)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblCharityTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblCharityTitle
            // 
            this.lblCharityTitle.AutoSize = true;
            this.lblCharityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharityTitle.Location = new System.Drawing.Point(23, 21);
            this.lblCharityTitle.Name = "lblCharityTitle";
            this.lblCharityTitle.Size = new System.Drawing.Size(412, 38);
            this.lblCharityTitle.TabIndex = 0;
            this.lblCharityTitle.Text = "Available Food Donations";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnBack);
            this.pnlFooter.Controls.Add(this.btnRequestDonation);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 350);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 100);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(442, 31);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 29);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRequestDonation
            // 
            this.btnRequestDonation.Location = new System.Drawing.Point(551, 31);
            this.btnRequestDonation.Name = "btnRequestDonation";
            this.btnRequestDonation.Size = new System.Drawing.Size(237, 29);
            this.btnRequestDonation.TabIndex = 0;
            this.btnRequestDonation.Text = "Request This Donation";
            this.btnRequestDonation.UseVisualStyleBackColor = true;
            this.btnRequestDonation.Click += new System.EventHandler(this.btnRequestDonation_Click);
            // 
            // dgvAvailableDonations
            // 
            this.dgvAvailableDonations.AllowUserToAddRows = false;
            this.dgvAvailableDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableDonations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProvider,
            this.colFoodType,
            this.colQty,
            this.colExpiry,
            this.colAddress});
            this.dgvAvailableDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvailableDonations.Location = new System.Drawing.Point(0, 100);
            this.dgvAvailableDonations.MultiSelect = false;
            this.dgvAvailableDonations.Name = "dgvAvailableDonations";
            this.dgvAvailableDonations.ReadOnly = true;
            this.dgvAvailableDonations.RowHeadersVisible = false;
            this.dgvAvailableDonations.RowHeadersWidth = 51;
            this.dgvAvailableDonations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableDonations.Size = new System.Drawing.Size(800, 250);
            this.dgvAvailableDonations.TabIndex = 2;
            // 
            // colProvider
            // 
            this.colProvider.HeaderText = "Provider Name";
            this.colProvider.MinimumWidth = 6;
            this.colProvider.Name = "colProvider";
            this.colProvider.ReadOnly = true;
            // 
            // colFoodType
            // 
            this.colFoodType.HeaderText = "Food Type";
            this.colFoodType.MinimumWidth = 6;
            this.colFoodType.Name = "colFoodType";
            this.colFoodType.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colExpiry
            // 
            this.colExpiry.HeaderText = "Expiry Date";
            this.colExpiry.MinimumWidth = 6;
            this.colExpiry.Name = "colExpiry";
            this.colExpiry.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Provider Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // CharityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAvailableDonations);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "CharityForm";
            this.Text = "CharityForm";
            this.Load += new System.EventHandler(this.CharityForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableDonations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCharityTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.DataGridView dgvAvailableDonations;
        private System.Windows.Forms.Button btnRequestDonation;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DataGridViewTextBoxColumn colProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
    }
}