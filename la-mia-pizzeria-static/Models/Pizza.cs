namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UrlImage { get; set; }
        public float Price { get; set; }

        public Pizza(string name, string description, string urlImage, float price)
        {
            this.Name = name;
            this.Description = description;
            this.UrlImage = urlImage;
            this.Price = price;
        }
    }
}
