
using App.Domain.Core.Entities;
using App.Domain.Core.DataAccess;
using Microsoft.EntityFrameworkCore;
using App.Infrastructures.Db.SqlServer.Ef;

namespace App.Infrastructures.Ripositories
{

    public class ProductRepository : IProductRepository
    {
        private readonly EshopContext _context;

        public ProductRepository(EshopContext context)
        {
            _context = context;
        }

        public async Task Create(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int productId)
        {
            var category = await _context.Products.FindAsync(productId);
            category.IsDeleted = true;
            int number = await _context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetById(int productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task Update(Product product)
        {
            _context.Products.Update(product);
            int number = await _context.SaveChangesAsync();
        }
    }
}