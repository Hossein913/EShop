

using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Dtos.Products;
using EShop.Domain.core.IServices.ProductService.Commands;

namespace EShop.Domain.Services.ProductService.Commands
{
    public class ProductCommandService : IProductCommandService
    {

        protected readonly IProductRepository _productRepository;

        public ProductCommandService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<bool> AddProductToCartByProductid(int customerid, int productid)
        {
            throw new NotImplementedException();
        }

        public async Task<int> CreateProduct(ProductAddDto productAddDto)
        {
            var productId = await _productRepository.Create(productAddDto);
            return productId;
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductFromCart(int cartId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditeProduct(ProductEditDto product)
        {
            throw new NotImplementedException();
        }
    }
}
