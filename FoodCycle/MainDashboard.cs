using FoodCycle.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace FoodCycle
{
    public partial class MainDashboard : Form
    {
        string userRole = "";

        public MainDashboard(string role)
        {
            InitializeComponent();
            userRole = role;

            if (User.CurrentUser != null)
            {
                lblUserName.Text = "Welcome, " + User.CurrentUser.Name;
            }
            UpdateDashboardStats();

        }



        private void btnProfile_Click(object sender, EventArgs e)

        {
            ProfileForm prof = new ProfileForm();
            prof.Show();

            Close();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            Form nextForm = null;

            if (userRole == "FoodProvider")
            {
                nextForm = new ProviderForm();
            }
            else if (userRole == "Admin")
            {
                nextForm = new AdminForm();
            }
            else if (userRole == "CharityOrganization")
            {
                nextForm = new CharityForm();
            }

            if (nextForm != null)
            {
                nextForm.Show();
                Hide();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Show();

            Close();
        }

   

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to exit Food Cycle?","Confirm Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public void UpdateDashboardStats()
        {
            int total = 0;
            int accepted = 0;
            int pending = 0;

            try
            {
                string filePath = "Donations.txt";

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        string[] data = line.Split(',');

                        if (data.Length >= 6)
                        {
                            total++;
                            string status = data[5];

                            if (status == "Accepted" || status == "Requested" )
                                accepted++;
                            else if (status == "Pending")
                                pending++;
                        }
                    }
                }

               
                lblTotalCount.Text = total.ToString();
                lblAcceptedCount.Text = accepted.ToString();
                lblPendingCount.Text = pending.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stats: " + ex.Message);
            }
        }

      
    }
}