namespace FoodCycle
{
    partial class ProviderForm
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
            this.dgvDonations = new System.Windows.Forms.DataGridView();
            this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFoodType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddDonation = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpAddDonation = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpAddDonation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonations
            // 
            this.dgvDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUser,
            this.colType,
            this.colQty,
            this.colDate,
            this.colStatus});
            this.dgvDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonations.Location = new System.Drawing.Point(294, 0);
            this.dgvDonations.Name = "dgvDonations";
            this.dgvDonations.RowHeadersWidth = 51;
            this.dgvDonations.RowTemplate.Height = 24;
            this.dgvDonations.Size = new System.Drawing.Size(506, 405);
            this.dgvDonations.TabIndex = 6;
            // 
            // colUser
            // 
            this.colUser.DataPropertyName = "Provider";
            this.colUser.HeaderText = "Donor";
            this.colUser.MinimumWidth = 6;
            this.colUser.Name = "colUser";
            this.colUser.Width = 90;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Food Type";
            this.colType.HeaderText = "Food Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.Width = 91;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Quantity";
            this.colQty.HeaderText = "Quantity";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.Width = 90;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Expiry Date";
            this.colDate.HeaderText = "Expiry Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.Width = 91;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Type:";
            // 
            // cmbFoodType
            // 
            this.cmbFoodType.FormattingEnabled = true;
            this.cmbFoodType.Location = new System.Drawing.Point(21, 80);
            this.cmbFoodType.Name = "cmbFoodType";
            this.cmbFoodType.Size = new System.Drawing.Size(164, 24);
            this.cmbFoodType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(21, 157);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(164, 22);
            this.numQuantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expiry Date:";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Location = new System.Drawing.Point(21, 242);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(250, 22);
            this.dtpExpiryDate.TabIndex = 5;
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Location = new System.Drawing.Point(72, 299);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(135, 31);
            this.btnAddDonation.TabIndex = 1;
            this.btnAddDonation.Text = "Add Donation";
            this.btnAddDonation.UseVisualStyleBackColor = true;
            this.btnAddDonation.Click += new System.EventHandler(this.btnAddDonation_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(98, 357);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grpAddDonation
            // 
            this.grpAddDonation.Controls.Add(this.btnBack);
            this.grpAddDonation.Controls.Add(this.btnAddDonation);
            this.grpAddDonation.Controls.Add(this.dtpExpiryDate);
            this.grpAddDonation.Controls.Add(this.label3);
            this.grpAddDonation.Controls.Add(this.numQuantity);
            this.grpAddDonation.Controls.Add(this.label2);
            this.grpAddDonation.Controls.Add(this.cmbFoodType);
            this.grpAddDonation.Controls.Add(this.label1);
            this.grpAddDonation.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpAddDonation.Location = new System.Drawing.Point(0, 0);
            this.grpAddDonation.Name = "grpAddDonation";
            this.grpAddDonation.Size = new System.Drawing.Size(294, 405);
            this.grpAddDonation.TabIndex = 0;
            this.grpAddDonation.TabStop = false;
            this.grpAddDonation.Text = "Add_Donation";
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.dgvDonations);
            this.Controls.Add(this.grpAddDonation);
            this.Name = "ProviderForm";
            this.Text = "ProviderForm";
            this.Load += new System.EventHandler(this.ProviderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpAddDonation.ResumeLayout(false);
            this.grpAddDonation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDonations;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFoodType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Button btnAddDonation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpAddDonation;
    }
}