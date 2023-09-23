using Eshop.Domain.core.AppService;
using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Dtos.Pictures;
using Eshop.Domain.core.Dtos.Products;
using Eshop.Domain.core.IServices.FileService;
using Eshop.Domain.core.IServices.PictureService.Commands;
using EShop.Domain.core.IServices.ProductService.Commands;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.AppServices.ProductAppService
{
    public class ProductAppServices : IProductAppservices
    {
        protected readonly IProductCommandService _ProductcommandService;
        protected readonly IPictureCommandService _pictureCommandService;
        protected readonly IFileServices _fileServices;
        public ProductAppServices(IProductCommandService commandService, IFileServices fileServices, IPictureCommandService pictureCommandService)
        {
            _ProductcommandService = commandService;
            _fileServices = fileServices;
            _pictureCommandService = pictureCommandService;
        }
        public async Task CreateProduct(ProductAddDto productAddDto, List<IFormFile> PhotFiles, string UploadPath)
        {

            var ProductId = await _ProductcommandService.CreateProduct(productAddDto);
            foreach (var Photo in PhotFiles)
            {
                var fileNameWithoutExtension = DateTime.Now.Ticks.ToString();

                var FilePath = await _fileServices.FileUploadAsync(fileNameWithoutExtension, UploadPath, Photo);

                PictureAddDto pictureAddDto = new PictureAddDto
                {
                    ProductId = ProductId,
                    PictureLinkAddress = FilePath
                };

                await _pictureCommandService.CreatePicture(pictureAddDto);
            }

        }

        public Task UpdateProduct(ProductEditDto productEditDto)
        {
            throw new NotImplementedException();
        }
    }
}
