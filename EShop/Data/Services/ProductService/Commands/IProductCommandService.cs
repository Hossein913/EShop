﻿using EShop.Domain.DTOs.Products;

namespace EShop.Domain.IServices.ProductService.Commands
{
    public class ProductCommandService : IProductCommandService
    {
        public Task<bool> AddPicture(int PictureId, int item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddProductToCartByProductid(int customerid, int productid)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateProduct(ProductAddDto product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProductFromCart(int cartId, int productId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditeProduct(ProductEditDto product)
        {
            throw new NotImplementedException();
        }
    }
}
