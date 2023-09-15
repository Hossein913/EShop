namespace App.Domain.Core.DtoModels.Cart
{
    public class CartEditDto
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public bool? IsPaied { get; set; }
    }
}
