

using Eshop.Domain.core.Dtos.Products;

namespace EShop.Domain.core.IServices.ProductService.Commands
{
    public interface IProductCommandService
    {
        Task<int> CreateProduct(ProductAddDto product);
        Task<bool> DeleteProduct(int productId);
        Task<bool> EditeProduct(ProductEditDto product);
        Task<bool> AddProductToCartByProductid(int customerid, int productid);
        Task<bool> DeleteProductFromCart(int cartId, int productId);

    }
}
