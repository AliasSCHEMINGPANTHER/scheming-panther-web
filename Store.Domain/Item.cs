using Store.Domain;

namespace Store.Domain

{
    public class Item
    {
        public string Name { get; }
        public string Description { get; }
        public string Brand { get; }
        public decimal Price { get; }
        public List<Rating>Ratings {get; set; } =new List<Rating>();
        public Item(string name, string description, string brand, decimal price)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name);
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException(description);
            }

            if (string.IsNullOrEmpty(brand))
            {
                throw new ArgumentNullException(brand);
            }

            if (price < 0.00m)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }

            Name = name;
            Description = description;
            Brand = brand;
            Price = price;
        }
    }
}
