

using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos.Products;
using Eshop.Domain.core.Entities;
using Eshop.Infra.Db_SqlServer.EF;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infra.Data.Repos.Ef
{
    public class ProductRepository : IProductRepository
    {
        private readonly EshopContext _context;

        public ProductRepository(EshopContext context)
        {
            _context = context;
        }

        public async Task<int> Create(ProductAddDto productAddDto)
        {
            Product product = new Product
            { 
             Name = productAddDto.Name,
             CategoryId = productAddDto.CategoryId,
             Quntity = productAddDto.Quntity,
             Price = productAddDto.Price,   
            };

            await _context.Products.AddAsync(product);
            var result = await _context.SaveChangesAsync();
            if (result != 0)
                return product.Id;

            return 0;
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

        public async Task Update(ProductEditDto productEditDto)
        {
            Product product = new Product
            {
                Id = productEditDto.Id,
                Name = productEditDto.Name,
                CategoryId = productEditDto.CategoryId,
                Quntity = productEditDto.Quntity,
                Price = productEditDto.Price,
            };
            _context.Products.Update(product);
            int number = await _context.SaveChangesAsync();
        }
    }
}
