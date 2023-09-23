
using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos.Products;
using EShop.Domain.core.IServices.ProductService.Queries;

namespace EShop.Domain.Services.ProductService.Queries
{
    public class ProductQueryService : IProductQueryService
    {
        private readonly IProductRepository productRepository;

        public ProductQueryService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Task<List<ProductOutPutDto>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductOutPutDto>> GetProductsByCategoryId(int categoryId)
        {
            productRepository.
        }

        public Task<List<ProductOutPutDto>> SeachInProduct(string name)
        {
            throw new NotImplementedException();
        }
    }
}
