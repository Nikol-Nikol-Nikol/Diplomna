﻿namespace SaitZaObuvkiComfort.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime Data {  get; set; }= DateTime.Now;
    }
}
