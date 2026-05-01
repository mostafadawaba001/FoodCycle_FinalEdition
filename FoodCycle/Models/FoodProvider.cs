using System.IO;

namespace FoodCycle.Models
{
    public class FoodProvider : User
    {
        public FoodProvider(string name, string email, string password, string address, string phone)
            : base(name, email, password, address, phone, UserRole.FoodProvider)
        {
        }

        public FoodProvider() { }
        public void AddDonation(string foodType, string quantity, string expiryDate)
        {
            string donationData = $"{this.Name},{foodType},{quantity},{expiryDate},{this.Address},Pending";
           File.AppendAllLines("Donations.txt", new string[] { donationData });
        }

    }
}