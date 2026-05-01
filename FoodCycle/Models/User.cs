using System.IO;
namespace FoodCycle.Models // best practice to use a namespace that reflects the folder structure and project organization, making it easier to manage and understand the codebase
{
    public class User
    {
        public enum UserRole//avoiding typos by using enum for user roles
        {
            FoodProvider,
            Admin,
            CharityOrganization

        }
        public static User CurrentUser { get; set; }  // static property was used in this project for the following {1} to easily access the currently logged-in user's information across different forms without needing to pass user data around, simplifying the code and improving maintainability.
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phonenumber { get; set; }
        public string Address {  get; set; }
        public UserRole Role { get; set; }// Role of the user (FoodProvider, Admin, CharityOrganization)
        public User(string name, string email, string password, string address, string phone, UserRole role)// Constructor to force setting all properties when creating a user, ensuring data integrity
        {
           Name = name;
           Email = email;
           Password = password;
           Address = address;
           Phonenumber = phone;
           Role = role;
        }
        public User() { }
       
    }
}