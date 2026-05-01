using FoodCycle.Models;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FoodCycle
{
    public partial class ProviderForm : Form
    {
        string loggedInUser;

        public ProviderForm()
        {
            InitializeComponent();


            loggedInUser = (User.CurrentUser != null) ? User.CurrentUser.Name : "Guest";
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            Text = "Welcome, " + loggedInUser;

            cmbFoodType.Items.Clear();
            cmbFoodType.Items.AddRange(new string[] {
                "Meat & Poultry", "Fish & Seafood", "Vegetables", "Fruits",
                "Grains, Rice & Pasta", "Dairy & Eggs", "Bakery & Bread",
                "Canned & Jarred Goods", "Legumes & Nuts", "Beverages",
                "Ready-to-eat Meals", "Other"
            });

            if (cmbFoodType.Items.Count > 0)
                cmbFoodType.SelectedIndex = 0;

            LoadDonations();
        }

        private void btnAddDonation_Click(object sender, EventArgs e)
        {
            try
            {
                string foodType = (cmbFoodType.SelectedItem != null) ? cmbFoodType.SelectedItem.ToString() : "Not Specified";
                string quantity = numQuantity.Value.ToString();
                string expiryDate = dtpExpiryDate.Value.ToString("dd/MM/yyyy");

                if (User.CurrentUser is FoodProvider provider)
                {
                    provider.AddDonation(foodType, quantity, expiryDate);

                    MessageBox.Show("Donation added successfully! ", "Success");
                    LoadDonations(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadDonations()
        {
            try
            {
                if (File.Exists("Donations.txt"))
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Provider"); 
                    dt.Columns.Add("Food Type");
                    dt.Columns.Add("Quantity");
                    dt.Columns.Add("Expiry Date");
                    dt.Columns.Add("Status");

                    string[] lines = File.ReadAllLines("Donations.txt");
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] data = line.Split(',');

                        if (data.Length >= 6 && data[0] == loggedInUser)
                        {
                            dt.Rows.Add(data[0], data[1], data[2], data[3], data[5]); 
                        }
                    }
                    dgvDonations.DataSource = dt;

                    if (dgvDonations.Columns.Count > 0)
                    {
                        dgvDonations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Data: " + ex.Message);
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
            MainDashboard newDash = new MainDashboard((User.CurrentUser != null) ? User.CurrentUser.Role.ToString() : "Guest"); newDash.Show();
            Close();
        }

        

     
    }
}