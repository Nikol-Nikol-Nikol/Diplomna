namespace SaitZaObuvkiComfort.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationDate {  get; set; }= DateTime.Now;
        
    }
}
