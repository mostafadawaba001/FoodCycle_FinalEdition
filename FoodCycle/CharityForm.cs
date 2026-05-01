using FoodCycle.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace FoodCycle
{
    public partial class CharityForm : Form
    {
        public CharityForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is MainDashboard dash) // is keyword is used to check if two objects are compatible with each other or not. It returns true if the object can be cast to the specified type, otherwise it returns false.
                {
                    dash.UpdateDashboardStats(); 
                    dash.Show();
                    Close();
                    return;
                }
            }
        }
        private void LoadDonations()
        {
            try
            {
                string filePath = "Donations.txt";
                if (!File.Exists(filePath)) return;

                dgvAvailableDonations.Rows.Clear(); 

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] data = line.Split(',');
                    if (data.Length >= 6 && data[5] == "Accepted")
                    {
                        dgvAvailableDonations.Rows.Add(data[0], data[1], data[2], data[3], data[4]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CharityForm_Load(object sender, EventArgs e)
        {
            LoadDonations();
        }

        private void btnRequestDonation_Click(object sender, EventArgs e)
        {
            if (dgvAvailableDonations.SelectedRows.Count > 0)
            {
                string providerName = dgvAvailableDonations.SelectedRows[0].Cells[0].Value.ToString();
                string foodType = dgvAvailableDonations.SelectedRows[0].Cells[1].Value.ToString();

                if (User.CurrentUser is CharityOrganization charity)
                {
                    charity.RequestDonation(providerName, foodType, "Requested");

                    MessageBox.Show("Great! Donation requested successfully ");

                    LoadDonations();
                }
            }
            else
            {
                MessageBox.Show("Please select a donation from the table first!");
            }
        }
    }
}
