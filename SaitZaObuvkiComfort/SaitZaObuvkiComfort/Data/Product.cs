namespace SaitZaObuvkiComfort.Data
{
    public class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }
        public string PhotoURL {  get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
        public ICollection<Category>Categories { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
