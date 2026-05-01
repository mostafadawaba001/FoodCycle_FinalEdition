using FoodCycle.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace FoodCycle
{
    public partial class AdminForm : Form
    {
        string filePath = "Donations.txt";

        public AdminForm()
        {
            InitializeComponent();

            

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadDonationsForAdmin();
        }

        private void LoadDonationsForAdmin() 
        {
            try
            {
                if (!File.Exists(filePath)) return;

                dgvAdminDonations.Rows.Clear();// avoid duplicates when refreshing or calling the load method multiple times "مش هنقرأ البيانات غير مرة واحدة " "اكثر امانا"

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] data = line.Split(',');

                    if (data.Length >= 6 && data[5] == "Pending")
                    {
                        dgvAdminDonations.Rows.Add(data[0], data[1], data[2], data[3], data[4]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin data: " + ex.Message);
            }
        
        }

      

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgvAdminDonations.SelectedRows.Count > 0)
            {
                string provider = dgvAdminDonations.SelectedRows[0].Cells["colProvider"].Value.ToString();// specfiying the wanted row and the wanted column to get the value of the provider name and food type to update the status of the donation
                string food = dgvAdminDonations.SelectedRows[0].Cells["colType"].Value.ToString();// specfiying the wanted row and the wanted column to get the value of the provider name and food type to update the status of the donation , the dgv returns object so we need to convert it to string to use it in the update method and to store it in the txt file

                ((Admin)User.CurrentUser).UpdateDonationStatus(provider, food, "Accepted");

                MessageBox.Show("Donation Approved! ✅", "Status Updated");
                LoadDonationsForAdmin();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }


        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvAdminDonations.SelectedRows.Count > 0)// check if the user has selected a row in the datagridview to avoid null reference exception when trying to access the cells of the selected row
            {
                string provider = dgvAdminDonations.SelectedRows[0].Cells["colProvider"].Value.ToString();
                string food = dgvAdminDonations.SelectedRows[0].Cells["colType"].Value.ToString();

                ((Admin)User.CurrentUser).UpdateDonationStatus(provider, food, "Rejected");// this method is only available for the admin user to update the status of the donation to rejected so explicit casting is required to access the method

                MessageBox.Show("Donation Rejected! ❌", "Status Updated");
                LoadDonationsForAdmin();
            }
            else
            {
                MessageBox.Show("Please select a row first.");// if no row is selected show a message box to inform the user to select a row first before trying to accept or reject a donation
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is MainDashboard dash)
                {
                    dash.UpdateDashboardStats(); 
                    dash.Show();
                    Close();
                    return;
                }
            }
            Close();
        }

      
    }
}