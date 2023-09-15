using App.Domain.Core.DtoModels.Cart;
using App.Domain.Core.Entities;
using App.Infrastructures.Db.SqlServer.Ef;
using App.Domain.Core.DataAccess;

namespace App.Domain.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly EshopContext _context;

        public CartRepository(EshopContext context)
        {
            _context = context;
        }
        public async Task Create(Cart cart)
        {
            await _context.Carts.AddAsync(cart);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int cartId)
        {
            var category = await _context.Carts.FindAsync(cartId);
            category.IsDeleted = true;
            int number = await _context.SaveChangesAsync();
        }

        public Task<List<Cart>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetById(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task Update(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
