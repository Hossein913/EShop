﻿

using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos.Category;
using EShop.Domain.core.IServices.CategoryService.Queries;

namespace EShop.Domain.Services.CategoryService.Queries
{
    public class CategoryQueryService : ICategoryQueryService
    {
        private readonly ICategoryRepository repository;

        public CategoryQueryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<CategoryOutputDto>> GetAllCategory()
        {
            var categores = await repository.GetAll();

            return categores;
        }
    }
}
