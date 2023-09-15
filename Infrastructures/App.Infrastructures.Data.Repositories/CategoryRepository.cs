using App.Infrastructures.Db.SqlServer.Ef;
using App.Domain.Core.DataAccess;
using App.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repository
{   
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EshopContext _context;
        public CategoryRepository(EshopContext eshopContext)
        {
            _context = eshopContext;
        }

        public async Task Create(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }   

        public async Task Delete(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            category.IsDeleted = true;
            int number = await _context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.AsNoTracking().ToListAsync(); 
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await _context.Categories.FindAsync(categoryId);
        }

        public async Task Update(Category category)
        {
            _context.Categories.Update(category);
            int number = await _context.SaveChangesAsync();
        }
    }
}   
