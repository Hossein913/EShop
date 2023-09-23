
using Eshop.Domain.core.Dtos.Products;
using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.DataAccess.EfRipository
{
    public interface IProductRepository
    {
        Task<int> Create(ProductAddDto productAddDto);
        Task Update(ProductEditDto productEditDto);
        Task Delete(int productId);
        Task<Product> GetById(int productId);
        Task<List<Product>> GetAll();
    }
}
