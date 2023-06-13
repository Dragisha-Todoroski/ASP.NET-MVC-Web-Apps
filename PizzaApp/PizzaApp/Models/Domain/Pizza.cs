namespace PizzaApp.Models.Domain
{
    public class Pizza
    {
        public Pizza(int id, string name, int price, bool isOnPromotion)
        {
            Id = id;
            Name = name;
            Price = price;
            IsOnPromotion = isOnPromotion;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}
