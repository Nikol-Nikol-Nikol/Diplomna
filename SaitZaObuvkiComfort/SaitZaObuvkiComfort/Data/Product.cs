using System.ComponentModel.DataAnnotations.Schema;

namespace SaitZaObuvkiComfort.Data
{
    public class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public int Size { get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price { get; set; }
        public string PhotoURL {  get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
        public ICollection<Order> Orders { get; set; }
    }
}
