using System.IO;

namespace FoodCycle.Models
{
    public class CharityOrganization : User
    {
        public CharityOrganization(string name, string email, string password, string address, string phone)
            : base(name, email, password, address, phone, UserRole.CharityOrganization) { }

        public CharityOrganization() { }

        public void RequestDonation(string providerName, string foodType, string newStatus)
        {
            string filePath = "Donations.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');

                    if (data.Length >= 6 &&data[0] == providerName &&data[1] == foodType &&data[5] == "Accepted")
                    {
                        data[5] = newStatus;
                        lines[i] = string.Join(",", data);
                        break;
                    }
                }
                File.WriteAllLines(filePath, lines);
            }
        }

    }
}
