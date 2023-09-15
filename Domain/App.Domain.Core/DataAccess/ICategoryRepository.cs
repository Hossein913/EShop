

using App.Domain.Core.Entities;

namespace App.Domain.Core.DataAccess
{
    public interface ICategoryRepository
    {
        Task     Create(Category category);
        Task Update(Category category);
        Task Delete(int categoryId);
        Task<Category> GetById(int categoryId);
        Task<List<Category>> GetAll();
    }
}
