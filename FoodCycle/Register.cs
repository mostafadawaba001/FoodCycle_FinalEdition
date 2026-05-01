using System;
using System.IO;
using System.Windows.Forms;
using FoodCycle.Models;

namespace FoodCycle
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

    

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||   string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name, Email, and Password).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                User.UserRole selectedRole;

                if (rbProvider.Checked)
                {
                    selectedRole = User.UserRole.FoodProvider;
                }
                else if (rbCharity.Checked)
                {
                    selectedRole =  User.UserRole.CharityOrganization;
                }
                else if (rbAdmin.Checked)
                {
                    selectedRole = User.UserRole.Admin;
                }
                else
                {
                    MessageBox.Show("Please select your role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string userData = $"{txtName.Text},{txtEmail.Text},{txtPassword.Text},{txtAddress.Text},{txtPhone.Text},{selectedRole}";
                string name = txtName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string address = txtAddress.Text;
                string phone = txtPhone.Text;


               File.AppendAllLines("Users.txt", new string[] { userData });

                MessageBox.Show("Registration successful! Your account has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                rbProvider.Checked = false;
                rbCharity.Checked = false;
                rbAdmin.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("A system error occurred: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
    
            Login loginPage = new Login();

            loginPage.Show();

           Hide();
        }
    }
}
