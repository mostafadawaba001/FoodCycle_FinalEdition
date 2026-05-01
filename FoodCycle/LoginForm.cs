using FoodCycle.Models;
using System;
using System.IO;
using System.Windows.Forms;
namespace FoodCycle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
             Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string inputEmail = txtEmail.Text;
                string inputPass = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(inputEmail) || string.IsNullOrWhiteSpace(inputPass))
                {
                    MessageBox.Show("Please enter both Email and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!File.Exists("Users.txt"))
                {
                    MessageBox.Show("System Database not found. Please register first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] allLines = File.ReadAllLines("Users.txt");
                bool isFound = false;

                foreach (string line in allLines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] data = line.Split(',');

                    if (data.Length >= 6)
                    {
                        string fileEmail = data[1];
                        string filePass = data[2];

                        if (inputEmail == fileEmail && inputPass == filePass)
                        {
                            isFound = true;

                            string name = data[0];
                            string email = data[1];
                            string password = data[2];
                            string address = data[3];
                            string phone = data[4];
                            string userRoleText = data[5]; 

                            if (userRoleText == "Admin")
                            {
                                User.CurrentUser = new Admin(name, email, password, address, phone);
                            }
                            else if (userRoleText == "CharityOrganization")
                            {
                                User.CurrentUser = new CharityOrganization(name, email, password, address, phone);
                            }
                            else if (userRoleText == "FoodProvider") 
                            {
                                User.CurrentUser = new FoodProvider(name, email, password, address, phone);
                            }

                            MessageBox.Show($"Welcome back, {name}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainDashboard mainDash = new MainDashboard(userRoleText);
                            mainDash.Show();
                            Hide();
                            break;
                        }
                    }
                }

                if (!isFound)
                {
                    MessageBox.Show("Invalid Email or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        

    }
}