﻿namespace App.Domain.Core.Entities
{ 
    public class Order
    {
        public int Id { get; set; }

        public int Quntity { get; set; }

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public Cart Cart { get; set; }

        public Product Product { get; set; }
    }
}
