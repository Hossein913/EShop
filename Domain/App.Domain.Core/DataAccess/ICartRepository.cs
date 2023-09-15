using App.Domain.Core.Entities;

namespace App.Domain.Core.DataAccess
{
    public interface ICartRepository
    {
        Task Create(Cart cart);
        Task Update(Cart cart);
        Task Delete(int cartId);
        Task<Cart> GetById(int cartId);
        Task<List<Cart>> GetAll();
    }
}
