using FoodCycle.Models; 
using System;
using System.IO;
using System.Windows.Forms;

namespace FoodCycle
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (User.CurrentUser != null)
            {
                txtProfileName.Text = User.CurrentUser.Name;
                txtProfileEmail.Text = User.CurrentUser.Email;
                txtProfilePhone.Text = User.CurrentUser.Phonenumber;
                txtProfileAddress.Text = User.CurrentUser.Address;
                txtProfileRole.Text = User.CurrentUser.Role.ToString();
            }

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            txtProfileName.ReadOnly = false;
            txtProfileEmail.ReadOnly = false;
            txtProfilePhone.ReadOnly = false; //EDIT ==> SAVE , SAVE ==> EDIT
            txtProfileAddress.ReadOnly = false;

            btnSaveProfile.Enabled = true;
            btnEditProfile.Enabled = false;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "Users.txt";
                string[] lines = File.ReadAllLines(filePath);
                bool updated = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');

                    if (data[1] == User.CurrentUser.Email)
                    {
                        
                        lines[i] = $"{txtProfileName.Text},{txtProfileEmail.Text},{data[2]},{txtProfileAddress.Text},{txtProfilePhone.Text},{data[5]}";
                        updated = true;
                        break;
                    }
                }

                if (updated)
                {
                    File.WriteAllLines(filePath, lines);

                    User.CurrentUser.Name = txtProfileName.Text;
                    User.CurrentUser.Email = txtProfileEmail.Text;
                    User.CurrentUser.Phonenumber = txtProfilePhone.Text;
                    User.CurrentUser.Address = txtProfileAddress.Text;

                    MessageBox.Show("Profile Updated Successfully! ");

                    txtProfileName.ReadOnly = txtProfileEmail.ReadOnly = txtProfileAddress.ReadOnly = txtProfilePhone.ReadOnly = true;
                    btnSaveProfile.Enabled = false;
                    btnEditProfile.Enabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainDashboard dash = new MainDashboard(User.CurrentUser.Role.ToString());
            dash.Show();

            Close();
        }
    }
 }
