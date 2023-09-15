using App.Domain.Core.DtoModels;
using App.Domain.Core.Entities;

namespace App.Domain.Core.DataAccess
{
    public interface IProductRepository
    {
        Task Create(Product product);
        Task Update(Product product);
        Task Delete(int productId);
        Task<Product> GetById(int productId);
        Task<List<Product>> GetAll();
    }
}
