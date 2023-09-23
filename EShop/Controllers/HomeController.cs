using EShop.Domain.core.IServices.CategoryService.Queries;
using EShop.Domain.core.IServices.ProductService.Queries;
using EShop.ViewModels;
using EShop.ViewModels.Category;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryQueryService _service;
        private readonly IProductQueryService _ProductService;


        public HomeController(ILogger<HomeController> logger, ICategoryQueryService service, IProductQueryService serviceQuery)
        {
            _logger = logger;
            _service = service;
            _ProductService = serviceQuery;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var categories = await _service.GetAllCategory();
            List<CategoryViewModel> categoryView = categories.Select(x => new CategoryViewModel {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Photo = x.Photo
            }).ToList();

            return View(categoryView);
        }
        
        public async Task<IActionResult> Index(int id)
        {
            
            var products = await _ProductService.GetProductsByCategoryId(id);
            List<ProductViewModel> categoryView = products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
            }).ToList();

            return View(categoryView);
        }




        public ActionResult Details(int id)
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }


    }
}