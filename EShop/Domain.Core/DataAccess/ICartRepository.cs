using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Cart;
using Domain.Core.Entities;

namespace Domain.Core.DataAccess
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
