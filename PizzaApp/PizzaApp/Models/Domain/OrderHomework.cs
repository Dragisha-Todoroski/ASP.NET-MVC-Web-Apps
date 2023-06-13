namespace PizzaApp.Models.Domain
{
    public class OrderHomework
    {
        public OrderHomework(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }
    }
}
