namespace BakeryMVCApp.Models
{
    public class Order
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public double Price { get; set; } = 0.00;
        public List<int> Date { get; set; } = new List<int> { 12, 25, 2022 };

        public Order(string title, string description, double price, List<int> date) {
            Title = title;
            Description = description;
            Price = price;
            Date = date;
        }
    }
}