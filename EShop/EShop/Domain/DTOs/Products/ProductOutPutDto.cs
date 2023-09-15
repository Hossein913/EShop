﻿using EShop.Domain.DTOs.Category;
using EShop.Domain.Entity;

namespace EShop.Domain.DTOs.Products
{
    public class ProductOutPutDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int CategoryId { get; set; }

        public int? Quntity { get; set; }
        public List<GeneralCategoryDto> Category { get; set; }
}
}
