using App.Domain.Core.Entities;

namespace App.Domain.Core.DtoModels.Cart
{
    public class CartOutputDto
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
