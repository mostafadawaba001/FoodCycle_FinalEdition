namespace FoodCycle.Models
{
    public class FoodItem
    {
        public string FoodName { get; set; }
        public double Quantity { get; set; }
        public string ExpirationDate { get; set; }

        public string ProviderName { get; set; }
        public string Status { get; set; }

        public FoodItem(string foodName, double quantity, string expirationDate, string providerName)
        {
            FoodName = foodName;
            Quantity = quantity;
            ExpirationDate = expirationDate;
            ProviderName = providerName;
            Status = "Pending"; 
        }

        public FoodItem() { }
    }
}