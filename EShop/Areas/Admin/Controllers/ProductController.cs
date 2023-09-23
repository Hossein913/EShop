using Eshop.Domain.core.AppService;
using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Dtos.Products;
using EShop.Domain.core.IServices.CategoryService.Command;
using EShop.Domain.core.IServices.CategoryService.Queries;
using EShop.ViewModels;
using EShop.ViewModels.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IProductAppservices _productAppservices ;
        public ProductController(
            IWebHostEnvironment hostingEnvironment, IProductAppservices productAppservices)
        {
            _hostingEnvironment = hostingEnvironment;
            _productAppservices = productAppservices;
        }



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductViewModel Model)
        {

            if (!ModelState.IsValid)
                return View(Model);

            if (Model.PhotoFiles != null && Model.PhotoFiles.Count > 0)
            {
                var wwwrootPath = _hostingEnvironment.WebRootPath;
                var uploadPath = Path.Combine(wwwrootPath, "upload/Img/Product");

                ProductAddDto productAddDto = new ProductAddDto
                {
                    Name = Model.Name!,
                    Price = Model.Price,
                    Quntity = Model.Quntity,
                    CategoryId = Model.CategoryId,
                    Description = Model.Description!
                };

                await _productAppservices.CreateProduct(productAddDto, Model.PhotoFiles, uploadPath);

                return View();
            }

            return View(Model);




            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
