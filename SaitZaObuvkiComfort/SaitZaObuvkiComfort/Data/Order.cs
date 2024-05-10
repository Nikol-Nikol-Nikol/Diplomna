namespace SaitZaObuvkiComfort.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public Client Clients { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
       
        public DateTime Data {  get; set; }= DateTime.Now;
    }
}
